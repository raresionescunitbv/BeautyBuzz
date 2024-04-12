using BeautyBuzz.Properties;
using Microsoft.Data.SqlClient;

using System.Windows.Forms;
using Twilio.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace BeautyBuzz
{
    public partial class BeautyBuzz : Form
    {
        private SingleTon singleTon = SingleTon.Instance;
        private string nume_salon;
        private string nume_angajat;
        public string Textbox1Value { get; set; }

        public BeautyBuzz()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Textbox1Value = textBox1.Text; // Actualizăm Textbox1Value cu valoarea din textBox1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Textbox1Value;
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Completați toate câmpurile!");
                return;
            }

            try
            {
                // Deschideți conexiunea la baza de date utilizând clasa SingleTon
                singleTon.GetConnection().Open();

                // Verificați întâi în Tabel2 pentru adresa de e-mail și parolă
                string queryEmail = "SELECT COUNT(*) FROM Tabel2 WHERE Mail = @Username AND Password = @Password";
                SqlCommand cmdEmail = new SqlCommand(queryEmail, singleTon.GetConnection());
                cmdEmail.Parameters.AddWithValue("@Username", username);
                cmdEmail.Parameters.AddWithValue("@Password", password);
                int rowCountEmail = (int)cmdEmail.ExecuteScalar();
               // UserControlAcasa userControlAcasa = new UserControlAcasa();
                //userControlAcasa.UserEmail = username;
             



                // Dacă autentificarea prin e-mail a eșuat, verificați în TabelPhone pentru numărul de telefon și parolă
                if (rowCountEmail == 0)
                {
                    string queryPhone = "SELECT COUNT(*) FROM TabelPhone WHERE PhoneNumber = @Username AND Password = @Password";
                    SqlCommand cmdPhone = new SqlCommand(queryPhone, singleTon.GetConnection());
                    cmdPhone.Parameters.AddWithValue("@Username", username);
                    cmdPhone.Parameters.AddWithValue("@Password", password);
                    int rowCountPhone = (int)cmdPhone.ExecuteScalar();
                   

                    if (rowCountPhone > 0)
                    {
                        MessageBox.Show("Autentificare reușită!");
                        // Deschideți formularul corespunzător după autentificare
                        Form f1 = new Form();
                        f1.Show();
                        this.Hide();
                      
                    }
                    else
                    {
                        MessageBox.Show("Utilizatorul nu există în baza de date sau parola este incorectă.");
                    }
                }
                else
                {
                    // MessageBox.Show("Autentificare reușită!");
                    // Deschideți formularul corespunzător după autentificare
                    this.Hide();
                    Menu menu = new Menu(username,nume_salon,nume_angajat);
                    menu.Show();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare de autentificare: " + ex.Message);
            }
            finally
            {
                // Închideți conexiunea la baza de date
                singleTon.GetConnection().Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = button2.BackColor;
            button2.ForeColor = Color.Blue;
            button2.Font = new Font(button2.Font, FontStyle.Underline);
        }

        private void BeautyBuzz_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            checkBoxLoginPass.BackColor = Color.Transparent;
        }

        private void button1_Click_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void checkBoxLoginPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoginPass.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void labelForgetPass_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            SendPass sendPass = new SendPass(username, password);
            sendPass.ShowDialog();
        }
    }
}