using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BeautyBuzz
{
    public partial class AngajatiEpilareAdmin : UserControl
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public AngajatiEpilareAdmin()
        {
            InitializeComponent();
            InitializeDataGridView();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void InitializeDataGridView()
        {
            connection = SingleTon.Instance.GetConnection();
            string query = "SELECT Id, Nume_Salon, Nume_Angajat, Prenume_Angajat, Nr_Telefon, Oras FROM ANGAJATIEpilare";
            dataAdapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();

            try
            {
                connection.Open();
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea datelor: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            dataGridView1.DataSource = dataTable;
            CustomizeDataGridView();
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
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["Id"].Value.ToString();
                textBox2.Text = row.Cells["Nume_Salon"].Value.ToString();
                textBox3.Text = row.Cells["Nume_Angajat"].Value.ToString();
                textBox4.Text = row.Cells["Prenume_Angajat"].Value.ToString();
                textBox5.Text = row.Cells["Nr_Telefon"].Value.ToString();
                textBox6.Text = row.Cells["Oras"].Value.ToString();
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
                    string id = textBox1.Text;
                    string nume_salon = textBox2.Text;
                    string nume_angajat = textBox3.Text;
                    string prenume_angajat = textBox4.Text;
                    string nr_telefon = textBox5.Text;
                    string oras = textBox6.Text;

                    SqlCommand updateCmd = new SqlCommand("UPDATE ANGAJATIEpilare SET nume_salon = @nume_salon, nume_angajat = @nume_angajat, prenume_angajat = @prenume_angajat, nr_telefon = @nr_telefon, oras = @oras WHERE id = @id", connection);
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
                        dataGridView1.SelectedRows[0].Cells["Nume_Salon"].Value = nume_salon;
                        dataGridView1.SelectedRows[0].Cells["Nume_Angajat"].Value = nume_angajat;
                        dataGridView1.SelectedRows[0].Cells["Prenume_Angajat"].Value = prenume_angajat;
                        dataGridView1.SelectedRows[0].Cells["Nr_Telefon"].Value = nr_telefon;
                        dataGridView1.SelectedRows[0].Cells["Oras"].Value = oras;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                try
                {
                    connection = SingleTon.Instance.GetConnection();
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    SqlCommand command = new SqlCommand("DELETE FROM ANGAJATIEpilare WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        MessageBox.Show("Ștergere reușită din baza de date!");
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
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void AngajatiEpilareAdmin_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }
    }
}
