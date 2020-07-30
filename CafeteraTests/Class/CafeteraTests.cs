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
        public void deberiaDevolverVerdaderoSiExisteCafe() {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.hasCafe(5);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod()]
        public void deberiaDevolverFalsoSiExisteCafe() {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.hasCafe(11);
            Assert.AreEqual(false, resultado);
        }

        [TestMethod()]
        public void deberiaRestarCafeALaCafetera() {
            Cafetera cafetera = new Cafetera(10);
            cafetera.giveCafe(7);
            Assert.AreEqual(3, cafetera.getCantidadCafe());
        }
    }
}