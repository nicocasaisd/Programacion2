using System;
using C2_ExplicacionClaseEstatica;

/*
Ejercicio I01 - Validador de rangos
Consigna
Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)
 */

namespace C2_Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de agregar dependencia para usar clase de otro namespace
            Console.WriteLine(C2_ExplicacionClaseEstatica.ClaseEstatica.ImprimirNombre());

            int maximo = 0;
            int minimo = 0;
            int rangoMinimo = -100;
            int rangoMaximo = 100;
            float promedio;
            int acumulador = 0;
            int numero;
            string numeroIngresado;
            bool validacion;
            int veces = 5;


            for (int i = 0; i < veces; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroIngresado = Console.ReadLine();
                validacion = int.TryParse(numeroIngresado, out numero);
                // Validacion que sea numero
                while (!validacion)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número! :");
                    numeroIngresado = Console.ReadLine();
                    validacion = int.TryParse(numeroIngresado, out numero);
                }
                // Validacion de rango con CLASE
                while (!Validador.Validar(numero, rangoMinimo, rangoMaximo))
                {
                    Console.WriteLine("NUMERO FUERO DE RANGO. ¡Reingresar número! :");
                    numeroIngresado = Console.ReadLine();
                    validacion = int.TryParse(numeroIngresado, out numero);
                }

                if (i == 0)
                {
                    minimo = numero;
                    maximo = numero;
                }
                else
                {
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    else if (numero > maximo)
                    {
                        maximo = numero;
                    }
                }

                acumulador += numero;

            }

            // Calculos
            promedio = (float)acumulador / veces;

            // Muestro los datos
            Console.Clear();
            Console.WriteLine("El minimo es: {0}", minimo);
            Console.WriteLine("El maximo es: {0}", maximo);
            Console.WriteLine("El promedio es: {0}", promedio);
        }

        
    }
}
