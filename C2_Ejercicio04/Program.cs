using System;

namespace C2_Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Metodos para validar tipos
            double doble = 0.0 / 0.0;
            bool respuesta = Double.IsNaN(doble);

            Console.WriteLine($"La respuesta es : {respuesta}");
        }
    }
}
