using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;

namespace BeautyBuzz
{
    public partial class Admin1Admin : UserControl
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public Admin1Admin()
        {
            InitializeComponent();
            InitializeDataGridView();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitializeDataGridView()
        {
            connection = SingleTon.Instance.GetConnection();
            string query = "SELECT * FROM Admin1";
            dataAdapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            connection.Open();
            dataAdapter.Fill(dataTable);
            connection.Close();
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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["Username"].Value.ToString();
                textBox2.Text = row.Cells["Parola"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection.ConnectionString))
            {
                string username = textBox1.Text;
                string parola = textBox2.Text;


                SqlCommand updateCmd = new SqlCommand("UPDATE Admin1 SET parola = @Parola WHERE username = @Username", connection);
                updateCmd.Parameters.AddWithValue("@id", username);
                updateCmd.Parameters.AddWithValue("@parola", parola);

                try
                {
                    connection.Open();
                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Modificare reușită!");
                    }
                    else
                    {
                        MessageBox.Show("Selectati un rand din baza de date.");
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
                textBox1.Clear();
                textBox2.Clear();
                InitializeDataGridView();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminMain adminMainControl = new AdminMain();
            this.Controls.Add(adminMainControl);
            adminMainControl.Dock = DockStyle.Fill;
            adminMainControl.BringToFront();
        }

        private void Admin1Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
