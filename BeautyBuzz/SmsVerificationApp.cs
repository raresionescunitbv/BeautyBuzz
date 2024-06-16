using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace BeautyBuzz
{
    public partial class SmsVerificationApp : Form
    {
        private SqlConnection conn;
        private string firstName;
        private string lastName;
        private string userPassword;
        private string phoneNumber;
        private string confirmPassword;
        private string verificationCode;
        private string twilioAccountSid;
        private string twilioAuthToken;
        private string twilioPhoneNumber;
        private SingleTon singleTon = SingleTon.Instance;

        public SmsVerificationApp(string firstName, string lastName, string phoneNumber, string userPassword, string confirmPassword)
        {
            InitializeComponent();
            conn = singleTon.GetConnection(); // Obțineți conexiunea de la Singleton
            this.lastName = lastName;
            this.firstName = firstName;
            this.userPassword = userPassword;
            this.phoneNumber = phoneNumber;
            this.confirmPassword = confirmPassword;
            this.FormClosing += SmsVerificationApp_FormClosing;

            twilioAccountSid = ConfigurationManager.AppSettings["TwilioAccountSid"];
            twilioAuthToken = ConfigurationManager.AppSettings["TwilioAuthToken"];
            twilioPhoneNumber = ConfigurationManager.AppSettings["TwilioPhoneNumber"];
<<<<<<< HEAD

            VerificationCodeNumber.Text = phoneNumber;
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        }

        private void SmsVerificationApp_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            pictureBox1.BackColor = Color.Transparent;
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f

        }

        private void VerificationButtonNumber_Click(object sender, EventArgs e)
        {
            verificationCode = GenerateRandomVerificationCode();
            try
            {
                TwilioClient.Init(twilioAccountSid, twilioAuthToken);
                var message = MessageResource.Create(
                    body: $"Cod de verificare: {verificationCode}",
                    from: new Twilio.Types.PhoneNumber(twilioPhoneNumber),
                    to: new Twilio.Types.PhoneNumber("+40" + VerificationCodeNumber.Text)
                );
                MessageBox.Show("Codul de verificare a fost trimis cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la trimiterea mesajului: {ex.Message}");
            }
        }

        private void ConfirmationButtonNumber_Click(object sender, EventArgs e)
        {
            if (ConfirmCodeNumber.Text == verificationCode)
            {
                MessageBox.Show("Înregistrare realizată cu succes!");
                this.Close();
                this.Hide();
                using (SqlConnection con = singleTon.GetConnection()) // Obțineți conexiunea de la Singleton
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

        private void SmsVerificationApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
<<<<<<< HEAD

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Hide();
        }
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
    }
}
