using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeautyBuzz; // Asigurați-vă că ați importat corect namespace-ul din proiectul principal

namespace CosulMeuTests
{
    [TestClass]
    public class CosulMeuTests
    {
        // Declarați obiectul Cosul_meu care va fi testat
        private Cosul_meu cosul;

        [TestInitialize]
        public void Setup()
        {
            // Aici puteți inițializa obiectul cosul pentru teste
            // De exemplu, puteți să-i pasați o adresă de email de test
            cosul = new Cosul_meu("test@example.com");
        }

        [TestMethod]
        public void TestGetTotalFromLabel()
        {
            // Testați funcționalitatea metodei GetTotalFromLabel
            decimal expectedTotal = 100.00M; // Setați valoarea așteptată
            decimal actualTotal = cosul.GetTotalFromLabel(); // Obțineți valoarea reală
            Assert.AreEqual(expectedTotal, actualTotal); // Verificați dacă sunt egale
        }

        // Continuați cu alte teste pentru celelalte metode din Cosul_meu...
    }
}
