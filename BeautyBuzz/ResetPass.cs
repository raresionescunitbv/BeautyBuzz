using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Azure.Identity;
using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;

namespace BeautyBuzz
{
    public partial class ResetPass : Form
    {
        private string username;
        private SingleTon singleTon = SingleTon.Instance;

        public ResetPass(string username)
        {
            InitializeComponent();
            this.username = username;
<<<<<<< HEAD

            textBoxNewPass.UseSystemPasswordChar = true;
            textBoxConfirmNewPass.UseSystemPasswordChar = true;
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        }

        private void submitNewPass_Click(object sender, EventArgs e)
        {
            string newPass = textBoxConfirmNewPass.Text;

            if (textBoxNewPass.Text == newPass)
            {
                try
<<<<<<< HEAD

=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
                {
                    // Folosește clasa SingleTon pentru a obține conexiunea la baza de date
                    using (SqlConnection conn = singleTon.GetConnection())
                    {
                        conn.Open();
                        string updateQuery = "UPDATE [dbo].[Tabel2] SET [Password] = @NewPassword WHERE [Mail] = @Username";
                        SqlCommand cmd = new SqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@NewPassword", newPass);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Parola a fost resetată cu succes!");

                    // Redirecționați utilizatorul către formularul de autentificare
<<<<<<< HEAD
               
=======
                    BeautyBuzz loginForm = new BeautyBuzz();
                    loginForm.Show();
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
                    this.Hide();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Eroare la resetarea parolei: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Parolele nu se potrivesc. Introduceți aceeași parolă în ambele câmpuri.");
            }
        }

        private void ResetPass_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD
        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNewPass.UseSystemPasswordChar = !guna2CheckBox1.Checked;
            textBoxConfirmNewPass.UseSystemPasswordChar = !guna2CheckBox1.Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SendPass back = new SendPass(username, textBoxNewPass.Text);
            back.Show();
            this.Hide();

        }

        public void guna2CheckBox1_CheckedChanged(object value1, object value2)
        {
            throw new NotImplementedException();
        }
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
    }
}