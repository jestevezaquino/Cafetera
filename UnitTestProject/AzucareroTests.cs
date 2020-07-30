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

        private Azucarero az = new Azucarero(10);

        [TestMethod()]


        public void hasAzucarTest()
        {
            az.hasAzucar(5);

            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void hasNoAzucarTest()
        {
          
            az.hasAzucar(15);

            Assert.IsFalse(false);

        }

        [TestMethod()]
        public void takeAzucarTest()
        {

            az.giveAzucar(5);
            Assert.AreEqual(5, az.getCantidadDeAzucar());

            az.giveAzucar(2);
            Assert.AreEqual(3, az.getCantidadDeAzucar());

        }

    }
}