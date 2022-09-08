using System;
using Entidades;

namespace TestBus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // La creación de esta instancia activa el constructor estático.
            Bus bus1 = new Bus(71);

            // Crea un segundo autobús.
            Bus bus2 = new Bus(72);


            bus1.Conducir();

            // Espera 25 milisegundos
            System.Threading.Thread.Sleep(25);


            bus2.Conducir();


            Console.ReadKey();
        }
    }
}
