using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace BeautyBuzz
{
    public partial class ProdProf : UserControl
    {
        private string emailAddress;
        private SqlConnection conn;

        public ProdProf(string emailAddress)
        {
            InitializeComponent();
            this.emailAddress = emailAddress;
            conn = SingleTon.Instance.GetConnection(); // Obținem conexiunea din Singleton
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!string.IsNullOrEmpty(emailAddress))
            {
                ProduseProfesionale produseProfesionale = new ProduseProfesionale(emailAddress);
                this.Parent.Controls.Add(produseProfesionale);
                produseProfesionale.Show();
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
                ProduseMasaj produseProfesionale = new ProduseMasaj(emailAddress);
                this.Parent.Controls.Add(produseProfesionale);
                produseProfesionale.Show();
            }
            else
            {
                MessageBox.Show("Email address is not available.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {


            this.Hide();
            if (!string.IsNullOrEmpty(emailAddress))
            {
                Tatuaje produseProfesionale = new Tatuaje(emailAddress);
                this.Parent.Controls.Add(produseProfesionale);
                produseProfesionale.Show();
            }
            else
            {
                MessageBox.Show("Email address is not available.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            if (!string.IsNullOrEmpty(emailAddress))
            {
                Manichiura produseProfesionale = new Manichiura(emailAddress);
                this.Parent.Controls.Add(produseProfesionale);
                produseProfesionale.Show();
            }
            else
            {
                MessageBox.Show("Email address is not available.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            if (!string.IsNullOrEmpty(emailAddress))
            {
                Epilare produseProfesionale = new Epilare(emailAddress);
                this.Parent.Controls.Add(produseProfesionale);
                produseProfesionale.Show();
            }
            else
            {
                MessageBox.Show("Email address is not available.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!string.IsNullOrEmpty(emailAddress))
            {
                UserControlCont detalii_Cont = new UserControlCont(emailAddress);
                this.Parent.Controls.Add(detalii_Cont);
                detalii_Cont.Show();
            }
            else
            {
                MessageBox.Show("Email address is not available.");
            }
        }
    }
}
