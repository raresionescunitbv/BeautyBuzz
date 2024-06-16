<<<<<<< HEAD
﻿
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Asigurați-vă că folosiți Microsoft.Data.SqlClient
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

=======
﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
namespace BeautyBuzz
{
    public partial class UserControlAcasa : UserControl
    {
<<<<<<< HEAD
        private string emailAddress;
        private string nume_salon;
        private string nume_angajat;
        private DataTable dataTable; // Sursa de date pentru DataGridView

        public string TableName { get; set; }
        public string SelectedCity { get; set; }

        public UserControlAcasa(string emailAddress, string nume_salon, string nume_angajat, string tableName, string selectedCity)
=======
        // public string UserEmail { get; set; } // Proprietate pentru a stoca adresa de e-mail
        private string emailAddress;
        private string nume_salon;
        private string nume_angajat;
        public UserControlAcasa(string emailAddress, string nume_salon, string nume_angajat)
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        {
            InitializeComponent();
            this.Load += UserControlAcasa_Load;
            comboBoxOrase.SelectedIndexChanged += comboBoxOrase_SelectedIndexChanged;
            dataGridView1.CellClick += dataGridView1_CellClick;
            this.emailAddress = emailAddress;
            this.nume_salon = nume_salon;
            this.nume_angajat = nume_angajat;
<<<<<<< HEAD
            TableName = tableName; // Setarea numelui tabelului
            SelectedCity = selectedCity;
            comboBoxOrase.SelectedIndexChanged += comboBoxOrase_SelectedIndexChanged;
            PopulateComboBoxOrase();
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        }

        private void UserControlAcasa_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            comboBoxOrase.Items.AddRange(new object[] { "Alba Iulia", "Alexandria", "Arad", "Arges", "Azuga", "Baicoi", "Bacau", "Baia Mare", "Bistrita", "Botosani", "Braila", "Brasov", "Bucuresti", "Buzau", "Budeasa", "Calarasi", "Cluj-Napoca", "Constanta", "Craiova", "Curtea de Arges", "Deva", "Drobeta -Turnu Severin", "Fagaras", "Focsani", "Galati", "Giurgiu", "Hunedoara", "Iasi", "Lugoj", "Miercurea Ciuc", "Medgidia", "Medias", "Oradea", "Piatra Neamt", "Pitesti", "Ploiesti", "Ramnicu Valcea", "Resita", "Satu Mare", "Sfantu Gheorghe", "Sibiu", "Slatina", "Sighisoara", "Slobozia", "Suceava", "Targoviste", "Targu Jiu", "Targu Mures", "Timisoara", "Tulcea", "Tecuci", "Vaslui", "Valenii de Munte", "Zalau", "Zarnesti" });
            pictureBox1.BackColor = Color.Transparent;
            if (SelectedCity == null)
            {
                if (comboBoxOrase.Items.Count > 0)
                {
                    Random random = new Random();
                    int randomIndex = random.Next(comboBoxOrase.Items.Count);
                    comboBoxOrase.SelectedIndex = randomIndex;
                }
                else
                {
                    MessageBox.Show("Nu există orașe disponibile în listă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                comboBoxOrase.SelectedItem = SelectedCity;
            }

            InitializeDataGridView();
        }

        private void InitializeDataGridView()
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

        public void PopulateComboBoxOrase()
        {
            try
            {
                comboBoxOrase.Items.Clear();
                string selectedCity = SelectedCity; // Obținem orașul selectat
                if (string.IsNullOrEmpty(selectedCity))
                {
                    return; // Nu facem nimic dacă orașul nu este selectat
                }

                string query = $"SELECT DISTINCT Oras FROM {TableName} WHERE Oras = @Oras";

                SqlConnection connection = SingleTon.Instance.GetConnection();
                SingleTon.Instance.OpenConnection(); // Asigurăm deschiderea conexiunii

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Oras", selectedCity);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string oras = reader["Oras"].ToString();
                            comboBoxOrase.Items.Add(oras);
                        }
                    }
                }

                if (comboBoxOrase.Items.Count > 0)
                {
                    comboBoxOrase.SelectedIndex = 0; // Selectăm primul oraș din listă
=======
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
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea datelor din baza de date: " + ex.Message);
<<<<<<< HEAD
                // Adăugăm logare pentru a diagnostica problema
                Console.WriteLine($"Eroare PopulateComboBoxOrase: {ex}");
            }
            finally
            {
                SingleTon.Instance.CloseConnection(); // Asigurăm închiderea conexiunii
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
            }
        }

        private void comboBoxOrase_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = comboBoxOrase.SelectedItem.ToString();
<<<<<<< HEAD
            string query = $"SELECT DISTINCT Nume_Salon, Nume_Angajat FROM {TableName} WHERE Oras = @Oras";

            try
            {
                dataTable = new DataTable();
                SqlConnection connection = SingleTon.Instance.GetConnection();
                SingleTon.Instance.OpenConnection(); // Asigurăm deschiderea conexiunii

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Oras", selectedCity);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
=======

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
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
                    }
                }

                dataGridView1.DataSource = dataTable;
<<<<<<< HEAD

                int totalRowHeight = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
                int desiredHeight = totalRowHeight + dataGridView1.ColumnHeadersHeight + 2;
                int maxHeight = 300;
                dataGridView1.Height = Math.Min(desiredHeight, maxHeight);
                dataGridView1.ScrollBars = (dataGridView1.Height < desiredHeight) ? ScrollBars.Vertical : ScrollBars.None;
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea datelor din baza de date: " + ex.Message);
<<<<<<< HEAD
                // Adăugăm logare pentru a diagnostica problema
                Console.WriteLine($"Eroare comboBoxOrase_SelectedIndexChanged: {ex}");
            }
            finally
            {
                SingleTon.Instance.CloseConnection(); // Asigurăm închiderea conexiunii
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
<<<<<<< HEAD
            if (e.RowIndex >= 0 && dataTable != null && dataTable.Rows.Count > e.RowIndex)
            {
                string selectedSalon = dataTable.Rows[e.RowIndex]["Nume_Salon"].ToString();
                string selectedEmployee = dataTable.Rows[e.RowIndex]["Nume_Angajat"].ToString();
                ShowAppointmentCalendar(selectedSalon, selectedEmployee, emailAddress, nume_salon, nume_angajat);
            }
        }

        private void ShowAppointmentCalendar(string salon, string angajat, string emailAddress, string nume_salon, string nume_angajat)
        {
            using (UserControlCalendar calendarForm = new UserControlCalendar(emailAddress, TableName))
            {
                calendarForm.emailAddress = this.emailAddress;
                calendarForm.nume_salon = salon;
=======
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
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
                calendarForm.nume_angajat = angajat;
                calendarForm.ShowDialog();
            }
        }
<<<<<<< HEAD

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserControlAll backToAll = new UserControlAll(emailAddress, nume_salon, nume_angajat);
            this.Parent.Controls.Add(backToAll);
            this.Parent.Controls.Remove(this);
        }
    }
}
=======
    }
}
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
