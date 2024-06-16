using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BeautyBuzz
{
    public partial class UserControlProgramari : UserControl
    {
        private string emailAddress;
        public UserControlProgramari(string emailAddress)
        {
            InitializeComponent();
            this.emailAddress = emailAddress;
            //buttonAnuleaza.Click += ButtonAnuleaza_Click;

        }

        private void UserControlProgramari_Load_1(object sender, EventArgs e)
        {
            DisplayAppointments();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            // Setarea culorii de fundal
            dataGridView1.BackgroundColor = Color.DodgerBlue;

            // Setarea culorii textului și fontului
            dataGridView1.ForeColor = Color.White;
            dataGridView1.Font = new Font("Century Gothic", 10, FontStyle.Bold);

            // Stilizarea antetelor de coloană
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);

            // Stilizarea celulelor
            dataGridView1.DefaultCellStyle.BackColor = Color.DodgerBlue;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            // Ajustarea dimensiunilor coloanelor pentru a umple întreaga lățime
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridView1.AllowUserToAddRows = false; // Interzice utilizatorilor să adauge rânduri
            dataGridView1.AllowUserToDeleteRows = false; // Interzice utilizatorilor să șteargă rânduri
            dataGridView1.ReadOnly = true; // Fă DataGridView doar pentru citire
                                           // Calculează înălțimea totală a rândurilor
            int totalRowHeight = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

            // Setează înălțimea DataGridView
            int desiredHeight = totalRowHeight + dataGridView1.ColumnHeadersHeight + 2; // Adaugă și înălțimea antetelor coloanelor și un mic spațiu suplimentar
            int maxHeight = 300; // Setează înălțimea maximă dorită
            dataGridView1.Height = Math.Min(desiredHeight, maxHeight); // Alege înălțimea minimă dintre înălțimea dorită și înălțimea maximă

            // Activează scrollbar-ul vertical dacă este necesar
            dataGridView1.ScrollBars = (dataGridView1.Height < desiredHeight) ? ScrollBars.Vertical : ScrollBars.None;


        }
        private void DisplayAppointments()
        {
            var connection = SingleTon.Instance.GetConnection();
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            connection.Open();

            try
            {
                using (var command = new SqlCommand("SELECT Nume_Salon, Nume_Angajat, Data, Ora FROM Programari WHERE Mail = @Mail", connection))
                {
                    command.Parameters.AddWithValue("@Mail", emailAddress);

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la afișarea programărilor: " + ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private void ButtonAnuleaza_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string numeSalon = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string numeAngajat = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DateTime data = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value);
                string ora = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                var connection = SingleTon.Instance.GetConnection();
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
                connection.Open();

                try
                {
                    string deleteQuery = "DELETE FROM Programari WHERE Nume_Salon = @NumeSalon AND Nume_Angajat = @NumeAngajat AND Data = @Data AND Ora = @Ora AND Mail = @Mail";
                    using (var deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@NumeSalon", numeSalon);
                        deleteCommand.Parameters.AddWithValue("@NumeAngajat", numeAngajat);
                        deleteCommand.Parameters.AddWithValue("@Data", data);
                        deleteCommand.Parameters.AddWithValue("@Ora", ora);
                        deleteCommand.Parameters.AddWithValue("@Mail", emailAddress);

                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Programarea a fost anulată cu succes!");
                            DisplayAppointments();
                        }
                        else
                        {
                            MessageBox.Show("Nu s-a putut anula programarea.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la anularea programării: " + ex.Message);
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați o programare pe care doriți să o anulați.");
            }
        }


    }
}