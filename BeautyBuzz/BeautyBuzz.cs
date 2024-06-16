using BeautyBuzz.Properties;
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeautyBuzz
{
    public partial class BeautyBuzz : Form
    {
        private SingleTon singleTon = SingleTon.Instance;
        private string nume_salon;
        private string nume_angajat;

        public string Textbox1Value { get; set; }
        public string Textbox2Value { get; set; }

        private readonly IDatabase _database;

        public BeautyBuzz(IDatabase database)
        {
            _database = database;
            InitializeComponent();
        }

        public BeautyBuzz()
        {
            InitializeComponent();
            textBox1.BackColor = Color.Transparent;
            textBox2.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                button1_Click_1(this, new EventArgs());
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Textbox1Value = textBox1.Text;
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            string username = Textbox1Value.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Completați toate câmpurile!");
                return;
            }

            try
            {
                singleTon.OpenConnection();
                Console.WriteLine("Connection state after open: " + singleTon.GetConnection().State);

                string queryAdmin = "SELECT COUNT(*) FROM Admin1 WHERE Username = @Username AND Parola = @Password";
                using (SqlCommand cmdAdmin = new SqlCommand(queryAdmin, singleTon.GetConnection()))
                {
                    cmdAdmin.Parameters.AddWithValue("@Username", username);
                    cmdAdmin.Parameters.AddWithValue("@Password", password);
                    int rowCountAdmin = (int)cmdAdmin.ExecuteScalar();

                    if (rowCountAdmin == 0)
                    {
                        string queryEmail = "SELECT COUNT(*) FROM Tabel2 WHERE Mail = @Username AND Password = @Password";
                        using (SqlCommand cmdEmail = new SqlCommand(queryEmail, singleTon.GetConnection()))
                        {
                            cmdEmail.Parameters.AddWithValue("@Username", username);
                            cmdEmail.Parameters.AddWithValue("@Password", password);
                            int rowCountEmail = (int)cmdEmail.ExecuteScalar();

                            if (rowCountEmail == 0)
                            {
                                string queryPhone = "SELECT COUNT(*) FROM TabelPhone WHERE PhoneNumber = @Username AND Password = @Password";
                                using (SqlCommand cmdPhone = new SqlCommand(queryPhone, singleTon.GetConnection()))
                                {
                                    cmdPhone.Parameters.AddWithValue("@Username", username);
                                    cmdPhone.Parameters.AddWithValue("@Password", password);
                                    int rowCountPhone = (int)cmdPhone.ExecuteScalar();

                                    if (rowCountPhone > 0)
                                    {
                                        MessageBox.Show("Autentificare reușită!");
                                        Menu f1 = new Menu();
                                        f1.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show(" Utilizatorul nu există în baza de date sau parola este incorectă.", "Contul nu a fost creat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        button2.BackColor = Color.Red;
                                    }
                                }
                            }
                            else
                            {
                                this.Hide();
                                Menu menu = new Menu(username, nume_salon, nume_angajat);
                                menu.Show();
                            }
                        }
                    }
                    else
                    {
                        AdminInterface adminInterface = new AdminInterface();
                        this.Hide();
                        adminInterface.Show();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eroare de autentificare: " + ex.Message);
            }
            finally
            {
                singleTon.CloseConnection();
                Console.WriteLine("Connection state after close: " + singleTon.GetConnection().State);
            }
        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
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
                textBox2.PasswordChar = '•';
            }
        }

        private void labelForgetPass_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            SendPass sendPass = new SendPass(username, password);
            sendPass.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
