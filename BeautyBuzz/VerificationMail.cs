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
using System.Configuration;
using System.Xml.Linq;

namespace BeautyBuzz
{
    public partial class VerificationMail : Form
    {
        private SingleTon singleTon = SingleTon.Instance;
        private string firstName;
        private string lastName;
        private string userPassword;
        private string mail;
        private string confirmPassword;

        private System.Windows.Forms.Timer timvcode;
        private int Vcode { get; set; }

        public VerificationMail(string firstName, string lastName, string userPassword, string mail, string confirmPassword)
        {
            InitializeComponent();

            timvcode = new System.Windows.Forms.Timer();
            timvcode.Tick += new EventHandler(timvcode_Tick);
            timvcode.Interval = 1000;
            timvcode.Start();

            this.lastName = lastName;
            this.firstName = firstName;
            this.userPassword = userPassword;
            this.mail = mail;
            this.confirmPassword = confirmPassword;

            VerificationCode.Text = mail;
        }

        private void VerificationButton_Click(object sender, EventArgs e)
        {
            timvcode.Stop();

            string to, mail;
            to = VerificationCode.Text;
            string fromAddress = ConfigurationManager.AppSettings["GmailAddress"];
            string password = ConfigurationManager.AppSettings["GmailPassword"];

            Random rnd = new Random();
            this.Vcode = rnd.Next(1000, 9999); // Generate the verification code here

            mail = Vcode.ToString();

            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(fromAddress, "BeautyBuzz");
            message.Body = "Codul de verificare este: " + mail;
            message.Subject = "Mail-ul de verificare pentru confirmarea contului BeautyBuzz este:";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromAddress, password);
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
                    if (IsEmailExists(mail))
                    {
                        MessageBox.Show("Această adresă de e-mail există deja în sistem!", "Eroare");
                        BeautyBuzz beautyBuzzz = new BeautyBuzz();
                        beautyBuzzz.Show();
                        this.Hide();
                        return; // Iesiti din functie pentru a evita inregistrarea duplicatelor


                    }


                    using (SqlConnection con = new SqlConnection(singleTon.GetConnection().ConnectionString))
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
                    this.Hide();
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
        private bool IsEmailExists(string email)
        {
            using (SqlConnection con = new SqlConnection(singleTon.GetConnection().ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM Tabel2 WHERE Mail = @Mail";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Mail", email);

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
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
            pictureBox1.BackColor = Color.Transparent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Hide();
        }
    }
}