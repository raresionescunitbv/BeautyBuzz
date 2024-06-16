using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
<<<<<<< HEAD
using System.Net.Mail;
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyBuzz
{
    public partial class UserControlContact : UserControl
    {
        public UserControlContact()
        {
            InitializeComponent();
<<<<<<< HEAD
            UserControlContactTop uc = new UserControlContactTop();
            addUserControl(uc);
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelControl2.Controls.Clear(); // Șterge orice control existent din panou
            panelControl2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void UserControlContact_Load(object sender, EventArgs e)
        {

        }

        public void btn_control_echipa_Click(object sender, EventArgs e)
        {
            UserControlContactTop uc = new UserControlContactTop();
            addUserControl(uc);
        }

        public void btn_control_detalii_Click(object sender, EventArgs e)
        {
            UserControlContactBottom uc = new UserControlContactBottom();
            addUserControl(uc);
=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        }
    }
}
