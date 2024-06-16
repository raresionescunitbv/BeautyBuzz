﻿using System;
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
using System.Configuration;

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
<<<<<<< HEAD
            textResetPass.Text = username;
=======

>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        }


        private void button1SendForgetPass_Click(object sender, EventArgs e)
        {

            timvcode.Stop();

            string to, mail;
            to = textResetPass.Text;
            string fromAddress = ConfigurationManager.AppSettings["GmailAddress"];
            string pass = ConfigurationManager.AppSettings["GmailPassword"];

            Random rnd = new Random();
<<<<<<< HEAD
            this.Vcode = rnd.Next(1000, 9999); 
=======
            this.Vcode = rnd.Next(1000, 9999); // Generate the verification code here
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f

            mail = Vcode.ToString();

            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(fromAddress, "BeautyBuzz");
            message.Body = "Codul pentru resetarea parolei: " + mail;
            message.Subject = "Codul de resetare a parolei aferente contului BeautyBuzz este:";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromAddress, pass);
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
<<<<<<< HEAD
                    resetPass.TopMost = true;

=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
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
        private void SendPass_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
            this.Hide();
        }
=======

        }

>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
    }

}

