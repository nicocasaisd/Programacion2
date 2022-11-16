using System;


/*Consigna
Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
Se debe validar que el número sea mayor que cero, caso contrario, 
mostrar el mensaje: "ERROR. ¡Reingresar número!".

IMPORTANTE
Utilizar el método Pow de la clase Math para calcular las potencias.
*/

namespace C1_Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            bool validacion;
            int numero = 0;
            double cuadrado = 0;
            double cubo = 0;

            Console.WriteLine("Ingrese un numero: ");
            numeroIngresado = Console.ReadLine();
            validacion = int.TryParse(numeroIngresado, out numero); // variable de salida

            // Validacion
            while(numero <= 0 || !validacion)
            {
                Console.WriteLine("ERROR. ¡Reingresar número! :");
                numeroIngresado = Console.ReadLine();
                validacion = int.TryParse(numeroIngresado, out numero);
            }

            // Operaciones
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            // Muestro los datos
            Console.WriteLine("El numero ingresado es: {0}", numero);
            Console.WriteLine("El cuadrado es: {0}", cuadrado);
            Console.WriteLine("El cubo es: {0}", cubo);



        }
    }
}
