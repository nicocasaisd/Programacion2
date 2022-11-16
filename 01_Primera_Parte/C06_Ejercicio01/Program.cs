using System;
using System.Security.Cryptography.X509Certificates;

namespace C06_Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creo un array de 20 enteros
            int[] array = new int[20];

            // Cargo con Random
            Random random = new Random();
            for(int i=0; i < array.Length; i++)
            {
                array[i] = random.Next(-20, 20);
            }
            // Muestro
            Console.WriteLine("Array original.");
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine($"Elemento {i}: {array[i]}");
            }

            // Ordeno de forma creciente usando Array.Sort()
            Array.Sort(array);
            // Muestro
            Console.WriteLine("Array ordenado de forma creciente.");
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine($"Elemento {i}: {array[i]}");
            }

            // Ordeno de forma decreciente usando Array.Sort()
            Array.Sort(array, OrdenDescendente);
            // Muestro
            Console.WriteLine("Array ordenado de forma creciente.");
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine($"Elemento {i}: {array[i]}");
            }



            // Interfaz Ordenador
            static int OrdenDescendente(int n1, int n2)
            {
                return n2 - n1;
            }
        }
    }
}
