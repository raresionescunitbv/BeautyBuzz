using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TestProject1
{
    [TestClass]
    public class AngajatiOthersAdminTests
    {
        [TestMethod]
        public void TestButton1Click_UpdateDataInDataGridView()
        {
            // Arrange
            var angajatiOthersAdmin = new BeautyBuzz.AngajatiOthersAdmin();
            var dataGridView = new DataGridView();
            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("Nume_Salon", "Nume Salon");
            dataGridView.Columns.Add("Nume_Angajat", "Nume Angajat");
            dataGridView.Columns.Add("Prenume_Angajat", "Prenume Angajat");
            dataGridView.Columns.Add("Nr_Telefon", "Nr Telefon");
            dataGridView.Columns.Add("Oras", "Oras");
            angajatiOthersAdmin.Controls.Add(dataGridView);

            // Simulăm un rând selectat în DataGridView
            dataGridView.Rows.Add("1", "Test Salon", "Test Angajat", "Test Prenume", "0123456789", "Test Oras");
            dataGridView.Rows[0].Selected = true;

            // Setăm valorile în TextBox-urile corespunzătoare din AngajatiOthersAdmin
            SetTextBoxValues(angajatiOthersAdmin, "1", "Test Salon", "Test Angajat", "Test Prenume", "0123456789", "Test Oras");

            // Act
            angajatiOthersAdmin.button1_Click(null, EventArgs.Empty);

            // Assert
            // Verificăm dacă valorile au fost actualizate corect în DataGridView
            Assert.AreEqual("Test Salon", dataGridView.Rows[0].Cells["Nume_Salon"].Value.ToString());
            Assert.AreEqual("Test Angajat", dataGridView.Rows[0].Cells["Nume_Angajat"].Value.ToString());
            Assert.AreEqual("Test Prenume", dataGridView.Rows[0].Cells["Prenume_Angajat"].Value.ToString());
            Assert.AreEqual("0123456789", dataGridView.Rows[0].Cells["Nr_Telefon"].Value.ToString());
            Assert.AreEqual("Test Oras", dataGridView.Rows[0].Cells["Oras"].Value.ToString());
        }

        private void SetTextBoxValues(BeautyBuzz.AngajatiOthersAdmin angajatiOthersAdmin, string id, string numeSalon, string numeAngajat, string prenumeAngajat, string nrTelefon, string oras)
        {
            angajatiOthersAdmin.Controls.Add(new TextBox { Name = "textBox1", Text = id });
            angajatiOthersAdmin.Controls.Add(new TextBox { Name = "textBox2", Text = numeSalon });
            angajatiOthersAdmin.Controls.Add(new TextBox { Name = "textBox3", Text = numeAngajat });
            angajatiOthersAdmin.Controls.Add(new TextBox { Name = "textBox4", Text = prenumeAngajat });
            angajatiOthersAdmin.Controls.Add(new TextBox { Name = "textBox5", Text = nrTelefon });
            angajatiOthersAdmin.Controls.Add(new TextBox { Name = "textBox6", Text = oras });
        }
    }
}
