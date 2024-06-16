using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
<<<<<<< HEAD
=======

>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
namespace BeautyBuzz
{
    public partial class Menu : Form
    {
        private string emailAddress;
        private string nume_salon;
        private string nume_angajat;
<<<<<<< HEAD
        private Cosul_meu cosulMeuForm;

=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        public Menu(string emailAddress, string nume_salon, string nume_angajat)
        {
            InitializeComponent();
            UserControlAll uc = new UserControlAll(emailAddress, nume_salon, nume_angajat);
            addUserControl(uc);
<<<<<<< HEAD
            ProduseProfesionale produseProfesionale = new ProduseProfesionale(emailAddress);
            cosulMeuForm = null;

=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
            this.emailAddress = emailAddress;
            this.nume_salon = nume_salon;
            this.nume_angajat = nume_angajat;
        }

<<<<<<< HEAD
        public void InchidereMenu()
        {
            this.Close();
        }

        public Menu()
        {
            InitializeComponent();
        }

        public void addUserControl(UserControlAll userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Container.Controls.Clear();
=======
        public void addUserControl(UserControlAll userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Container.Controls.Clear(); // Șterge orice control existent din panou
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
            panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public void addUserControl(UserControlAcasa userControl)
        {
            userControl.Dock = DockStyle.Fill;
<<<<<<< HEAD
            panel_Container.Controls.Clear();
=======
            panel_Container.Controls.Clear(); // Șterge orice control existent din panou
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
            panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addUserControl(UserControlProgramari userControl)
        {
            userControl.Dock = DockStyle.Fill;
<<<<<<< HEAD
            panel_Container.Controls.Clear();
=======
            panel_Container.Controls.Clear(); // Șterge orice control existent din panou
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
            panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addUserControl(UserControlContact userControl)
        {
            userControl.Dock = DockStyle.Fill;
<<<<<<< HEAD
            panel_Container.Controls.Clear();
=======
            panel_Container.Controls.Clear(); // Șterge orice control existent din panou
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
            panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addUserControl(UserControlCont userControl)
        {
            userControl.Dock = DockStyle.Fill;
<<<<<<< HEAD
            panel_Container.Controls.Clear();
=======
            panel_Container.Controls.Clear(); // Șterge orice control existent din panou
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
            panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_Acasa_Click(object sender, EventArgs e)
        {
            UserControlAll uc = new UserControlAll(emailAddress, nume_salon, nume_angajat);
            addUserControl(uc);
<<<<<<< HEAD
            CloseCosulMeuIfOpen();
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        }

        private void btn_Programari_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            UserControlProgramari uc = new UserControlProgramari(emailAddress);
            addUserControl(uc);
            CloseCosulMeuIfOpen();
=======
            UserControlProgramari uc = new UserControlProgramari();
            addUserControl(uc);
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            UserControlContact uc = new UserControlContact();
            addUserControl(uc);
<<<<<<< HEAD
            CloseCosulMeuIfOpen();
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        }

        private void btn_Cont_Click(object sender, EventArgs e)
        {
            UserControlCont uc = new UserControlCont(emailAddress);
            addUserControl(uc);
<<<<<<< HEAD
            CloseCosulMeuIfOpen();
        }

        public UserControlAcasa GetUserControlAcasa()
        {
            foreach (Control control in panel_Container.Controls)
            {
                if (control is UserControlAcasa acasaControl)
                {
                    return acasaControl;
                }
            }
            return null;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (cosulMeuForm == null || cosulMeuForm.IsDisposed)
            {
                cosulMeuForm = new Cosul_meu(emailAddress);
                cosulMeuForm.FormClosed += CosulMeuForm_FormClosed;
                cosulMeuForm.Show();
            }
            else
            {
                cosulMeuForm.BringToFront();
            }
        }

        private void btnDeconect_Click_1(object sender, EventArgs e)
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

        private void CloseCosulMeuIfOpen()
        {
            if (cosulMeuForm != null && !cosulMeuForm.IsDisposed)
            {
                cosulMeuForm.Close();
                cosulMeuForm = null;
            }
        }

        private void CosulMeuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cosulMeuForm = null;
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        }
    }
}
