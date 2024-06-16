using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BeautyBuzz
{
    public partial class AngajatiAdmin : UserControl
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public AngajatiAdmin()
        {
            InitializeComponent();
            InitializeDataGridView();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void InitializeDataGridView()
        {
            try
            {
                connection = SingleTon.Instance.GetConnection(); // Using Singleton pattern to get a database connection
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Ensure connection is closed before proceeding
                }

                string query = "SELECT * FROM ANGAJATI";
                dataAdapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();

                connection.Open();
                dataAdapter.Fill(dataTable);
                connection.Close();

                dataGridView1.DataSource = dataTable; // Set DataGridView's data source to the filled DataTable

                // Customize DataGridView appearance
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
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la initializare: " + ex.Message);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click event to populate text boxes with selected row data
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["id"].Value.ToString();
                textBox2.Text = row.Cells["nume_salon"].Value.ToString();
                textBox3.Text = row.Cells["nume_angajat"].Value.ToString();
                textBox4.Text = row.Cells["prenume_angajat"].Value.ToString();
                textBox5.Text = row.Cells["nr_telefon"].Value.ToString();
                textBox6.Text = row.Cells["oras"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Update button click event to update selected row in the database
            try
            {
                connection = SingleTon.Instance.GetConnection();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                string id = textBox1.Text;
                string nume_salon = textBox2.Text;
                string nume_angajat = textBox3.Text;
                string prenume_angajat = textBox4.Text;
                string nr_telefon = textBox5.Text;
                string oras = textBox6.Text;

                SqlCommand updateCmd = new SqlCommand("UPDATE ANGAJATI SET nume_salon = @nume_salon, nume_angajat = @nume_angajat, prenume_angajat = @prenume_angajat, nr_telefon = @nr_telefon, oras = @oras WHERE id = @id", connection);
                updateCmd.Parameters.AddWithValue("@id", id);
                updateCmd.Parameters.AddWithValue("@nume_salon", nume_salon);
                updateCmd.Parameters.AddWithValue("@nume_angajat", nume_angajat);
                updateCmd.Parameters.AddWithValue("@prenume_angajat", prenume_angajat);
                updateCmd.Parameters.AddWithValue("@nr_telefon", nr_telefon);
                updateCmd.Parameters.AddWithValue("@oras", oras);

                connection.Open();
                int rowsAffected = updateCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Modificare reușită!");
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
            InitializeDataGridView(); // Refresh DataGridView after update
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Delete button click event to delete selected row from the database
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                string query = "DELETE FROM ANGAJATI WHERE id = @id";

                try
                {
                    connection = SingleTon.Instance.GetConnection();
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    SqlCommand deleteCmd = new SqlCommand(query, connection);
                    deleteCmd.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ștergere reușită!");
                    }
                    else
                    {
                        MessageBox.Show("Nu s-a putut efectua ștergerea.");
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
                InitializeDataGridView(); // Refresh DataGridView after deletion
            }
            else
            {
                MessageBox.Show("Selectați un rând din DataGridView pentru a șterge.");
            }
            ClearTextBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Back button click event to return to AdminMain control
            AdminMain adminMainControl = new AdminMain();
            this.Controls.Add(adminMainControl);
            adminMainControl.Dock = DockStyle.Fill;
            adminMainControl.BringToFront();
        }

        private void ClearTextBoxes()
        {
            // Method to clear all text boxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This method can be removed if not used
        }
    }
}
