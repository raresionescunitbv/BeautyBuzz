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
            //   pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage; // Set image to be centered
        }

        public UserControlCont(string emailAddress)
        {
            InitializeComponent();
            conn = singleTon.GetConnection();
            this.emailAddress = emailAddress;
            //  pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage; // Set image to be centered
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "All Image Files|.jpg;.jpeg;.png;.gif;.bmp|All files|.*"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog1.FileName;
                // pictureBox1.Image = Image.FromFile(selectedImagePath);
                userImageBytes = GetPhoto();
            }

            try
            {
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    conn.Open();
                    SqlCommand updateCmd = new SqlCommand("UPDATE Tabel2 SET Image = @Image WHERE Mail = @Mail", conn);
                    updateCmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = userImageBytes;
                    updateCmd.Parameters.AddWithValue("@Mail", emailAddress);

                    if (updateCmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Image updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No records updated. Check if the condition matches any records.");
                    }
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

                    if (reader["Image"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])reader["Image"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            // pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // pictureBox1.Image = null;

                    }
                }
                else
                {
                    //pictureBox1.Image = null;

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

        public event EventHandler CloseMenuWindow;



        public void button3_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            if (this.Parent is Menu)
            {
                this.Parent.Visible = false;
            }


            BeautyBuzz beautyBuzz = new BeautyBuzz();
            beautyBuzz.Show();


            Form parentForm = this.FindForm();
            if (parentForm != null)
                parentForm.Hide();


        }



        private void addUserControl(DetaliiCont userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!string.IsNullOrEmpty(emailAddress))
            {
                DetaliiCont detalii_Cont = new DetaliiCont(emailAddress);
                this.Parent.Controls.Add(detalii_Cont);
                detalii_Cont.Show();
            }
            else
            {
                MessageBox.Show("Email address is not available.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Placeholder for any functionality
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!string.IsNullOrEmpty(emailAddress))
            {
                Suport detalii_Cont = new Suport(emailAddress);
                this.Parent.Controls.Add(detalii_Cont);
                detalii_Cont.Show();
            }
            else
            {
                MessageBox.Show("Email address is not available.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Placeholder for any functionality
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!string.IsNullOrEmpty(emailAddress))
            {
                ProdProf detalii_Cont = new ProdProf(emailAddress);
                this.Parent.Controls.Add(detalii_Cont);
                detalii_Cont.Show();
            }
            else
            {
                MessageBox.Show("Email address is not available.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!string.IsNullOrEmpty(emailAddress))
            {
                Feedback detalii_Cont = new Feedback(emailAddress);
                this.Parent.Controls.Add(detalii_Cont);
                detalii_Cont.Show();
            }
            else
            {
                MessageBox.Show("Email address is not available.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}