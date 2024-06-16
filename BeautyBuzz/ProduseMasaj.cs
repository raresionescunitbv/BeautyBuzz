﻿using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace BeautyBuzz
{
    public partial class ProduseMasaj : UserControl
    {
        private string emailAddress;
        private SqlConnection connection;

        public ProduseMasaj(string emailAddress)
        {
            InitializeComponent();
            this.emailAddress = emailAddress;
            InitializeConnection();
        }

        private void InitializeConnection()
        {
            connection = SingleTon.Instance.GetConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!string.IsNullOrEmpty(emailAddress))
            {
                ProdProf produseProfesionale = new ProdProf(emailAddress);
                this.Parent.Controls.Add(produseProfesionale);
                produseProfesionale.Show();
            }
            else
            {
                MessageBox.Show("Email address is not available.");
            }
        }

        private void InsertIntoDatabase(string query, string numeLabel, string pretLabel)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nume", numeLabel);
                    command.Parameters.AddWithValue("@Pret", pretLabel);
                    command.Parameters.AddWithValue("@Mail", emailAddress);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Produs adăugat în coș.");
                    }
                    else
                    {
                        MessageBox.Show("Nu s-au putut insera datele în baza de date.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Cosulmeu2 (Nume, Pret, Mail) VALUES (@Nume, @Pret, @Mail)";
            InsertIntoDatabase(query, label2.Text, label4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Cosulmeu2 (Nume, Pret, Mail) VALUES (@Nume, @Pret, @Mail)";
            InsertIntoDatabase(query, label7.Text, label5.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Cosulmeu2 (Nume, Pret, Mail) VALUES (@Nume, @Pret, @Mail)";
            InsertIntoDatabase(query, label11.Text, label9.Text);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!string.IsNullOrEmpty(emailAddress))
            {
                ProdProf produseProfesionale = new ProdProf(emailAddress);
                this.Parent.Controls.Add(produseProfesionale);
                produseProfesionale.Show();
            }
            else
            {
                MessageBox.Show("Email address is not available.");
            }
        }
    }
}
