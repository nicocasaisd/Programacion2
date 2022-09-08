using Billetes;
using System;

namespace C04_Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Instancio unos pesitos
            Peso pesos = new Peso(1000);
            Console.WriteLine($"Pesos: {pesos.GetCantidad()}");

            // Los paso a dolares
            Dolar dolares = (Dolar)pesos;
            Console.WriteLine($"Dolares: {dolares.GetCantidad()}");

            // Los paso a euros
            Euro euros = (Euro)pesos;
            Console.WriteLine($"Euros: {euros.GetCantidad()}");


        }
    }
}
