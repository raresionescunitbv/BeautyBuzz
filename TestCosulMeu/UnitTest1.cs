using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeautyBuzz;

namespace TestCosulMeu
{
    [TestClass]
    public class CosulMeuTests
    {
        private Cosul_meu cosul;

        [TestInitialize]
        public void Setup()
        {
            // Inițializăm obiectul cosul cu o adresă de email de test
            cosul = new Cosul_meu("test@example.com");
        }

        [TestMethod]
        public void TestGetTotalFromLabel_WhenLabelContainsValidTotal_ReturnsCorrectTotal()
        {
            // Arrange
            decimal expectedTotal = 100.00M;
            // Setăm label2.Text pentru a simula o valoare validă a totalului
            cosul.label2.Text = "Total: 100.00 lei";

            // Act
            decimal actualTotal = cosul.GetTotalFromLabel();

            // Assert
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void TestGetTotalFromLabel_WhenLabelContainsInvalidTotal_ReturnsZero()
        {
            // Arrange
            decimal expectedTotal = 0.00M;
            // Setăm label2.Text cu o valoare invalidă pentru total
            cosul.label2.Text = "Total: invalid";

            // Act
            decimal actualTotal = cosul.GetTotalFromLabel();

            // Assert
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        // Continuați cu alte teste pentru celelalte metode din Cosul_meu...
    }
}
