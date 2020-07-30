using System;
using System.Collections.Generic;
using System.Text;

namespace Cafetera.Class
{
    public class Cafetera
    {
        public int cantidadCafe { get; set; }
        public Cafetera(int cantidadCafe) {
            this.cantidadCafe=cantidadCafe;
        }
        public bool hasCafe(int cantidadCafe) {
            if (cantidadCafe<=this.cantidadCafe)
            {
                return true;
            }
            return false;
        }
        public void giveCafe(int cantidadCafe) {
            this.cantidadCafe -= cantidadCafe;
        }
    }
}
