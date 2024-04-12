using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace BeautyBuzz
{
    public partial class UserControlCalendar : Form
    {
        private SingleTon singleTon = SingleTon.Instance;

        // public string Textbox1Value { get; set; }
        // public string UserEmail { get; set; }
        public string emailAddress;
        public string nume_salon;
        public string nume_angajat;


        public UserControlCalendar(string emailAddress)
        {
            InitializeComponent();

            // Asociem evenimentul DateChanged al monthCalendar1 cu metoda monthCalendar1_DateChanged
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // Asociem evenimentul Click al butonului SaveDataButton cu metoda SaveDataButton_Click

            // Configurare ComboBox
            comboBoxOre.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxOre.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.emailAddress = emailAddress;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            List<string> availableTimes = GetAvailableTimes(selectedDate);
            PopulateComboBoxOre(availableTimes);
        }

        private List<string> GetAvailableTimes(DateTime date)
        {
            List<string> availableTimes = new List<string>();

            // Adăugăm orele disponibile, de la 09:00 la 21:00, cu excluderea orei de prânz
            DateTime currentHour = new DateTime(date.Year, date.Month, date.Day, 9, 0, 0);
            DateTime endHour = new DateTime(date.Year, date.Month, date.Day, 21, 0, 0);
            while (currentHour <= endHour)
            {
                // Excludem ora de prânz
                if (currentHour.Hour != 12)
                {
                    availableTimes.Add(currentHour.ToString("HH:mm"));
                }
                // Adăugăm 30 de minute
                currentHour = currentHour.AddMinutes(30);
            }

            return availableTimes;
        }

        private void PopulateComboBoxOre(List<string> availableTimes)
        {
            comboBoxOre.Items.Clear();
            if (availableTimes != null && availableTimes.Count > 0)
            {
                foreach (string time in availableTimes)
                {
                    comboBoxOre.Items.Add(time);
                }
            }
            else
            {
                comboBoxOre.Items.Add("Nu sunt ore disponibile");
            }
        }

        private void SaveDataButton_Click_1(object sender, EventArgs e)
        {
            try
            {

                string username = emailAddress; // Utilizăm adresa de e-mail stocată în proprietatea UserEmail
                string numeSalon = nume_salon;
                string numeAngajat = nume_angajat;
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Numele utilizatorului nu poate fi gol.");
                    return;
                }
                string email = GetEmailFromTable2(username);
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Adresa de e-mail nu a putut fi găsită.");
                    return;
                }
                string salonName = GetSalonNameFromAngajati(numeSalon);
                string angajatName = GetAngajatNameFromAngajati(numeAngajat);
                DateTime selectedDate = monthCalendar1.SelectionStart;
                string selectedTime = comboBoxOre.Text;

                singleTon.GetConnection().Open();

                string query = @"INSERT INTO Programari (Mail, Nume_Salon, Nume_Angajat, Data, Ora) 
                            VALUES (@Mail, @Nume_Salon, @Nume_Angajat, @Data, @Ora)";
                SqlCommand cmd = new SqlCommand(query, singleTon.GetConnection());
                cmd.Parameters.AddWithValue("@Mail", email);
                cmd.Parameters.AddWithValue("@Nume_Salon", salonName);
                cmd.Parameters.AddWithValue("@Nume_Angajat", angajatName);
                cmd.Parameters.AddWithValue("@Data", selectedDate);
                cmd.Parameters.AddWithValue("@Ora", selectedTime);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Programarea a fost înregistrată cu succes!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Programarea nu a putut fi efectuată " + ex.Message);
            }
            finally
            {
                singleTon.GetConnection().Close();
            }
        }

        private string GetEmailFromTable2(string username)
        {
            string email = "";

            try
            {
                singleTon.GetConnection().Open();

                string queryEmail = "SELECT Mail FROM Tabel2 WHERE Mail = @Username";
                SqlCommand cmdEmail = new SqlCommand(queryEmail, singleTon.GetConnection());
                cmdEmail.Parameters.AddWithValue("@Username", username);
                email = (string)cmdEmail.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la obținerea adresei de email: " + ex.Message);
            }
            finally
            {
                singleTon.GetConnection().Close();
            }

            return email;
        }

        private string GetSalonNameFromAngajati(string nume_Salon)
        {
            string salonName = "";

            try
            {
                singleTon.GetConnection().Open();

                string querysalonName = "SELECT Nume_Salon FROM ANGAJATI WHERE Nume_Salon = @Nume_Salon";
                SqlCommand cmdSalon = new SqlCommand(querysalonName, singleTon.GetConnection());
                cmdSalon.Parameters.AddWithValue("@Nume_Salon", nume_Salon); 
                salonName = (string)cmdSalon.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la obținerea numelui salonului: " + ex.Message);
            }
            finally
            {
                singleTon.GetConnection().Close();
            }

            return salonName;
        }

        private string GetAngajatNameFromAngajati(string nume_angajat)
        {
            string angajatName = "";

            try
            {
                singleTon.GetConnection().Open();

                string queryangajatName = "SELECT Nume_Angajat FROM ANGAJATI WHERE Nume_Angajat = @Nume_Angajat";
                SqlCommand cmdAngajat = new SqlCommand(queryangajatName, singleTon.GetConnection());
                cmdAngajat.Parameters.AddWithValue("@Nume_Angajat", nume_angajat);
                angajatName = (string)cmdAngajat.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la obținerea numelui angajatului: " + ex.Message);
            }
            finally
            {
                singleTon.GetConnection().Close();
            }

            return angajatName;
        }

        private void UserControlCalendar_Load(object sender, EventArgs e)
        {

        }
    }
}