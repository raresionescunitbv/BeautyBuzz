using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Azure.Identity;
using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;

namespace BeautyBuzz
{
    public partial class ResetPass : Form
    {
        private string username;
        private string server = "DESKTOP-NRU19T4\\SQLEXPRESS";
        private string dbName = "master";

        public ResetPass(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void submitNewPass_Click(object sender, EventArgs e)
        {
            string newPass = textBoxConfirmNewPass.Text;

            if (textBoxNewPass.Text == newPass)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection($"Server={server};Database={dbName};Trusted_Connection=True;TrustServerCertificate=True;"))
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
                    BeautyBuzz loginForm = new BeautyBuzz();
                    loginForm.Show();
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
    }
}