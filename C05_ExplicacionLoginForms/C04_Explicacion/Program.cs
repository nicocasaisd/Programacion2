using System;

namespace C04_Explicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constructores
            Vehiculo v1 = new Vehiculo(5, "Nissan", "Rojo", 60);

            Vehiculo v2 = new Vehiculo(5, "Ford", "Blanco", 30);
            Console.WriteLine(v1.Color); // propiedad GET

            Console.WriteLine(v1 == v2);
            v1.Color = "Blanco"; // propiedad SET

            Console.WriteLine(v1.Color);

            DateTime hoy = DateTime.Now; // <-- esto es una propiedad

            // Sobrecarga de operadores
            int nafta = v1 + 100;

            Console.WriteLine(v1 == v2);

            // Sobrecarga de casteo
            string colorCasteado;
            int naftaCasteado;

            colorCasteado = v1;
            naftaCasteado = (int)v1;
            Console.WriteLine($"Color: {colorCasteado}, nafta: {naftaCasteado}");
        }
    }
}
