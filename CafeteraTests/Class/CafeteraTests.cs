using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cafetera.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafetera.Class.Tests
{
    [TestClass()]
    public class CafeteraTests
    {
        [TestMethod()]
        public void hayCafeTest() {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.hasCafe(5);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod()]
        public void noHayCafeTest() {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.hasCafe(11);
            Assert.AreEqual(false, resultado);
        }

        /** Evalua la cantidad de cafe restante despues de servir cafe**/
        [TestMethod()]
        public void cantidadCafeTest() {
            Cafetera cafetera = new Cafetera(10);
            cafetera.giveCafe(7);
            Assert.AreEqual(3, cafetera.getCantidadCafe());
        }
    }
}