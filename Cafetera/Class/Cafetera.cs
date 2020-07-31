using System;
using System.Collections.Generic;
using System.Text;

namespace Cafetera.Class
{
    public class Cafetera
    {
        int cantidadCafe { get; set; }

        public Cafetera(int cantidadCafe) 
        {
            setCantidadCafe(cantidadCafe);
        }

        public void setCantidadCafe(int cantidadCafe)
        {
            this.cantidadCafe = cantidadCafe;
        }

        public int getCantidadCafe()
        {
            return cantidadCafe;
        }

        public bool hasCafe(int cantidadCafe) 
        {
            if (cantidadCafe <= this.cantidadCafe)
            {
                return true;
            }
            return false;
        }

        public int giveCafe(int cantidadCafe)
        {
            if(hasCafe(cantidadCafe) == true) 
            {
                setCantidadCafe(this.cantidadCafe - cantidadCafe);
                return getCantidadCafe();
            }
            return 0;
        }
    }
}
