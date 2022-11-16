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

            // Ordeno de forma creciente
            lista.Sort();
            // Muestro
            Console.WriteLine("Lista ordenada de forma creciente.");
            foreach (int i in lista)
            {
                Console.WriteLine($"Elemento: {i}");
            }

            // COLA Y PILA
            Queue<int> colaPositivos = new Queue<int>();
            Stack<int> pilaNegativos = new Stack<int>();

            // Separo positivos y negativos
            foreach(int i in lista)
            {
                if(i > 0)
                { 
                    colaPositivos.Enqueue(i); // envio a la cola de positivos
                }
                else if(i != 0)
                {
                    pilaNegativos.Push(i);
                }
            }
            // Muestro la cola
            Console.WriteLine("Elementos de la Cola de Positivos.");
            foreach(int i in colaPositivos)
            {
                Console.WriteLine($"Elemento de la cola: {i}");
            }
            // Muestro la pila
            Console.WriteLine("Elementos de la Pila de Negativos.");
            foreach (int i in pilaNegativos)
            {
                Console.WriteLine($"Elemento de la pila: {i}");
            }
        }
    }
}
