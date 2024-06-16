using System;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace BeautyBuzz
{
    public partial class Programari : UserControl
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private string emailAddress;

        public Programari()
        {
            InitializeComponent();
            InitializeDataGridView();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        private void InitializeDataGridView()
        {
            try
            {
                connection = SingleTon.Instance.GetConnection();
                string query = "SELECT Mail, Nume_Salon, Nume_Angajat, Data, Ora FROM Programari";
                dataAdapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();

                connection.Open();
                dataAdapter.Fill(dataTable);
                connection.Close();

                dataGridView1.DataSource = dataTable;
                CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea datelor: " + ex.Message);
            }
        }

        private void CustomizeDataGridView()
        {
            dataGridView1.BackgroundColor = Color.DodgerBlue;
            dataGridView1.ForeColor = Color.White;
            dataGridView1.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.BackColor = Color.DodgerBlue;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            // Calculate and set the height and width of the DataGridView
            int rowHeight = 25; // Estimated height of a row
            int headerHeight = dataGridView1.ColumnHeadersHeight; // Height of the header
            int numRows = dataGridView1.Rows.Count; // Number of rows
            int numColumns = dataGridView1.Columns.Count; // Number of columns
            int height = headerHeight + (numRows * rowHeight); // Calculate total height
            int width = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                width += col.Width; // Calculate total width
            }

            // Set DataGridView dimensions
            dataGridView1.Height = height;
            dataGridView1.Width = width;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["Mail"].Value.ToString();
                textBox2.Text = row.Cells["Nume_Salon"].Value.ToString();
                textBox3.Text = row.Cells["Nume_Angajat"].Value.ToString();
                textBox5.Text = row.Cells["Ora"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    connection = SingleTon.Instance.GetConnection();
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }

                    string Mail = textBox1.Text;
                    string Nume_Salon = textBox2.Text;
                    string Nume_Angajat = textBox3.Text;
                    string Ora = textBox5.Text;

                    SqlCommand updateCmd = new SqlCommand("UPDATE Programari SET Nume_Salon = @Nume_Salon, Nume_Angajat = @Nume_Angajat, Ora = @Ora WHERE Mail = @Mail", connection);
                    updateCmd.Parameters.AddWithValue("@Nume_Salon", Nume_Salon);
                    updateCmd.Parameters.AddWithValue("@Nume_Angajat", Nume_Angajat);
                    updateCmd.Parameters.AddWithValue("@Ora", Ora);
                    updateCmd.Parameters.AddWithValue("@Mail", Mail); // Adăugați parametrul Mail

                    connection.Open();
                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Modificare reușită!");

                        // Actualizați rândul DataGridView cu noile valori
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                        selectedRow.Cells["Nume_Salon"].Value = Nume_Salon;
                        selectedRow.Cells["Nume_Angajat"].Value = Nume_Angajat;
                        selectedRow.Cells["Ora"].Value = Ora;
                    }
                    else
                    {
                        MessageBox.Show("Selectați un rând din baza de date.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Selectați un rând pentru modificare.");
            }
        }

        private void SendConfirmationEmail(string emailAddress)
        {
            try
            {
                string fromAddress = ConfigurationManager.AppSettings["GmailAddress"];
                string password = ConfigurationManager.AppSettings["GmailPassword"];

                MailMessage message = new MailMessage();
                message.To.Add(emailAddress);
                message.From = new MailAddress(fromAddress, "BeautyBuzz");

                // Construct the email body using HTML
                string htmlBody = "<h2>Programarea dvs. a fost anulată cu succes!</h2>";
                htmlBody += "<p>Vă mulțumim pentru înțelegere.</p>";

                message.Body = htmlBody;
                message.Subject = "Anulare Programare BeautyBuzz";
                message.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(fromAddress, password);

                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la trimiterea email-ului: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string Mail = dataGridView1.SelectedRows[0].Cells["Mail"].Value.ToString();
                string query = "DELETE FROM Programari WHERE Mail = @Mail";

                try
                {
                    connection = SingleTon.Instance.GetConnection();
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    SqlCommand deleteCmd = new SqlCommand(query, connection);
                    deleteCmd.Parameters.AddWithValue("@Mail", Mail);

                    connection.Open();
                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Remove the row from DataGridView
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        MessageBox.Show("Ștergere reușită din baza de date!");

                        // Send confirmation email to the client
                        emailAddress = Mail;
                        SendConfirmationEmail(emailAddress);
                    }
                    else
                    {
                        MessageBox.Show("Nu s-a putut efectua ștergerea.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la ștergerea din baza de date: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Selectați un rând din DataGridView pentru a șterge.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminMain adminMainControl = new AdminMain();
            this.Controls.Add(adminMainControl);
            adminMainControl.Dock = DockStyle.Fill;
            adminMainControl.BringToFront();
        }

        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
        }

        private void Programari_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }
    }
}
