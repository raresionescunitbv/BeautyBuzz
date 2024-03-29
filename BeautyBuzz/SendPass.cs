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
using BeautyBuzz;

namespace BeautyBuzz
{
    public partial class SendPass : Form
    {
       

        protected string username;
        private string password;



       


        private System.Windows.Forms.Timer timvcode;
        public int Vcode { get; private set; }
        public SendPass(string username, string password)
        {
            InitializeComponent();
            timvcode = new System.Windows.Forms.Timer();
            timvcode.Tick += new EventHandler(timvcode_Tick);
            timvcode.Interval = 1000;
            timvcode.Start();
            this.username = username;
            this.password = password;
            
        }


        private void button1SendForgetPass_Click(object sender, EventArgs e)
        {
            
            timvcode.Stop();

            string to, from, pass, mail;
            to = textResetPass.Text;
            from = "g.brujbeanu18@gmail.com";
            pass = "imuv orhw vpck mgzm"; // Your app password goes here

            Random rnd = new Random();
            this.Vcode = rnd.Next(1000, 9999); // Generate the verification code here

            mail = Vcode.ToString();

            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress("BeautyBuzz <g.brujbeanu18@gmail.com>");
            message.Body = "Codul pentru resetarea parolei: " + mail;
            message.Subject = "Codul de resetare a parolei aferente contului BeautyBuzz este:";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Verification code sent successful! Go to gmail and got it.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                codprimitForgetPass.Enabled = true;
                codeForgetPass.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void codeForgetPass_Click(object sender, EventArgs e)
        {
            int inputCode;
            if (int.TryParse(textBoxCodResetPass.Text, out inputCode))
            {
                if (inputCode == this.Vcode)
                {
                    username = textResetPass.Text;
                    ResetPass resetPass = new ResetPass(username);
                    this.Hide();
                    resetPass.Show();
                }
               

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
            
        }
    }
    
