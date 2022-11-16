using C04_Entidades;
using System;

namespace C04_Ejercicio01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            int resultado;
            int cantidadSumas;

            resultado = (int)sumador.Sumar(7, 5);
            resultado = (int)sumador.Sumar(12, 12);
            Console.WriteLine($"Resultado: {resultado}");

            Console.WriteLine($"Resultado concatenar: {sumador.Sumar("7","5")}");

            cantidadSumas = (int)sumador;
            Console.WriteLine($"Cantidad de sumas: {cantidadSumas}");

            /*Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. 
             * El resultado será un long correspondiente al resultado de la suma del 
             * atributo cantidadSumas de cada argumento.
             */
            Sumador sumador2 = new Sumador(2);
            long sumaCantidadSumas;

            sumaCantidadSumas = sumador + sumador2;
            Console.WriteLine($"La suma de cantidad de sumas es {sumaCantidadSumas}");

            /*Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. 
             * Deberá retornar true si ambos sumadores tienen igual valor en el 
             * atributo cantidadSumas.
             */

            Console.WriteLine($"Sobrecarga de pipe: {sumador | sumador2}");


        }
    }
}
