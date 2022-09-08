using System;

/*
Consigna
Mostrar por pantalla todos los números primos que haya hasta el número que 
ingrese el usuario por consola.

Validar que el dato ingresado por el usuario sea un número.

Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

Si ingresa "salir", cerrar la consola.

Al finalizar, preguntar al usuario si desea volver a operar. 
Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
 */

namespace C1_Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numero = 0;
            bool validacion;
            bool esPrimo;



            Console.WriteLine("Ingrese un numero: ");
            numeroIngresado = Console.ReadLine();
            // Pregunto si quiere salir
            if (numeroIngresado == "salir")
            {
                return;
            }
            // Parseo
            validacion = int.TryParse(numeroIngresado, out numero); // variable de salida

            // Validacion
            while (numero <= 0 || !validacion)
            {
                Console.WriteLine("ERROR. ¡Reingresar número! :");
                numeroIngresado = Console.ReadLine();
                // Pregunto si quiere salir
                if(numeroIngresado == "salir")
                {
                    return;
                }
                validacion = int.TryParse(numeroIngresado, out numero);
            }

            // Numeros primos
            for(int i=1; i < numero; i++)
            {
                // Inicializo esPrimo
                esPrimo = true;
                // Divido por todos los numeros anteriores
                for(int j=2; j < i; j++)
                {
                    // Si el resto es 0, no es primo
                    if(i%j == 0)
                    {
                        esPrimo = false;
                    }
                    
                }
                // Si es primo lo muestro
                if(esPrimo)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
