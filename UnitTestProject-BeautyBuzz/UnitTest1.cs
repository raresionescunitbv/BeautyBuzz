using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data;
using System.Data.SqlClient;
using UnitTestProject_BeautyBuzz;
using System;

namespace UnitTestProject_BeautyBuzz
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<SqlConnection> mockConnection;
        private Mock<SqlDataAdapter> mockDataAdapter;
        private Mock<DataTable> mockDataTable;
        private Programari programari;

        [TestInitialize]
        public void Setup()
        {
            mockConnection = new Mock<SqlConnection>();
            mockDataAdapter = new Mock<SqlDataAdapter>();
            mockDataTable = new Mock<DataTable>();
            programari = new Programari();

            // Inject mock objects into the class being tested
         
        }

        [TestMethod]
        public void InitializeDataGridView_LoadsDataCorrectly()
        {
            // Arrange
            mockDataAdapter.Setup(d => d.Fill(It.IsAny<DataTable>())).Callback<DataTable>(dt =>
            {
                dt.Columns.Add("Mail");
                dt.Columns.Add("Nume_Salon");
                dt.Columns.Add("Nume_Angajat");
                dt.Columns.Add("Data");
                dt.Columns.Add("Ora");
                dt.Rows.Add("test@example.com", "Salon Test", "Angajat Test", "2023-01-01", "12:00");
            });

            // Act
            programari.InitializeDataGridView();

            // Assert
            Assert.AreEqual(1, programari.DataTable.Rows.Count);
            Assert.AreEqual("test@example.com", programari.DataTable.Rows[0]["Mail"]);
        }

        [TestMethod]
        public void Button1_Click_UpdatesDatabaseAndGrid()
        {
            // Arrange
            string mail = "test@example.com";
            string numeSalon = "Updated Salon";
            string numeAngajat = "Updated Angajat";
            string data = "2023-02-01";
            string ora = "14:00";

            mockDataAdapter.Setup(d => d.Fill(It.IsAny<DataTable>())).Callback<DataTable>(dt =>
            {
                dt.Columns.Add("Mail");
                dt.Columns.Add("Nume_Salon");
                dt.Columns.Add("Nume_Angajat");
                dt.Columns.Add("Data");
                dt.Columns.Add("Ora");
                dt.Rows.Add(mail, "Salon Test", "Angajat Test", "2023-01-01", "12:00");
            });

            programari.InitializeDataGridView();

            programari.TextBox1.Text = mail;
            programari.TextBox2.Text = numeSalon;
            programari.TextBox3.Text = numeAngajat;
            programari.TextBox4.Text = data;
            programari.TextBox5.Text = ora;

            var selectedRow = programari.DataGridView1.Rows[0];
            selectedRow.Selected = true;

            var mockCommand = new Mock<SqlCommand>();
            mockCommand.Setup(cmd => cmd.ExecuteNonQuery()).Returns(1);

            mockConnection.Setup(con => con.CreateCommand()).Returns(mockCommand.Object);

            // Act
            programari.Button1_Click(this, EventArgs.Empty);

            // Assert
            mockCommand.Verify(cmd => cmd.ExecuteNonQuery(), Times.Once);
            Assert.AreEqual(numeSalon, selectedRow.Cells["Nume_Salon"].Value);
            Assert.AreEqual(numeAngajat, selectedRow.Cells["Nume_Angajat"].Value);
            Assert.AreEqual(data, selectedRow.Cells["Data"].Value);
            Assert.AreEqual(ora, selectedRow.Cells["Ora"].Value);
        }

        [TestMethod]
        public void Button3_Click_DeletesFromDatabaseAndGrid()
        {
            // Arrange
            string mail = "test@example.com";

            mockDataAdapter.Setup(d => d.Fill(It.IsAny<DataTable>())).Callback<DataTable>(dt =>
            {
                dt.Columns.Add("Mail");
                dt.Columns.Add("Nume_Salon");
                dt.Columns.Add("Nume_Angajat");
                dt.Columns.Add("Data");
                dt.Columns.Add("Ora");
                dt.Rows.Add(mail, "Salon Test", "Angajat Test", "2023-01-01", "12:00");
            });

            programari.InitializeDataGridView();

            var selectedRow = programari.DataGridView1.Rows[0];
            selectedRow.Selected = true;

            var mockCommand = new Mock<SqlCommand>();
            mockCommand.Setup(cmd => cmd.ExecuteNonQuery()).Returns(1);

            mockConnection.Setup(con => con.CreateCommand()).Returns(mockCommand.Object);

            // Act
            programari.Button3_Click(this, EventArgs.Empty);

            // Assert
            mockCommand.Verify(cmd => cmd.ExecuteNonQuery(), Times.Once);
            Assert.AreEqual(0, programari.DataGridView1.Rows.Count);
        }
    }
}
