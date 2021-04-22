using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopment;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Dvanact_Delitele_Vraci12346()
        {
            // Arrange
            string r = string.Empty;

            // Act
            r = Delitelnost.VypisDelitele(12);

            // Assert
            Assert.AreEqual(r, "12346");
        }

        [TestMethod]
        public void Jedna_Delitele_VraciPrazdne()
        {
            string r = string.Empty;

            r = Delitelnost.VypisDelitele(1);

            Assert.AreEqual(r, string.Empty);
        }

        [TestMethod]
        public void Sedmnast_Delitele_Vraci1()
        {
            string r = string.Empty;

            r = Delitelnost.VypisDelitele(17);

            Assert.AreEqual(r, "1");
        }

        [TestMethod]
        public void Minus1_Delitele_VraciPrazdne()
        {
            string r = string.Empty;

            r = Delitelnost.VypisDelitele(-1);

            Assert.AreEqual(r, string.Empty);
        }
    }
}
