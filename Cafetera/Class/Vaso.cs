using System;
using System.Collections.Generic;
using System.Text;

namespace Cafetera.Class
{
    public class Vaso
    {
        public int cantidadVasos { get; set; }
        public int contenido { get; set; }

        public Vaso(int cantidadVasos, int contenido) {
            this.contenido = contenido;
            this.cantidadVasos = cantidadVasos;
        }
        public bool hasVasos(int cantidadVasos) {
            if (cantidadVasos<=this.cantidadVasos)
            {
                return true;
            }
            return false;
        }
        public void giveVasos(int  cantidadVasos) {
            this.cantidadVasos -= cantidadVasos;
        }
    }
}
