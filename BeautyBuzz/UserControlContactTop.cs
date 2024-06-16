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
using System.IO;

namespace BeautyBuzz
{
    public partial class UserControlContactTop : UserControl
    {
        private byte[] uploadedFileData;

        public UserControlContactTop()
        {
            InitializeComponent();
        }

        private void UserControlContactTop_Load(object sender, EventArgs e)
        {

        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            string field1 = textBox1.Text;
            string field2 = textBox2.Text;
            string field3 = textBox3.Text;
            string field4 = textBox4.Text;
            string field5 = textBox5.Text;
            string field6 = textBox6.Text;
            string field7 = textBox7.Text;
            string field8 = textBox8.Text;

            if (InsertFormData(field1, field2, field3, field4, field5, field6, field7, field8))
            {
                MessageBox.Show("Data saved successfully!");
            }
            else
            {
                MessageBox.Show("Failed to save data.");
            }
        }

        

        private bool InsertFormData(string field1, string field2, string field3, string field4, string field5, string field6, string field7, string field8)
        {
            try
            {
                using (SqlConnection connection = SingleTon.Instance.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("INSERT INTO dbo.Formulare (Field1, Field2, Field3, Field4, Field5, Field6, Field7, Field8) VALUES (@Field1, @Field2, @Field3, @Field4, @Field5, @Field6, @Field7, @Field8)", connection))
                    {
                        command.Parameters.AddWithValue("@Field1", field1);
                        command.Parameters.AddWithValue("@Field2", field2);
                        command.Parameters.AddWithValue("@Field3", field3);
                        command.Parameters.AddWithValue("@Field4", field4);
                        command.Parameters.AddWithValue("@Field5", field5);
                        command.Parameters.AddWithValue("@Field6", field6);
                        command.Parameters.AddWithValue("@Field7", field7);
                        command.Parameters.AddWithValue("@Field8", field8);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}
