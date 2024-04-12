using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BeautyBuzz
{
    public partial class UserControlCont : UserControl
    {
        private SqlConnection conn;
        private SingleTon singleTon = SingleTon.Instance;
        private string emailAddress;
        private string selectedImagePath;
        private byte[] userImageBytes;

        public UserControlCont()
        {
            InitializeComponent();
            conn = singleTon.GetConnection();
        }

        public UserControlCont(string emailAddress)
        {
            InitializeComponent();
            conn = singleTon.GetConnection();
            this.emailAddress = emailAddress;
        }

        public void SetEmail(string email)
        {
            this.emailAddress = email;
        }

 

        private byte[] GetPhoto()
        {
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Please select an image first.");
                return null;
            }

            byte[] imageData;
            using (FileStream stream = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    imageData = memoryStream.ToArray();
                }
            }
            return imageData;
        }


        // Method to load the image when the UserControl is loaded




        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "All Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files|*.*"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog1.FileName;

                pictureBox1.Image = Image.FromFile(selectedImagePath);

                userImageBytes = GetPhoto();
            }

            try
            {
                if (!string.IsNullOrEmpty(selectedImagePath)) // Verificați dacă a fost selectată o imagine
                {
                    conn.Open();
                    SqlCommand updateCmd = new SqlCommand("UPDATE Tabel2 SET Image = @Image WHERE Mail = @Mail", conn);
                    updateCmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = userImageBytes;

                    // Utilizați adresa de e-mail stocată în emailAddress
                    updateCmd.Parameters.AddWithValue("@Mail", emailAddress);

                    if (updateCmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Imagine actualizată cu succes.");
                    }
                    else
                    {
                        MessageBox.Show("Nu s-au actualizat înregistrări. Verificați dacă condiția corespunde vreunei înregistrări.");
                    }
                }
                else
                {
                    MessageBox.Show("Vă rugăm să selectați mai întâi o imagine.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void UserControlCont_Load_2(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand selectCmd = new SqlCommand("SELECT FirstName, LastName, Image FROM Tabel2 WHERE Mail = @Mail", conn);
                selectCmd.Parameters.AddWithValue("@Mail", emailAddress);

                SqlDataReader reader = selectCmd.ExecuteReader();

                if (reader.Read())
                {
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();

                    label1.Text = firstName;
                    label2.Text = lastName;

                    if (reader["Image"] != DBNull.Value) // Verifică dacă câmpul Image este NULL
                    {
                        byte[] imageData = (byte[])reader["Image"];
                        if (imageData != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBox1.Image = null;
                            MessageBox.Show("No image found for the user.");
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                        MessageBox.Show("No image found for the user.");
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                    MessageBox.Show("No record found for the user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            BeautyBuzz beautyBuzz = new BeautyBuzz();
            beautyBuzz.Show();
            this.Hide();


        }
    }
}