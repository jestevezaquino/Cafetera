using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafetera.Class.Tests
{
    [TestClass()]
    public class VasoTests
    {
        [TestMethod()]
        public void deberiaDevolverVerdaderoSiExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(2,10);
            bool resultado= vasosPequenos.hasVasos(1);
            Assert.AreEqual(true,resultado);
        }
        [TestMethod()]
        public void deberiaDevolverFalsosSiNoExistenVasos() {
            Vaso vasosPequenos = new Vaso(1, 10);
            bool resultado = vasosPequenos.hasVasos(2);
            Assert.AreEqual(false, resultado);
        }
        [TestMethod()]
        public void deberiaRestarCantidadVasos() {
            Vaso vasosPequenos = new Vaso(5, 10);
            vasosPequenos.giveVasos(1);
            Assert.AreEqual(4, vasosPequenos.cantidadVasos);
        }
    }
}