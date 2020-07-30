using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Cafetera
{
    public class Azucarero
    {
        int CantidadDeAzucar { get; set; }

        public Azucarero(int cantidad)
        {
            setCantidadDeAzucar(cantidad);

        }

        public void setCantidadDeAzucar(int cantidad)
        {
            CantidadDeAzucar = cantidad;
        }

        public int getCantidadDeAzucar()
        {
            return CantidadDeAzucar;

        }

        public bool hasAzucar(int cantidad)
        {

            if (getCantidadDeAzucar() >= cantidad)
            {
                return true;
            } else
            {
                return false;

            }

        }

        public int giveAzucar(int cantidad)
        {
            CantidadDeAzucar = getCantidadDeAzucar() - cantidad;
            return CantidadDeAzucar;

        }

 
    }
}
