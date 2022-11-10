﻿using System;
using System.Collections.Generic;
using static System.Environment;

namespace Consola
{
    class Program
    {
        public delegate int DelegadoComparacion(string primerTexto, string segundoTexto);

        static void Main(string[] args)
        {
            // Borrar o agregar la primera barra para switchear entre las pruebas fijas y el ingreso de texto por consola. 
            //*
            string primerTexto = "Vive como si fueras a morir mañana; aprende como si el mundo fuera a durar para siempre.";
            // Cant. caracteres: 88, Cant. palabras: 17 , Cant. vocales: 34, Cant. signos puntuación: 2 
            string segundoTexto = "La vida es como montar en bicicleta; para mantener el equilibrio debes seguir moviéndote.";
            //string segundoTexto = "La vida es como montar en bicicleta; para mantener el equilibrio debes seguir moviéndno..";
            // Cant. caracteres: 89, Cant. palabras: 14, Cant. vocales: 35, Cant. signos puntuación: 2

            /*/
            Console.WriteLine("Ingrese el primer texto:");
            string primerTexto = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo texto:");
            string segundoTexto = Console.ReadLine();
            //*/


            Console.WriteLine($"{NewLine}1era Comparación - Texto con más caracteres:");
            // Punto 2
            Console.WriteLine($"Texto1: {primerTexto.Length}, Texto2: {segundoTexto.Length}");
            Comparar(primerTexto, segundoTexto, (s1, s2) => { return s1.Length - s2.Length; });

            Console.WriteLine($"{NewLine}2da Comparación - Texto con más palabras:");
            // Punto 3
            Console.WriteLine($"Texto1: {primerTexto.Split(' ').Length}, Texto2: {segundoTexto.Split(' ').Length}");
            Comparar(primerTexto, segundoTexto, (s1, s2) => { return s1.Split(' ').Length - s2.Split(' ').Length; });

            Console.WriteLine($"{NewLine}3era Comparación - Texto con más vocales:");
            // Punto 4
            Console.WriteLine($"Texto1: {ContarVocales(primerTexto)}, Texto2: {ContarVocales(segundoTexto)}");
            Comparar(primerTexto, segundoTexto, (s1, s2) => { return ContarVocales(s1) - ContarVocales(s2); });

            Console.WriteLine($"{NewLine}4ta Comparación - Texto con más signos de puntuación:");
            // Punto 5
            Console.WriteLine($"Texto1: {ContarSignosPuntuacion(primerTexto)}, Texto2: {ContarSignosPuntuacion(segundoTexto)}");
            Comparar(primerTexto, segundoTexto, (s1, s2) => { return ContarSignosPuntuacion(s1) - ContarSignosPuntuacion(s2); });

        }

        public static int ContarVocales(string texto)
        {
            List<char> vocales = new List<char>()
            {
                'a', 'á', 'A', 'Á', 'e', 'é', 'E', 'É',
                'i', 'í', 'I', 'Í', 'o', 'ó', 'O', 'Ó',
                'u', 'ú', 'U', 'Ú'
            };

            return ContarCaracteres(texto, vocales);
        }

        public static int ContarSignosPuntuacion(string texto)
        {
            List<char> signosPuntuacion = new List<char>()
            {
                '.', ';', ','
            };

            return ContarCaracteres(texto, signosPuntuacion);
        }

        public static int ContarCaracteres(string texto, List<char> caracteres)
        {
            int cantidadCaracteres = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    cantidadCaracteres++;
                }
            }

            return cantidadCaracteres;
        }

        public static void Comparar(string texto1, string texto2, Func<string,string,int> delegado)
        {
            int resultado = delegado.Invoke(texto1, texto2);

            if (resultado > 0)
            {
                Console.WriteLine("El primer texto es MAYOR al segundo");
            }
            else if(resultado < 0)
            {
                Console.WriteLine("El primer texto es MENOR al segundo");
            }
            else
            {
                Console.WriteLine("Los textos son IGUALES");
            }
        }
    }
}
