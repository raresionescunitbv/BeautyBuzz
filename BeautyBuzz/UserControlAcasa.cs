using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BeautyBuzz
{
    public partial class UserControlAcasa : UserControl
    {
        // public string UserEmail { get; set; } // Proprietate pentru a stoca adresa de e-mail
        private string emailAddress;
        private string nume_salon;
        private string nume_angajat;
        public UserControlAcasa(string emailAddress, string nume_salon, string nume_angajat)
        {
            InitializeComponent();
            this.Load += UserControlAcasa_Load;
            comboBoxOrase.SelectedIndexChanged += comboBoxOrase_SelectedIndexChanged;
            dataGridView1.CellClick += dataGridView1_CellClick;
            this.emailAddress = emailAddress;
            this.nume_salon = nume_salon;
            this.nume_angajat = nume_angajat;
        }

        private void UserControlAcasa_Load(object sender, EventArgs e)
        {
            // La încărcarea controlului, populăm ComboBox-ul cu orașele disponibile
            PopulateComboBoxOrase();
        }

        private void PopulateComboBoxOrase()
        {
            try
            {
                string query = "SELECT DISTINCT Oras FROM ANGAJATI";

                using (SqlConnection connection = new SqlConnection(SingleTon.Instance.GetConnection().ConnectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBoxOrase.Items.Add(reader["Oras"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea datelor din baza de date: " + ex.Message);
            }
        }

        private void comboBoxOrase_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = comboBoxOrase.SelectedItem.ToString();

            string query = "SELECT DISTINCT Nume_Salon, Nume_Angajat FROM ANGAJATI WHERE Oras = @Oras";

            try
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(SingleTon.Instance.GetConnection().ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Oras", selectedCity);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea datelor din baza de date: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string selectedSalon = row.Cells["Nume_Salon"].Value.ToString();
                string selectedEmployee = row.Cells["Nume_Angajat"].Value.ToString();
                DisplaySalonEmployees(selectedSalon);

                // La clic pe o celulă din dataGridView1, afișăm calendarul pentru programare
                ShowAppointmentCalendar(selectedSalon, selectedEmployee, emailAddress,nume_salon,nume_angajat);
            }
        }

        private void DisplaySalonEmployees(string salon)
        {
            string query = "SELECT Nume_Angajat, Prenume_Angajat FROM ANGAJATI WHERE Nume_Salon = @Nume_Salon";

            try
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(SingleTon.Instance.GetConnection().ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nume_Salon", salon);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea datelor din baza de date: " + ex.Message);
            }
        }

        private void ShowAppointmentCalendar(string salon, string angajat, string emailAddress, string nume_salon,string nume_angajat)
        {
            // Afișăm calendarul într-o fereastră modală pentru a permite utilizatorului să selecteze o dată
            using (UserControlCalendar calendarForm = new UserControlCalendar(emailAddress))
            {
                calendarForm.emailAddress = this.emailAddress; // Transmiterea adresei de e-mail către calendarForm
                calendarForm.nume_salon = salon; // Transmiterea numelui salonului către calendarForm
                calendarForm.nume_angajat = angajat;
                calendarForm.ShowDialog();
            }
        }
    }
}