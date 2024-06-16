using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Net.Mail;

namespace BeautyBuzz
{
    public partial class DetaliiCont : UserControl
    {
        private string nume;
        private string prenume;
        private string email;
        private string emailAddress;
        private Microsoft.Data.SqlClient.SqlConnection conn;

        public DetaliiCont(string emailAddress)
        {
            InitializeComponent();

            conn = SingleTon.Instance.GetConnection();
            GetDetailsFromDatabase(emailAddress);
            this.emailAddress = emailAddress;
        }

        private void GetDetailsFromDatabase(string emailAddress)
        {
            string query = "SELECT LastName, FirstName FROM Tabel2 WHERE Mail = @Mail";

            try
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Mail", emailAddress);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nume = reader["LastName"].ToString();
                            prenume = reader["FirstName"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Nu s-au găsit date pentru adresa de email: " + emailAddress);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la conectare la baza de date: " + ex.Message);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            label5.Text = nume;
            label6.Text = prenume;
            label7.Text = emailAddress;
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if (!string.IsNullOrEmpty(emailAddress))
            {
                UserControlCont detalii_Cont = new UserControlCont(emailAddress);
                this.Parent.Controls.Add(detalii_Cont);
                detalii_Cont.Show();
            }
            else
            {
                MessageBox.Show("Email address is not available.");
            }
        }
    }
}