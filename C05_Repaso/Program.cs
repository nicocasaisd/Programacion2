using System;
using C05_Entidades;

namespace C05_Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado();
            Empleado e2 = new Empleado("Juan");
            Empleado e3 = new Empleado("Pedro", 1101, 100000);

            // Propiedades
            e1.Nombre = "Lucas";

            Console.WriteLine(e1.Nombre);

            // Saludar
            Console.WriteLine(e3.Saludar());
            Console.WriteLine(e2.Saludar("Pedro"));
            Console.WriteLine(e2.Saludar(3));

            //operador ternario -> es un if resumido
            string saludo = e1.Nombre == e2.Nombre ? "hola" : "chau";

            Console.WriteLine(e1);
        }
    }
}
