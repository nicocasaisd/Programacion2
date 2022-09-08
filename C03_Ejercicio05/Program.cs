using System;
using System.Security.Cryptography.X509Certificates;
using C03_Geometria;

namespace C03_Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void MostrarRectangulo(Rectangulo r1)
            {
                Console.WriteLine($"Area: {r1.Area()}");
                Console.WriteLine($"Perimetro: {r1.Perimetro()}");
            }

            // Instancio unos rectangulos
            Punto v1 = new Punto(1, 5);
            Punto v3 = new Punto(3, 0);
            Rectangulo r1 = new Rectangulo(v1, v3);

            // Lo muestro
            MostrarRectangulo(r1);

        }
    }
}
