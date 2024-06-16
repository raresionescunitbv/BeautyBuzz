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
<<<<<<< HEAD
            //   pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage; // Set image to be centered
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        }

        public UserControlCont(string emailAddress)
        {
            InitializeComponent();
            conn = singleTon.GetConnection();
            this.emailAddress = emailAddress;
<<<<<<< HEAD
            //  pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage; // Set image to be centered
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        }

        public void SetEmail(string email)
        {
            this.emailAddress = email;
        }

<<<<<<< HEAD
=======
 

>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
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

<<<<<<< HEAD
=======

        // Method to load the image when the UserControl is loaded




>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
<<<<<<< HEAD
                Filter = "All Image Files|.jpg;.jpeg;.png;.gif;.bmp|All files|.*"
=======
                Filter = "All Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files|*.*"
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog1.FileName;
<<<<<<< HEAD
                // pictureBox1.Image = Image.FromFile(selectedImagePath);
=======

                pictureBox1.Image = Image.FromFile(selectedImagePath);

>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
                userImageBytes = GetPhoto();
            }

            try
            {
<<<<<<< HEAD
                if (!string.IsNullOrEmpty(selectedImagePath))
=======
                if (!string.IsNullOrEmpty(selectedImagePath)) // Verificați dacă a fost selectată o imagine
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
                {
                    conn.Open();
                    SqlCommand updateCmd = new SqlCommand("UPDATE Tabel2 SET Image = @Image WHERE Mail = @Mail", conn);
                    updateCmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = userImageBytes;
<<<<<<< HEAD
=======

                    // Utilizați adresa de e-mail stocată în emailAddress
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
                    updateCmd.Parameters.AddWithValue("@Mail", emailAddress);

                    if (updateCmd.ExecuteNonQuery() > 0)
                    {
<<<<<<< HEAD
                        MessageBox.Show("Image updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No records updated. Check if the condition matches any records.");
                    }
                }
=======
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
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
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
<<<<<<< HEAD

=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
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
<<<<<<< HEAD
                    label1.Text = firstName;
                    label2.Text = lastName;

                    if (reader["Image"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])reader["Image"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            // pictureBox1.Image = Image.FromStream(ms);
=======

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
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
                        }
                    }
                    else
                    {
<<<<<<< HEAD
                        // pictureBox1.Image = null;

=======
                        pictureBox1.Image = null;
                        MessageBox.Show("No image found for the user.");
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
                    }
                }
                else
                {
<<<<<<< HEAD
                    //pictureBox1.Image = null;

=======
                    pictureBox1.Image = null;
                    MessageBox.Show("No record found for the user.");
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
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
<<<<<<< HEAD

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
=======
        private void button3_Click(object sender, EventArgs e)
        {
            BeautyBuzz beautyBuzz = new BeautyBuzz();
            beautyBuzz.Show();
            this.Hide();

>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f

        }
    }
}