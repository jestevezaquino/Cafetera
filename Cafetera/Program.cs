using System;
using Cafetera;

namespace Cafetera
{
    class Program
    {
        static void Main(string[] args)
        {
            Azucarero az = new Azucarero(100);
            az.setCantidadDeAzucar(10);
        }
    }
}
