using System;
using System.Collections.Generic;
using System.Text;

namespace Cafetera.Class
{
    public class MaquinaDeCafe
    {
        Cafetera cafe;
        Vaso vasosPequenos;
        Vaso vasosMedianos;
        Vaso vasosGrandes;
        Azucarero azucar;

        public string getVasoDeCafe(Vaso vaso, int cantidadDeVasos, int cantidadDeAzucar)
        {
            if(vaso.getCantidadVasos() >= cantidadDeVasos)
            {
                if(cafe.getCantidadCafe() >= vaso.getContenidoVaso())
                {
                    if(azucar.getCantidadDeAzucar() >= cantidadDeAzucar){
                        vaso.setCantidadVasos(vaso.getCantidadVasos() - cantidadDeVasos);
                        azucar.setCantidadDeAzucar(azucar.getCantidadDeAzucar() - cantidadDeAzucar);
                        cafe.setCantidadCafe(cafe.getCantidadCafe() - (vaso.getContenidoVaso() * cantidadDeVasos));

                        return "Felicitaciones";
                    }
                    return "No hay Azucar";
                }
                return "No hay Cafe";
            }
            return "No hay Vasos";
        }

        public Vaso getTipoVaso(string tipoDeVaso)
        {
            switch (tipoDeVaso)
            {
                case "pequeno":
                    return vasosPequenos;
                case "mediano":
                    return vasosMedianos;
                case "grande":
                    return vasosGrandes;
                default:
                    return null;
            }
        }

        public Cafetera getCafetera()
        {
            return this.cafe;
        }

        public void setCafetera(Cafetera cafetera)
        {
            cafe = cafetera;
        }

        public void setVasosPequenos(Vaso vasosPequenos)
        {
            this.vasosPequenos = vasosPequenos;
        }

        public Vaso getVasosPequenos()
        {
            return vasosPequenos;
        }

        public void setVasosMedianos(Vaso vasosMedianos)
        {
            this.vasosMedianos = vasosMedianos;
        }

        public Vaso getVasosMedianos()
        {
            return vasosMedianos;
        }

        public void setVasosGrandes(Vaso vasosGrandes)
        {
            this.vasosGrandes = vasosGrandes;
        }

        public Vaso getVasosGrandes()
        {
            return vasosGrandes;
        }

        public void setAzucarero(Azucarero azucarero) 
        {
            azucar = azucarero;
        }
        public Azucarero getAzucarero()
        {
            return this.azucar;
        }
    }
}
