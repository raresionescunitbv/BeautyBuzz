using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyBuzz
{
    public partial class AdminMain : UserControl
    {
        public AdminMain()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AngajatiAdmin adminMainControl = new AngajatiAdmin();
            this.Controls.Add(adminMainControl);
            adminMainControl.Dock = DockStyle.Fill;
            adminMainControl.BringToFront();
            button1.Hide();
            button2.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button8.Hide();
            button9.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin1Admin adminMainControl = new Admin1Admin();
            this.Controls.Add(adminMainControl);
            adminMainControl.Dock = DockStyle.Fill;
            adminMainControl.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminTabel adminMainControl = new AdminTabel();
            this.Controls.Add(adminMainControl);
            adminMainControl.Dock = DockStyle.Fill;
            adminMainControl.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AngajatiEpilareAdmin adminMainControl = new AngajatiEpilareAdmin();
            this.Controls.Add(adminMainControl);
            adminMainControl.Dock = DockStyle.Fill;
            adminMainControl.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AngajatiFrizerieAdmin adminMainControl = new AngajatiFrizerieAdmin();
            this.Controls.Add(adminMainControl);
            adminMainControl.Dock = DockStyle.Fill;
            adminMainControl.BringToFront();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            AngajatiManichiuraAdmin adminMainControl = new AngajatiManichiuraAdmin();
            this.Controls.Add(adminMainControl);
            adminMainControl.Dock = DockStyle.Fill;
            adminMainControl.BringToFront();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            AngajatiTatuajeAdmin adminMainControl = new AngajatiTatuajeAdmin();
            this.Controls.Add(adminMainControl);
            adminMainControl.Dock = DockStyle.Fill;
            adminMainControl.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AngajatiOthersAdmin adminMainControl = new AngajatiOthersAdmin();
            this.Controls.Add(adminMainControl);
            adminMainControl.Dock = DockStyle.Fill;
            adminMainControl.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Programari adminMainControl = new Programari();
            this.Controls.Add(adminMainControl);
            adminMainControl.Dock = DockStyle.Fill;
            adminMainControl.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
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

        private void button(object sender, EventArgs e)
        {

        }

        private void AdminMain_Load(object sender, EventArgs e)
        {

        }
    }
}
