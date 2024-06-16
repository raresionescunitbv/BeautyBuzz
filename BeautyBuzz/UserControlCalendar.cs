using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Configuration;

namespace BeautyBuzz
{
    public partial class UserControlCalendar : Form
    {
        private SingleTon singleTon = SingleTon.Instance;

        public string emailAddress;
        public string nume_salon;
        public string nume_angajat;
        public string TableName { get; set; }

        public UserControlCalendar(string emailAddress, string tableName)
        {
            InitializeComponent();

            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            this.emailAddress = emailAddress;
            TableName = tableName;
            InitializeSalonAndAngajatNames();

        }

        private void InitializeSalonAndAngajatNames()
        {
            nume_salon = string.Empty;
            nume_angajat = string.Empty;
            // Verifică numele tabelului și setează metodele corecte pentru extragerea numelui de salon și angajat
            switch (TableName)
            {
                case "ANGAJATI":
                    nume_salon = GetSalonNameFromAngajati(nume_salon);
                    nume_angajat = GetAngajatNameFromAngajati(nume_angajat);
                    break;
                case "ANGAJATIFrizerie":
                    nume_salon = GetSalonNameFromFrizerie(nume_salon);
                    nume_angajat = GetAngajatNameFromFrizerie(nume_angajat);
                    break;
                case "ANGAJATITatto":
                    nume_salon = GetSalonNameFromTatto(nume_salon);
                    nume_angajat = GetAngajatNameFromTatto(nume_angajat);
                    break;
                case "ANGAJATIEpilare":
                    nume_salon = GetSalonNameFromEpilare(nume_salon);
                    nume_angajat = GetAngajatNameFromEpilare(nume_angajat);
                    break;
                case "ANGAJATIManichiura":
                    nume_salon = GetSalonNameFromManichiura(nume_salon);
                    nume_angajat = GetAngajatNameFromManichiura(nume_angajat);
                    break;
                case "ANGAJATIOthers":
                    nume_salon = GetSalonNameFromOthers(nume_salon);
                    nume_angajat = GetAngajatNameFromOthers(nume_angajat);
                    break;
                default:
                    // Poți adăuga o acțiune implicită pentru a trata cazurile care nu sunt acoperite mai sus
                    break;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;

            if (selectedDate < DateTime.Today)
            {
                MessageBox.Show("Nu puteți selecta o dată anterioară zilei de azi.");
                monthCalendar1.SetDate(DateTime.Today);
                return;
            }

            List<string> availableTimes = GetAvailableTimes(selectedDate, nume_angajat);
            PopulateComboBoxOre(availableTimes);
        }

        private List<string> GetAvailableTimes(DateTime date, string numeAngajat)
        {
            List<string> availableTimes = new List<string>();

            DateTime currentHour;
            DateTime endHour;
            if (IsRomanianPublicHoliday(date) || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return availableTimes;
            }
            else if (date.DayOfWeek == DayOfWeek.Saturday)
            {
                currentHour = new DateTime(date.Year, date.Month, date.Day, 9, 0, 0);
                endHour = new DateTime(date.Year, date.Month, date.Day, 16, 0, 0);
            }
            else
            {
                currentHour = new DateTime(date.Year, date.Month, date.Day, 9, 0, 0);
                endHour = new DateTime(date.Year, date.Month, date.Day, 21, 0, 0);
            }

            while (currentHour <= endHour)
            {
                if (currentHour.Hour != 12)
                {
                    if (IsTimeSlotAvailable(currentHour, numeAngajat))
                    {
                        availableTimes.Add(currentHour.ToString("HH:mm"));
                    }
                }
                currentHour = currentHour.AddMinutes(30);
            }

            return availableTimes;
        }

        private bool IsTimeSlotAvailable(DateTime timeSlot, string numeAngajat)
        {
            try
            {
                singleTon.GetConnection().Open();

                string query = "SELECT COUNT(*) FROM Programari WHERE Nume_Angajat = @Nume_Angajat AND Data = @Data AND Ora = @Ora";
                SqlCommand cmd = new SqlCommand(query, singleTon.GetConnection());
                cmd.Parameters.AddWithValue("@Nume_Angajat", numeAngajat);
                cmd.Parameters.AddWithValue("@Data", timeSlot.Date);
                cmd.Parameters.AddWithValue("@Ora", timeSlot.ToString("HH:mm"));

                int count = (int)cmd.ExecuteScalar();

                return count == 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la verificarea disponibilității: " + ex.Message);
                return false;
            }
            finally
            {
                singleTon.GetConnection().Close();
            }
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
                comboBoxOre.Items.Add("Liber!");
            }
        }

        private void SaveDataButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string username = emailAddress;
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
                DateTime selectedDate = monthCalendar1.SelectionStart;
                string selectedTime = comboBoxOre.Text;

                singleTon.GetConnection().Open();

                string query = @"INSERT INTO Programari (Mail, Nume_Salon, Nume_Angajat, Data, Ora) 
                            VALUES (@Mail, @Nume_Salon, @Nume_Angajat, @Data, @Ora)";
                SqlCommand cmd = new SqlCommand(query, singleTon.GetConnection());
                cmd.Parameters.AddWithValue("@Mail", email);
                cmd.Parameters.AddWithValue("@Nume_Salon", numeSalon);
                cmd.Parameters.AddWithValue("@Nume_Angajat", numeAngajat);
                cmd.Parameters.AddWithValue("@Data", selectedDate);
                cmd.Parameters.AddWithValue("@Ora", selectedTime);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Programarea a fost înregistrată cu succes!");
                SendConfirmationEmail(email);
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
        private void SendConfirmationEmail(string emailAddress)
        {
            try
            {
                string fromAddress = ConfigurationManager.AppSettings["GmailAddress"];
                string password = ConfigurationManager.AppSettings["GmailPassword"];

                MailMessage message = new MailMessage();
                message.To.Add(emailAddress);
                message.From = new MailAddress(fromAddress, "BeautyBuzz");
                message.Body = "Programarea a fost finalizată cu succes! Verifica sectiunea de programari :) ";
                message.Subject = "Confirmare Programare BeautyBuzz";

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

                string queryangajatName = $"SELECT Nume_Angajat FROM ANGAJATI WHERE Nume_Angajat = @Nume_Angajat";
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

        private string GetSalonNameFromFrizerie(string nume_Salon)
        {
            string salonName = "";

            try
            {
                singleTon.GetConnection().Open();

                string querysalonName = "SELECT Nume_Salon FROM ANGAJATIFrizerie WHERE Nume_Salon = @Nume_Salon";
                SqlCommand cmdSalon = new SqlCommand(querysalonName, singleTon.GetConnection());
                cmdSalon.Parameters.AddWithValue("@Nume_Salon", nume_Salon);
                salonName = (string)cmdSalon.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la obținerea numelui salonului din Frizerie: " + ex.Message);
            }
            finally
            {
                singleTon.GetConnection().Close();
            }

            return salonName;
        }

        private string GetAngajatNameFromFrizerie(string nume_angajat)
        {
            string angajatName = "";

            try
            {
                singleTon.GetConnection().Open();

                string queryangajatName = "SELECT Nume_Angajat FROM ANGAJATIFrizerie WHERE Nume_Angajat = @Nume_Angajat";
                SqlCommand cmdAngajat = new SqlCommand(queryangajatName, singleTon.GetConnection());
                cmdAngajat.Parameters.AddWithValue("@Nume_Angajat", nume_angajat);
                angajatName = (string)cmdAngajat.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la obținerea numelui angajatului din Frizerie: " + ex.Message);
            }
            finally
            {
                singleTon.GetConnection().Close();
            }

            return angajatName;
        }

        private string GetSalonNameFromTatto(string nume_Salon)
        {
            string salonName = "";

            try
            {
                singleTon.GetConnection().Open();

                string querysalonName = "SELECT Nume_Salon FROM ANGAJATITatto WHERE Nume_Salon = @Nume_Salon";
                SqlCommand cmdSalon = new SqlCommand(querysalonName, singleTon.GetConnection());
                cmdSalon.Parameters.AddWithValue("@Nume_Salon", nume_Salon);
                salonName = (string)cmdSalon.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la obținerea numelui salonului de Tatuaje: " + ex.Message);
            }
            finally
            {
                singleTon.GetConnection().Close();
            }

            return salonName;
        }

        private string GetAngajatNameFromTatto(string nume_angajat)
        {
            string angajatName = "";

            try
            {
                singleTon.GetConnection().Open();

                string queryangajatName = "SELECT Nume_Angajat FROM ANGAJATITatto WHERE Nume_Angajat = @Nume_Angajat";
                SqlCommand cmdAngajat = new SqlCommand(queryangajatName, singleTon.GetConnection());
                cmdAngajat.Parameters.AddWithValue("@Nume_Angajat", nume_angajat);
                angajatName = (string)cmdAngajat.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la obținerea numelui angajatului de la salonul de Tatuaje: " + ex.Message);
            }
            finally
            {
                singleTon.GetConnection().Close();
            }

            return angajatName;
        }
        private string GetSalonNameFromEpilare(string nume_Salon)
        {
            string salonName = "";

            try
            {
                singleTon.GetConnection().Open();
                string querysalonName = "SELECT Nume_Salon FROM ANGAJATIEpilare WHERE Nume_Salon = @Nume_Salon";
                SqlCommand cmdSalon = new SqlCommand(querysalonName, singleTon.GetConnection());
                cmdSalon.Parameters.AddWithValue("@Nume_Salon", nume_Salon);
                salonName = (string)cmdSalon.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la obținerea numelui salonului din Epilare: " + ex.Message);
            }
            finally
            {
                singleTon.GetConnection().Close();
            }

            return salonName;
        }

        private string GetAngajatNameFromEpilare(string nume_angajat)
        {
            string angajatName = "";

            try
            {
                singleTon.GetConnection().Open();

                string queryangajatName = "SELECT Nume_Angajat FROM ANGAJATIEpilare WHERE Nume_Angajat = @Nume_Angajat";
                SqlCommand cmdAngajat = new SqlCommand(queryangajatName, singleTon.GetConnection());
                cmdAngajat.Parameters.AddWithValue("@Nume_Angajat", nume_angajat);
                angajatName = (string)cmdAngajat.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la obținerea numelui angajatului din Epilare: " + ex.Message);
            }
            finally
            {
                singleTon.GetConnection().Close();
            }

            return angajatName;
        }
        private string GetSalonNameFromManichiura(string nume_Salon)
        {
            string salonName = "";

            try
            {
                singleTon.GetConnection().Open();

                string querysalonName = "SELECT Nume_Salon FROM ANGAJATIManichiura WHERE Nume_Salon = @Nume_Salon";
                SqlCommand cmdSalon = new SqlCommand(querysalonName, singleTon.GetConnection());
                cmdSalon.Parameters.AddWithValue("@Nume_Salon", nume_Salon);
                salonName = (string)cmdSalon.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la obținerea numelui salonului din Manichiura: " + ex.Message);
            }
            finally
            {
                singleTon.GetConnection().Close();
            }

            return salonName;
        }

        private string GetAngajatNameFromManichiura(string nume_angajat)
        {
            string angajatName = "";

            try
            {
                singleTon.GetConnection().Open();

                string queryangajatName = "SELECT Nume_Angajat FROM ANGAJATIManichiura WHERE Nume_Angajat = @Nume_Angajat";
                SqlCommand cmdAngajat = new SqlCommand(queryangajatName, singleTon.GetConnection());
                cmdAngajat.Parameters.AddWithValue("@Nume_Angajat", nume_angajat);
                angajatName = (string)cmdAngajat.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la obținerea numelui angajatului din Manichiura: " + ex.Message);
            }
            finally
            {
                singleTon.GetConnection().Close();
            }

            return angajatName;
        }

        private string GetSalonNameFromOthers(string nume_Salon)
        {
            string salonName = "";

            try
            {
                singleTon.GetConnection().Open();

                string querysalonName = "SELECT Nume_Salon FROM ANGAJATIOthers WHERE Nume_Salon = @Nume_Salon";
                SqlCommand cmdSalon = new SqlCommand(querysalonName, singleTon.GetConnection());
                cmdSalon.Parameters.AddWithValue("@Nume_Salon", nume_Salon);
                salonName = (string)cmdSalon.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la obținerea numelui salonului din Altele: " + ex.Message);
            }
            finally
            {
                singleTon.GetConnection().Close();
            }

            return salonName;
        }

        private string GetAngajatNameFromOthers(string nume_angajat)
        {
            string angajatName = "";

            try
            {
                singleTon.GetConnection().Open();

                string queryangajatName = "SELECT Nume_Angajat FROM ANGAJATIOthers WHERE Nume_Angajat = @Nume_Angajat";
                SqlCommand cmdAngajat = new SqlCommand(queryangajatName, singleTon.GetConnection());
                cmdAngajat.Parameters.AddWithValue("@Nume_Angajat", nume_angajat);
                angajatName = (string)cmdAngajat.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare la obținerea numelui angajatului din Altele: " + ex.Message);
            }
            finally
            {
                singleTon.GetConnection().Close();
            }

            return angajatName;
        }
        private void UserControlCalendar_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.TodayDate = DateTime.Today;
            monthCalendar1.SelectionStart = DateTime.Today;
            monthCalendar1.SelectionEnd = DateTime.Today;

            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            SetAvailableTimes();
        }

        private void SetAvailableTimes()
        {
            DateTime currentDate = monthCalendar1.TodayDate;
            DateTime endDate = currentDate.AddMonths(1);

            foreach (DateTime date in EachDay(currentDate, endDate))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    AddAvailableTimes(date, new TimeSpan(9, 0, 0), new TimeSpan(16, 0, 0));

                }
                else if (date.DayOfWeek == DayOfWeek.Sunday || IsRomanianPublicHoliday(date))
                {
                    AddAvailableTimes(date, new TimeSpan(0, 0, 0), new TimeSpan(0, 0, 0));
                }
                else
                {
                    AddAvailableTimes(date, new TimeSpan(9, 0, 0), new TimeSpan(21, 0, 0));
                }
            }
        }
        private bool IsRomanianPublicHoliday(DateTime date)
        {
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;

            // Lista sărbătorilor publice fixe
            if ((month == 1 && (day == 1 || day == 2)) ||  // Anul Nou
                (month == 1 && day == 24) ||  // Unirea Principatelor Romane
                (month == 5 && day == 1) ||  // Ziua Muncii
                (month == 6 && day == 1) ||  // Ziua Copilului
                (month == 8 && day == 15) || // Adormirea Maicii Domnului
                (month == 11 && day == 30) || // Sfantul Andrei
                (month == 12 && day == 1) ||  // Ziua Nationala
                (month == 12 && (day == 25 || day == 26))) // Craciunul
            {
                return true;
            }

            // pastele
            DateTime orthodoxEaster = CalculateOrthodoxEaster(year);
            if (date == orthodoxEaster || date == orthodoxEaster.AddDays(1))
            {
                return true;
            }

            return false;
        }
        private DateTime CalculateOrthodoxEaster(int year)
        {
            int a = year % 19;
            int b = year % 7;
            int c = year % 4;
            int d = (19 * a + 16) % 30;
            int e = (2 * c + 4 * b + 6 * d) % 7;
            int day = (d + e > 9) ? (d + e - 9) : (d + e + 22);
            int month = (d + e > 9) ? 4 : 3;
            return new DateTime(year, month, day).AddDays(13); // Calendarul iulian + 13 zile pentru a ajunge la calendarul gregorian
        }

        private void AddAvailableTimes(DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            string dateString = date.ToString("yyyy-MM-dd");
            DateTime currentHour = new DateTime(date.Year, date.Month, date.Day, startTime.Hours, startTime.Minutes, 0);
            DateTime endHour = new DateTime(date.Year, date.Month, date.Day, endTime.Hours, endTime.Minutes, 0);

            while (currentHour <= endHour)
            {
                if (currentHour.Hour != 12)
                {
                    string timeSlot = currentHour.ToString("HH:mm");
                    Console.WriteLine(timeSlot);
                }
                currentHour = currentHour.AddMinutes(30);
            }
        }
        private IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }
        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            SetAvailableTimes();
        }
    }


}
