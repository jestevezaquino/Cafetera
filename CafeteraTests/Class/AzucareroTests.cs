using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cafetera;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafetera.Tests
{
    [TestClass()]
    public class AzucareroTests
    {

        Azucarero az = new Azucarero(10);

        [TestMethod()]
        public void hayAzucarTest()
        {
            az.hasAzucar(5);

            Assert.IsTrue(true);
        }


        [TestMethod()]
        public void noHayAzucarTest()
        {
            bool result = az.hasAzucar(15);

            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void tomarAzucar()
        {
            az.giveAzucar(5);

            Assert.AreEqual(5, az.getCantidadDeAzucar());

            az.giveAzucar(2);

            Assert.AreEqual(3, az.getCantidadDeAzucar());
        }
    }
}