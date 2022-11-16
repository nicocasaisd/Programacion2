using System;

namespace C02_Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diasTranscurridos;

            // Defino la fecha de nacimiento
            DateTime fechaDeNacimiento = new DateTime(1991, 9, 19);

            // Defino fecha de hoy
            DateTime hoy = new DateTime(2022, 9, 1);

            // Sustraccion entre dos fechas devuelve un tipo TimeSpan
            diasTranscurridos = (hoy - fechaDeNacimiento).Days;

            Console.WriteLine($"Dias transcurridos: {diasTranscurridos}");
        }
    }
}
