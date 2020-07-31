using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cafetera;
using Cafetera.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeteraTests.Class
{
    [TestClass()]
    public class MaquinaDeCafeTests
    {
        Cafetera.Class.Cafetera cafetera;
        Vaso vasosPequenos;
        Vaso vasosMedianos;
        Vaso vasosGrandes;
        Azucarero azucarero;
        MaquinaDeCafe maquinaDeCafe;

        public MaquinaDeCafeTests()
        {
            cafetera = new Cafetera.Class.Cafetera(50);
            vasosPequenos = new Vaso(5, 10);
            vasosMedianos = new Vaso(5, 20);
            vasosGrandes = new Vaso(5, 30);
            azucarero = new Azucarero(20);
            maquinaDeCafe = new MaquinaDeCafe();
            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasosPequenos(vasosPequenos);
            maquinaDeCafe.setVasosMedianos(vasosMedianos);
            maquinaDeCafe.setVasosGrandes(vasosGrandes);
            maquinaDeCafe.setAzucarero(azucarero);
        }

        [TestMethod()]
        public void deberiaDevolverUnVasoPequeno()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            Assert.AreEqual(maquinaDeCafe.getVasosPequenos(), vaso);
        }

        [TestMethod()]
        public void deberiaDevolverUnVasoMediano()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("mediano");
            Assert.AreEqual(maquinaDeCafe.getVasosMedianos(), vaso);
        }

        [TestMethod()]
        public void deberiaDevolverUnVasoGrande()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("grande");
            Assert.AreEqual(maquinaDeCafe.getVasosGrandes(), vaso);
        }

        [TestMethod()]
        public void deberiaDevolverNoHayVasos()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 10, 2);
            Assert.AreEqual("No hay Vasos", resultado);
        }

        [TestMethod()]
        public void deberiaDevolverNoHayCafe()
        {
            Cafetera.Class.Cafetera cafetera = new Cafetera.Class.Cafetera(5);
            maquinaDeCafe.setCafetera(cafetera);
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 2);
            Assert.AreEqual("No hay Cafe", resultado);
        }

        [TestMethod()]
        public void deberiaDevolverNoHayAzucar()
        {
            azucarero = new Azucarero(2);
            maquinaDeCafe.setAzucarero(azucarero);
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            Assert.AreEqual("No hay Azucar", resultado);
        }

        [TestMethod()]
        public void deberiaRestarCafe()
        {
            maquinaDeCafe.setCafetera(cafetera);
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso,1,3);
            int resultado = maquinaDeCafe.getCafetera().getCantidadCafe();
            Assert.AreEqual(40, resultado);
        }

        [TestMethod()]
        public void deberiaRestarVaso()
        {
            
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            int resultado = maquinaDeCafe.getVasosPequenos().getCantidadVasos();
            Assert.AreEqual(4, resultado);
        }

        [TestMethod()]
        public void deberiaRestarAzucar()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            int resultado = maquinaDeCafe.getAzucarero().getCantidadDeAzucar();
            Assert.AreEqual(17, resultado);
        }

        [TestMethod()]
        public void deberiaDevolverFelicitaciones()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            Assert.AreEqual("Felicitaciones", resultado);
        }
    }

}
