using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BeautyBuzz
{
    public partial class AdminTabel : UserControl
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public AdminTabel()
        {
            InitializeComponent();
            InitializeDataGridView();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void InitializeDataGridView()
        {
            try
            {
                connection = SingleTon.Instance.GetConnection();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                string query = "SELECT LastName, FirstName, Password, Mail, ConfirmPassword FROM Tabel2";
                dataAdapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();

                connection.Open();
                dataAdapter.Fill(dataTable);
                connection.Close();

                dataGridView1.DataSource = dataTable;

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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["LastName"].Value.ToString();
                textBox2.Text = row.Cells["FirstName"].Value.ToString();
                textBox3.Text = row.Cells["Password"].Value.ToString();
                textBox4.Text = row.Cells["Mail"].Value.ToString();
                textBox5.Text = row.Cells["ConfirmPassword"].Value.ToString();
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

                    string lastName = textBox1.Text;
                    string firstName = textBox2.Text;
                    string password = textBox3.Text;
                    string mail = textBox4.Text;
                    string confirmPassword = textBox5.Text;

                    SqlCommand updateCmd = new SqlCommand("UPDATE Tabel2 SET LastName = @lastName, FirstName = @firstName, Password = @password, Mail = @mail, ConfirmPassword = @confirmPassword WHERE LastName = @oldLastName AND FirstName = @oldFirstName", connection);
                    updateCmd.Parameters.AddWithValue("@lastName", lastName);
                    updateCmd.Parameters.AddWithValue("@firstName", firstName);
                    updateCmd.Parameters.AddWithValue("@password", password);
                    updateCmd.Parameters.AddWithValue("@mail", mail);
                    updateCmd.Parameters.AddWithValue("@confirmPassword", confirmPassword);

                    updateCmd.Parameters.AddWithValue("@oldLastName", dataGridView1.SelectedRows[0].Cells["LastName"].Value.ToString());
                    updateCmd.Parameters.AddWithValue("@oldFirstName", dataGridView1.SelectedRows[0].Cells["FirstName"].Value.ToString());

                    connection.Open();
                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Modificare reușită!");
                        InitializeDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Nu s-a putut efectua modificarea.");
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
                MessageBox.Show("Selectați un rând din DataGridView pentru modificare.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

                    string lastName = dataGridView1.SelectedRows[0].Cells["LastName"].Value.ToString();
                    string firstName = dataGridView1.SelectedRows[0].Cells["FirstName"].Value.ToString();

                    string query = "DELETE FROM Tabel2 WHERE LastName = @lastName AND FirstName = @firstName";

                    SqlCommand deleteCmd = new SqlCommand(query, connection);
                    deleteCmd.Parameters.AddWithValue("@lastName", lastName);
                    deleteCmd.Parameters.AddWithValue("@firstName", firstName);

                    connection.Open();
                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ștergere reușită!");
                        InitializeDataGridView();
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
            }
            else
            {
                MessageBox.Show("Selectați un rând din DataGridView pentru ștergere.");
            }
            ClearTextBoxes();
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
            textBox4.Clear();
            textBox5.Clear();
        }

        private void AdminTabel_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }
    }
}
