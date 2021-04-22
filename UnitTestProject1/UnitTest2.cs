using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopment;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Dvanact_GetListDelitele_Vraci12346()
        {
            // Arrange
            List<int> l = new List<int>();
            l.AddRange(new int[] {1, 2, 3, 4, 6});

            List<int> r = new List<int>();

            // Act
            r = Delitelnost.GetListDelitele(12);

            // Assert
            Assert.AreEqual(l.Count, r.Count);

            for(int i = 0; i < l.Count; i++)
            {
                Assert.AreEqual(l[i], r[i]);
            }
        }

        [TestMethod]
        public void Jedna_GetListDelitele_VraciPrazdne()
        {
            // Arrange
            List<int> l = new List<int>();
            l.AddRange(new int[] {});

            List<int> r = new List<int>();

            // Act
            r = Delitelnost.GetListDelitele(1);

            // Assert
            Assert.AreEqual(l.Count, r.Count);

            for (int i = 0; i < l.Count; i++)
            {
                Assert.AreEqual(l[i], r[i]);
            }
        }
    }
}
