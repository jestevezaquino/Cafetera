using System;
using System.Collections.Generic;
using System.Text;

namespace Cafetera.Class
{
    public class Vaso
    {
        int cantidadVasos { get; set; }
        int contenido { get; set; }

        public Vaso(int cantidadVasos, int contenido) {
            this.contenido = contenido;
            setCantidadVasos(cantidadVasos);
        }

        public int getContenidoVaso()
        {
            return contenido;
        }

        public void setContenidoVaso(int contenido)
        {
            this.contenido=contenido;
        }

        public void setCantidadVasos(int cantidadVasos)
        {
            this.cantidadVasos = cantidadVasos;
        }

        public int getCantidadVasos()
        {
            return this.cantidadVasos;
        }

        public bool hasVasos(int cantidadVasos) {
            if (cantidadVasos <= this.cantidadVasos)
            {
                return true;
            }
            return false;
        }

        public int giveVasos(int cantidadVasos) {
            if(hasVasos(cantidadVasos) == true)
            {
                setCantidadVasos(this.cantidadVasos - cantidadVasos);
                return getCantidadVasos();
            }
            return 0;
        }
    }
}
