using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BeautyBuzz
{
    public partial class VerificationMail : Form
    {
        public SqlConnection conn;

        private string firstName;
        private string lastName;
        private string userPassword;
        private string mail;
        private string confirmPassword;

        string server = "DESKTOP-NRU19T4\\SQLEXPRESS";
        string dbName = "master";

        private System.Windows.Forms.Timer timvcode;
        public int Vcode { get; private set; }

        public VerificationMail(string firstName, string lastName, string userPassword, string mail, string confirmPassword)
        {
            InitializeComponent();
            conn = new SqlConnection($"Server={server};Database={dbName};Trusted_Connection=False;Encrypt=True;");
            timvcode = new System.Windows.Forms.Timer();
            timvcode.Tick += new EventHandler(timvcode_Tick);
            timvcode.Interval = 1000;
            timvcode.Start();
            this.lastName = lastName;
            this.firstName = firstName;
            this.userPassword = userPassword;
            this.mail = mail;
            this.confirmPassword = confirmPassword;
        }

        private void VerificationButton_Click(object sender, EventArgs e)
        {
            timvcode.Stop();

            string to, from, pass, mail;
            to = VerificationCode.Text;
            from = "g.brujbeanu18@gmail.com";
            pass = "imuv orhw vpck mgzm"; // Your app password goes here

            Random rnd = new Random();
            this.Vcode = rnd.Next(1000, 9999); // Generate the verification code here

            mail = Vcode.ToString();

            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress("BeautyBuzz <g.brujbeanu18@gmail.com>");
            message.Body = "Codul de verificare este: " + mail;
            message.Subject = "Mail-ul de verificare pentru confirmarea contului BeautyBuzz este:";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Verification code sent successful! Go to gmail and got it.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConfirmationCode.Enabled = true;
                ConfirmationButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfirmationButton_Click(object sender, EventArgs e)
        {
            int inputCode;
            if (int.TryParse(ConfirmCode.Text, out inputCode))
            {
                if (inputCode == this.Vcode)
                {
                    MessageBox.Show("Codul de verificare introdus este corect!", "Succes");

                    this.Close();

                    using (SqlConnection con = new SqlConnection($"Server={server};Database={dbName};Trusted_Connection=True;TrustServerCertificate=True;"))
                    {
                        string query = "INSERT INTO Tabel2 (LastName, FirstName, Password, Mail, ConfirmPassword) VALUES (@LastName, @FirstName, @Password, @Mail, @ConfirmPassword)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@Password", userPassword);
                        cmd.Parameters.AddWithValue("@Mail", mail);
                        cmd.Parameters.AddWithValue("@ConfirmPassword", confirmPassword);

                        try
                        {
                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Utilizatorul a fost înregistrat cu succes!");
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
                }
                else
                {
                    MessageBox.Show("Codul de verificare introdus este incorect!", "Eroare");
                }
            }
            else
            {
                MessageBox.Show("Introduceți un cod de verificare valid!", "Eroare");
            }
        }

        private void timvcode_Tick(object sender, EventArgs e)
        {
            Vcode += 10;
            if (Vcode == 9999)
            {
                Vcode = 1000;
            }
        }

        private void VerificationMail_Load(object sender, EventArgs e)
        {

        }
    }
}
