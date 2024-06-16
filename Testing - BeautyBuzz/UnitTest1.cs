using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Microsoft.Data.SqlClient; // Folosește Microsoft.Data.SqlClient dacă proiectul tău principal utilizează acest namespace
using System.Windows.Forms;
using BeautyBuzz; // Asigură-te că acest namespace este corect

namespace UnitTestProject_BeautyBuzz
{
    [TestClass]
    public class UnitTest_Login
    {
        private Mock<SqlConnection> mockConnection;
        private Mock<SqlCommand> mockCommand;
        private Mock<SqlDataReader> mockDataReader;
        private Mock<SingleTon> mockSingleTon;
        private BeautyBuzz.BeautyBuzz beautyBuzz;

        [TestInitialize]
        public void Setup()
        {
            mockConnection = new Mock<SqlConnection>();
            mockCommand = new Mock<SqlCommand>();
            mockDataReader = new Mock<SqlDataReader>();
            mockSingleTon = new Mock<SingleTon>();

            mockSingleTon.Setup(s => s.GetConnection()).Returns(mockConnection.Object);

            beautyBuzz = new BeautyBuzz.BeautyBuzz
            {
                
            };
        }

        [TestMethod]
        public void TestLogin_Success_Admin()
        {
            // Arrange
            beautyBuzz.Textbox1Value = "admin";
            beautyBuzz.Textbox2Value = "password";

            mockCommand.Setup(cmd => cmd.ExecuteScalar()).Returns(1);
            mockConnection.Setup(conn => conn.CreateCommand()).Returns(mockCommand.Object);
            mockSingleTon.Setup(s => s.GetConnection()).Returns(mockConnection.Object);

            // Act
            beautyBuzz.button1_Click_1(null, EventArgs.Empty);

            // Assert
            mockCommand.Verify(cmd => cmd.ExecuteScalar(), Times.Once);
            // Verifică că AdminInterface a fost deschis (de exemplu, utilizând un flag sau similar)
        }

        [TestMethod]
        public void TestLogin_Failure()
        {
            // Arrange
            beautyBuzz.Textbox1Value = "nonexistentuser";
            beautyBuzz.Textbox2Value = "wrongpassword";

            mockCommand.SetupSequence(cmd => cmd.ExecuteScalar())
                       .Returns(0)  // Admin check
                       .Returns(0)  // Email check
                       .Returns(0); // Phone check
            mockConnection.Setup(conn => conn.CreateCommand()).Returns(mockCommand.Object);
            mockSingleTon.Setup(s => s.GetConnection()).Returns(mockConnection.Object);

            // Act
            beautyBuzz.button1_Click_1(null, EventArgs.Empty);

            // Assert
            mockCommand.Verify(cmd => cmd.ExecuteScalar(), Times.Exactly(3));
            // Verifică că mesajul de eroare a fost afișat (de exemplu, utilizând un flag sau similar)
        }
    }
}
