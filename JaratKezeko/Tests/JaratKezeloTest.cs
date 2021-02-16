using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace JaratKezeko.Tests
{
    [TestFixture]
    class JaratKezeloTest
    {
        [TestCase]
        public void UjJarat() 
        {
            JaratKezelo j = new JaratKezelo();
            j.UjJarat("azon123", "Ferihegy", "Alicantei",new DateTime(2021, 2, 3, 16, 5, 7, 00));
            Assert.AreEqual((2021-2-3-16-5-7-00),j.MikorIndul("azon123"));
           
        }

        [TestCase]
        public void KesesFelvesz()
        {
            JaratKezelo j = new JaratKezelo();
            j.UjJarat("azon123", "Ferihegy", "Alicantei", new DateTime(2021, 2, 3, 16, 5, 7, 00));
            j.Keses("azon123", 10);
            Assert.AreEqual(10,j.MikorIndul("azon123"));
        }

        [TestCase]

        public void InduloRepter() 
        {
            JaratKezelo j = new JaratKezelo();
            j.UjJarat("azon123", "Ferihegy", "Alicantei", new DateTime(2021, 2, 3, 16, 5, 7, 00));
            j.jaratokRepuloterrol("Ferihegy");
            Assert.AreEqual("Ferihegy",j.jaratokRepuloterrol("Ferihegy"));

        }
    }
}
