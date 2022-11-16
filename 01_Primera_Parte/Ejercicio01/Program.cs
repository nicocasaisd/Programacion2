using System;

namespace C1_Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int numeroUno = 2;
            bool estado = true;
            double doble = 20;
            string palabra = "pepe";

            // declarar un array
            int[] numeros = new int[3]; // pido en memoria 3 espacios

            numeroUno = (int) doble;
            //numeroUno = int.Parse(palabra);
            //doble = int.Parse(palabra);

            */
            /*
            foreach(char item in palabra)
            {
                Console.WriteLine(item);
                //break;

            }

            for(int i=0; i < palabra.Length; i++)
            {
                Console.WriteLine(palabra[i]);
            }
            */


            /*
            while()
            {


            }

            do
            {

            }
            while ();
            */

            /*
            //Console.Write("Ingrese: "); // funciona igual pero sin \n
            Console.WriteLine("Ingresar un numero:"); // imprimo
            palabra = Console.ReadLine(); // levanto un dato

            Console.WriteLine($"La palabra es: {palabra}"); // imprimar mascara

            




            Console.ReadKey();
            //Console.WriteLine("Hello World!");
            */

            int maximo=0;
            int minimo=0;
            float promedio;
            int acumulador=0;
            int numero;

            
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    minimo = numero;
                    maximo = numero;
                }
                else
                {
                    if(numero < minimo)
                    {
                        minimo = numero;
                    }
                    else if(numero > maximo)
                    {
                        maximo = numero;
                    }
                }

                acumulador += numero;
                
            }

            // Calculos
            promedio = (float)acumulador / 5;

            // Muestro los datos
            Console.WriteLine("El minimo es: {0}", minimo);
            Console.WriteLine("El maximo es: {0}", maximo);
            Console.WriteLine("El promedio es: {0}", promedio);
        }
    }
}
