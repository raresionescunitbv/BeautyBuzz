using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BeautyBuzz
{
    public partial class Cosul_meu : Form
    {
        private string emailAddress;
        DataTable dataTable = new DataTable();

        public Cosul_meu(string emailAddress)
        {
            InitializeComponent();
            this.emailAddress = emailAddress;
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            var connection = SingleTon.Instance.GetConnection();
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            connection.Open();

            try
            {
                using (var command = new SqlCommand("SELECT Nume, Pret FROM Cosulmeu2 WHERE Mail = @Mail", connection))
                {
                    command.Parameters.AddWithValue("@Mail", emailAddress);

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }

                    decimal total = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        decimal pret;
                        if (decimal.TryParse(row["Pret"].ToString().Replace(" lei", ""), out pret))
                        {
                            total += pret;
                        }
                    }

                    label2.Text = "Total: " + total.ToString("0.00 lei");
                    //Calcularea inaltimii si latimii datagrid
                    int rowHeight = 25; // inaltimea estimata a unui rand
                    int headerHeight = dataGridView1.ColumnHeadersHeight; //inaltime antet
                    int numRows = dataGridView1.Rows.Count; //nr randuri
                    int numColumns = dataGridView1.Columns.Count; //nr coloane
                    int height = headerHeight + (numRows * rowHeight); // calc inaltime totala
                    int width = 0;
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        width += col.Width; // calc latime totala
                    }

                    // setare dimens datagrid
                    dataGridView1.Height = height;
                    dataGridView1.Width = width;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la popularea datelor: " + ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connection = SingleTon.Instance.GetConnection();
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            connection.Open();

            try
            {
                string deleteQuery = "DELETE FROM Cosulmeu2 WHERE Mail = @Mail";
                using (var deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@Mail", emailAddress);

                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        decimal total = GetTotalFromLabel();
                        string products = GetProductsList();

                        MessageBox.Show("Comanda a fost plasata cu succes! Valoare: " + total.ToString("0.00 lei") + ". Produse: " + products);
                        SendConfirmationEmail2(emailAddress, total, products);
                        PopulateDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Nu s-au găsit produse in cos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la plasarea comenzii: " + ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private decimal GetTotalFromLabel()
        {
            string totalText = label2.Text.Replace("Total: ", "").Replace(" lei", "");
            decimal total;
            if (decimal.TryParse(totalText, out total))
            {
                return total;
            }
            return 0;
        }

        private string GetProductsList()
        {
            string products = "";
            foreach (DataRow row in dataTable.Rows)
            {
                string productName = row["Nume"].ToString();
                products += productName + ", ";
            }
            if (!string.IsNullOrEmpty(products))
            {
                products = products.Remove(products.Length - 2);
            }
            return products;
        }
        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = dataTable;
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

        }

        private void SendConfirmationEmail2(string emailAddress, decimal total, string products)
        {
            try
            {
                string fromAddress = ConfigurationManager.AppSettings["GmailAddress"];
                string password = ConfigurationManager.AppSettings["GmailPassword"];

                MailMessage message = new MailMessage();
                message.To.Add(emailAddress);
                message.From = new MailAddress(fromAddress, "BeautyBuzz");

                // Construim corpul email-ului folosind HTML
                string htmlBody = "<h2>Comanda dvs. a fost plasata cu succes</h2>";
                htmlBody += "<p>Cost total: " + total.ToString("0.00 lei") + "</p>";
                htmlBody += "<table border='1'><tr><th>Produs</th></tr>";
                // Separăm produsele și le adăugăm în tabel
                string[] productList = products.Split(',');
                foreach (string product in productList)
                {
                    htmlBody += "<tr><td>" + product.Trim() + "</td></tr>";
                }
                htmlBody += "</table>";
                message.Body = htmlBody;

                message.Subject = "Confirmare comanda BeautyBuzz";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nu ați selectat niciun produs pentru ștergere.");
                return;
            }

            var connection = SingleTon.Instance.GetConnection();
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            connection.Open();

            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string numeProdus = row.Cells["Nume"].Value.ToString();

                    string deleteQuery = "DELETE FROM Cosulmeu2 WHERE Mail = @Mail AND Nume = @Nume";
                    using (var deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@Mail", emailAddress);
                        deleteCommand.Parameters.AddWithValue("@Nume", numeProdus);

                        deleteCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Produsele selectate au fost șterse cu succes!");
                PopulateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la ștergerea produselor: " + ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private void Cosul_meu_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }
    }
}