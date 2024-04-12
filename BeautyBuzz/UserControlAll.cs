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
    public partial class UserControlAll : UserControl
    {
        private string emailAddress;
        private string nume_salon;
        private string nume_angajat;
        public UserControlAll(string emailAddress, string nume_salon, string nume_angajat)
        {
            InitializeComponent();
            this.emailAddress = emailAddress;
            this.nume_salon = nume_salon;
            this.nume_angajat = nume_angajat;
        }

        private void label_Masaj_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menuForm = this.ParentForm as Menu;
            if (menuForm != null)
            {
                UserControlAcasa uc = new UserControlAcasa(emailAddress,nume_salon, nume_angajat);
                menuForm.addUserControl(uc);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void UserControlAll_Load(object sender, EventArgs e)
        {
            guna2TextBox1.ReadOnly = true;
        }

      
    }
}
