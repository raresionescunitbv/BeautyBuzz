using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace BeautyBuzz
{
    public partial class Feedback : UserControl
    {
        private string emailAddress;
        private SqlConnection connection;

        public Feedback(string emailAddress)
        {
            InitializeComponent();
            this.emailAddress = emailAddress;
            InitializeConnection();
            textBox1.TextAlign = HorizontalAlignment.Left;
            textBox1.Multiline = true;
            textBox1.KeyDown += textBox1_KeyDown;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox1.AppendText(Environment.NewLine);
            }
        }

        private void InitializeConnection()
        {
            connection = SingleTon.Instance.GetConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string titlu = comboBox1.SelectedItem?.ToString();
                string detalii = textBox1.Text;


                if (string.IsNullOrEmpty(titlu) || string.IsNullOrEmpty(detalii))
                {
                    MessageBox.Show("Te rog completează toate câmpurile.");
                    return;
                }

                string query = "INSERT INTO Recenzii (Titlul, Detalii, Mail) VALUES (@Titlul, @Detalii, @Mail)";
                InsertIntoDatabase(query, titlu, detalii);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
        }

        private void InsertIntoDatabase(string query, string titlu, string detalii)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Titlul", titlu);
                    command.Parameters.AddWithValue("@Detalii", detalii);
                    command.Parameters.AddWithValue("@Mail", emailAddress);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Multumim pentru feedback.");
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

        private void button2_Click(object sender, EventArgs e)
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

        private void Feedback_Load(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }
    }
}
