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

namespace BeautyBuzz
{
    public partial class Menu : Form
    {
        private string emailAddress;
        private string nume_salon;
        private string nume_angajat;
        public Menu(string emailAddress, string nume_salon, string nume_angajat)
        {
            InitializeComponent();
            UserControlAll uc = new UserControlAll(emailAddress, nume_salon, nume_angajat);
            addUserControl(uc);
            this.emailAddress = emailAddress;
            this.nume_salon = nume_salon;
            this.nume_angajat = nume_angajat;
        }

        public void addUserControl(UserControlAll userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Container.Controls.Clear(); // Șterge orice control existent din panou
            panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public void addUserControl(UserControlAcasa userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Container.Controls.Clear(); // Șterge orice control existent din panou
            panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addUserControl(UserControlProgramari userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Container.Controls.Clear(); // Șterge orice control existent din panou
            panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addUserControl(UserControlContact userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Container.Controls.Clear(); // Șterge orice control existent din panou
            panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addUserControl(UserControlCont userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_Container.Controls.Clear(); // Șterge orice control existent din panou
            panel_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_Acasa_Click(object sender, EventArgs e)
        {
            UserControlAll uc = new UserControlAll(emailAddress, nume_salon, nume_angajat);
            addUserControl(uc);
        }

        private void btn_Programari_Click(object sender, EventArgs e)
        {
            UserControlProgramari uc = new UserControlProgramari();
            addUserControl(uc);
        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            UserControlContact uc = new UserControlContact();
            addUserControl(uc);
        }

        private void btn_Cont_Click(object sender, EventArgs e)
        {
            UserControlCont uc = new UserControlCont(emailAddress);
            addUserControl(uc);
        }
    }
}
