using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyBuzz
{
    public partial class AdminInterface : Form
    {
        
        public AdminInterface()
        {
            InitializeComponent();
        }

        private void AdminInterface_Load(object sender, EventArgs e)
        {
            AdminMain adminMainControl = new AdminMain();
            this.Controls.Add(adminMainControl);
            adminMainControl.Dock = DockStyle.Fill;
            adminMainControl.BringToFront();
        }
    }
}
