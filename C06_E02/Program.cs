using System;
using System.Collections.Generic;

namespace C06_E02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LISTA

            // Creo la lista
            List<int> lista = new List<int>();
            // Cargo con Random
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                lista.Add(random.Next(-20, 20));
            }
            // Muestro
            Console.WriteLine("Array original.");
            foreach(int i in lista)
            {
                Console.WriteLine($"Elemento: {i}");
            }

        }
    }
}
