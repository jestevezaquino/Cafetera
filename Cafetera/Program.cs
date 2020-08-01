using System;
using System.Threading.Tasks;
using Cafetera;
using Cafetera.Class;

namespace Cafetera
{
    class Program
    {
        static Cafetera.Class.Cafetera cafetera;
        static Vaso vasosPequenos;
        static Vaso vasosMedianos;
        static Vaso vasosGrandes;
        static Azucarero azucarero;
        static MaquinaDeCafe maquinaDeCafe;

        static int Cup;
        static int Sugar;
        static int Amount;
        static bool Ruler;

        static async Task Main(string[] args)
        {
            cafetera = new Cafetera.Class.Cafetera(100);
            vasosPequenos = new Vaso(25, 3);
            vasosMedianos = new Vaso(20, 5);
            vasosGrandes = new Vaso(15, 7);
            azucarero = new Azucarero(30);
            maquinaDeCafe = new MaquinaDeCafe();
            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasosPequenos(vasosPequenos);
            maquinaDeCafe.setVasosMedianos(vasosMedianos);
            maquinaDeCafe.setVasosGrandes(vasosGrandes);
            maquinaDeCafe.setAzucarero(azucarero);

            Ruler = true;

            Console.WriteLine("Bienvenido a la Cafetera preferida de los Domininicanos en este tiempo de cuarentena...");

            Console.WriteLine("Especifique la cantidad de Vasos que desea ordenar: ");
            Amount = InputValidation("amount");

            Console.WriteLine("Por favor especifique los cubos de azucar que desea agregar a su café: ");
            Sugar = InputValidation("sugar");

            // Simula una pequeña espera
            await Task.Delay(1000);

            while (Ruler)
            {
                Console.WriteLine("Ofrecemos: Vasos Pequenos (3 Oz), Vasos Medianos (5 Oz) y Vasos grandes (7 Oz). " +
               "Por favor seleccione una de las siguientes opciones:");
                Console.WriteLine("(1) Pequeno --- (2) Mediano --- (3) Grande");

                Cup = InputValidation("cup");

                if(Cup == 1 || Cup == 2 || Cup == 3)
                {
                    Ruler = false;
                }
                else
                {
                    Console.WriteLine("Debe seleccionar una de las opciones antes presentadas. Inténtelo de nuevo.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            // Simula una pequeña espera
            Console.WriteLine("Por favor espere un momento a lo que preparamos su pedido......");
            await Task.Delay(Amount*500);

            string result = PrepareCup(Cup, Amount, Sugar);
            if(result == "Felicitaciones")
            {
                Console.WriteLine($"Aquí tiene su pedido: ({Amount} vasos de cafes con {Sugar} cubos de azucar). " + "{0}", "Gracias por su compra, pase feliz resto del día! :)");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Lo sentimos, {result}");
                Console.ReadKey();
            }
        }

        private static int InputValidation(string subject)
        {

            if(subject == "amount" || subject == "cup" || subject == "sugar")
            {
                inicio:
                if (int.TryParse(Console.ReadLine(),out int valor))
                {
                    return valor;
                }
                Console.WriteLine("Debe introducir valores numericos, inténtelo de nuevo.");
                goto inicio;
            }
            return 0;
        }

        private static string PrepareCup(int cupType, int amount, int sugar)
        {
            switch (cupType)
            {
                case 1:
                    return maquinaDeCafe.getVasoDeCafe(vasosPequenos, amount, amount * sugar);
                case 2:
                    return maquinaDeCafe.getVasoDeCafe(vasosMedianos, amount, amount * sugar);
                case 3:
                    return maquinaDeCafe.getVasoDeCafe(vasosGrandes, amount, amount * sugar);
                default:
                    return null;
            }
        }
    }
}
