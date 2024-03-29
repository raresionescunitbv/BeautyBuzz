using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using Twilio.Types;
using System.Diagnostics.Eventing.Reader;



namespace BeautyBuzz
{
    public partial class SmsVerificationApp : Form
    {
        public SqlConnection conn;

        private string firstName;
        private string lastName;
        private string userPassword;
        private string phoneNumber;
        private string confirmPassword;

        string server = "DESKTOP-NRU19T4\\SQLEXPRESS";
        string dbName = "master";


        private const string TwilioAccountSid = "ACb4c964ffa46ed6806c36c3e2ce49ea41";
        private const string TwilioAuthToken = "9a623401c1a811d6379613fabe841ec0";
        private const string TwilioPhoneNumber = "+15015504927";

        private string verificationCode;
        public SmsVerificationApp(string firstName, string lastName, string phoneNumber,string userPassword, string confirmPassword)
        {
            InitializeComponent();
            conn = new SqlConnection($"Server={server};Database={dbName};Trusted_Connection=False;Encrypt=True;");
            this.lastName = lastName;
            this.firstName = firstName;
            this.userPassword = userPassword;
            this.phoneNumber = phoneNumber;
            this.confirmPassword = confirmPassword;
        }

        private void SmsVerificationApp_Load(object sender, EventArgs e)
        {

        }

        private void VerificationButtonNumber_Click(object sender, EventArgs e)
        {
            verificationCode = GenerateRandomVerificationCode();
            try
            {
                TwilioClient.Init(TwilioAccountSid, TwilioAuthToken);
                var message = MessageResource.Create(
                            body: $"Cod de verificare: {verificationCode}",
                            from: new Twilio.Types.PhoneNumber(TwilioPhoneNumber),
                             to: new Twilio.Types.PhoneNumber("+40" + VerificationCodeNumber.Text)


                    ) ;
                MessageBox.Show("Codul de verificare a fost trimis cu succes!");
            }catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la trimiterea mesajului: {ex.Message}");
            }
        }

        private void ConfirmationButtonNumber_Click(object sender, EventArgs e)
        {
            if(ConfirmCodeNumber.Text == verificationCode)
            {
                MessageBox.Show("Inregistrare realizata cu succes!");
                this.Close();
                this.Hide();
                using (SqlConnection con = new SqlConnection($"Server={server};Database={dbName};Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    string query = "INSERT INTO TabelPhone (LastName, FirstName, Password, PhoneNumber, ConfirmPassword) VALUES (@LastName, @FirstName, @Password, @PhoneNumber, @ConfirmPassword)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@Password", userPassword);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@ConfirmPassword", confirmPassword);

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Contul a fost înregistrat cu succes!");
                        }
                        else
                        {
                            MessageBox.Show("Înregistrarea utilizatorului a eșuat!");
                        }
                        Console.WriteLine("Numărul de rânduri afectate: " + rowsAffected);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare la înregistrarea în baza de date: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                BeautyBuzz beautyBuzz = new BeautyBuzz();
                beautyBuzz.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Codul de verificare introdus este incorect!", "Eroare");
            }

        }
        
        private string GenerateRandomVerificationCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }
    }
}
