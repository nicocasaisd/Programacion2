using System;
using Entidades;

namespace C3_Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciar
            Cuenta cuenta1;
            cuenta1 = new Cuenta("Panaderia SRL", 100);

            // Estado inicial
            Console.WriteLine(cuenta1.Mostrar());

            // Deposito
            cuenta1.Ingresar(1000);
            cuenta1.Ingresar(200);

            // Retiro
            cuenta1.Retirar(357);
            cuenta1.Retirar(12);

            // Estado final
            Console.WriteLine(cuenta1.Mostrar());
        }
    }
}
