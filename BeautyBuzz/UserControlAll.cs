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
<<<<<<< HEAD

        public string SelectedCity { get; private set; }

=======
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        public UserControlAll(string emailAddress, string nume_salon, string nume_angajat)
        {
            InitializeComponent();
            this.emailAddress = emailAddress;
            this.nume_salon = nume_salon;
            this.nume_angajat = nume_angajat;
<<<<<<< HEAD
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = comboBox1.SelectedItem?.ToString();
            SelectedCity = selectedCity; // Actualizăm SelectedCity în acest control

            // Transmitem valoarea către UserControlAcasa
            Menu menuForm = ParentForm as Menu;
            if (menuForm != null)
            {
                UserControlAcasa acasaControl = menuForm.GetUserControlAcasa();
                if (acasaControl != null)
                {
                    acasaControl.SelectedCity = selectedCity; // Setăm SelectedCity în UserControlAcasa
                    acasaControl.PopulateComboBoxOrase(); // Actualizăm conținutul combobox-ului în UserControlAcasa
                }
            }
        }


=======
        }

        private void label_Masaj_Click(object sender, EventArgs e)
        {


        }

>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menuForm = this.ParentForm as Menu;
            if (menuForm != null)
            {
<<<<<<< HEAD
                string tableName = "ANGAJATI";
                OpenUserControlAcasa(tableName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu menuForm = this.ParentForm as Menu;
            if (menuForm != null)
            {
                string tableName = "ANGAJATIFrizerie";
                OpenUserControlAcasa(tableName);
            }
        }

        private void OpenUserControlAcasa(string tableName)
        {
            string selectedCity = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCity))
            {
                // Dacă nu este selectat niciun oraș, trimiteți null ca și oraș selectat
                UserControlAcasa uc = new UserControlAcasa(emailAddress, nume_salon, nume_angajat, tableName, null);
                Menu menuForm = this.ParentForm as Menu;
                if (menuForm != null)
                {
                    menuForm.addUserControl(uc);
                }
            }
            else
            {
                // Dacă este selectat un oraș, trimiteți orașul selectat
                UserControlAcasa uc = new UserControlAcasa(emailAddress, nume_salon, nume_angajat, tableName, selectedCity);
                Menu menuForm = this.ParentForm as Menu;
                if (menuForm != null)
                {
                    menuForm.addUserControl(uc);
                }
            }
=======
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

>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
        }

        private void UserControlAll_Load(object sender, EventArgs e)
        {
            guna2TextBox1.ReadOnly = true;
<<<<<<< HEAD
            guna2TextBox2.ReadOnly = true;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "Alba Iulia", "Alexandria", "Arad", "Arges", "Azuga", "Baicoi", "Bacau", "Baia Mare", "Bistrita", "Botosani", "Braila", "Brasov", "Bucuresti", "Buzau", "Budeasa", "Calarasi", "Cluj-Napoca", "Constanta", "Craiova", "Curtea de Arges", "Deva", "Drobeta -Turnu Severin", "Fagaras", "Focsani", "Galati", "Giurgiu", "Hunedoara", "Iasi", "Lugoj", "Miercurea Ciuc", "Medgidia", "Medias", "Oradea", "Piatra Neamt", "Pitesti", "Ploiesti", "Ramnicu Valcea", "Resita", "Satu Mare", "Sfantu Gheorghe", "Sibiu", "Slatina", "Sighisoara", "Slobozia", "Suceava", "Targoviste", "Targu Jiu", "Targu Mures", "Timisoara", "Tulcea", "Tecuci", "Vaslui", "Valenii de Munte", "Zalau", "Zarnesti" });
            comboBox1.DropDownWidth = CalculateDropDownWidth(comboBox1);
        }

        private int CalculateDropDownWidth(ComboBox comboBox)
        {
            int maxWidth = 0;
            foreach (var item in comboBox.Items)
            {
                int itemWidth = TextRenderer.MeasureText(item.ToString(), comboBox.Font).Width;
                maxWidth = Math.Max(maxWidth, itemWidth);
            }
            return maxWidth;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu menuForm = this.ParentForm as Menu;
            if (menuForm != null)
            {
                string tableName = "ANGAJATITatto"; // Setarea numelui tabelului
                OpenUserControlAcasa(tableName);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menu menuForm = this.ParentForm as Menu;
            if (menuForm != null)
            {
                string tableName = "ANGAJATIEpilare"; // Setarea numelui tabelului
                OpenUserControlAcasa(tableName);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Menu menuForm = this.ParentForm as Menu;
            if (menuForm != null)
            {
                string tableName = "ANGAJATIManichiura"; // Setarea numelui tabelului
                OpenUserControlAcasa(tableName);
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Menu menuForm = this.ParentForm as Menu;
            if (menuForm != null)
            {
                string tableName = "ANGAJATIOthers"; // Setarea numelui tabelului
                OpenUserControlAcasa(tableName);
            }
        }
=======
        }

      
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
    }
}
