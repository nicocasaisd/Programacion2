using System;
using Entidades;

namespace C03_Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancias de la clase Estudiante
            Estudiante estudiante1 = new Estudiante("Nicolas", "Casais", "1");
            Estudiante estudiante2 = new Estudiante("Juan", "Golfo", "2");
            Estudiante estudiante3 = new Estudiante("Perla", "Negra", "3");

            // Cargo notas
            estudiante1.SetNotaPrimerParcial(10);
            estudiante1.SetNotaSegundoParcial(10);

            estudiante2.SetNotaPrimerParcial(8);
            estudiante2.SetNotaSegundoParcial(7);

            estudiante3.SetNotaPrimerParcial(3);
            estudiante3.SetNotaSegundoParcial(1);

            // Muestro datos
            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}
