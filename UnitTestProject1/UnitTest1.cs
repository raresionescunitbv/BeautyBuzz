using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expectedResult = 15;

            // Act
            int result = a + b;

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
