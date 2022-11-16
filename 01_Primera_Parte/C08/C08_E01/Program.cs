using BibliotecaDeClases;
using System;

namespace C08_E01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Genero instancias
            Camion c1 = new Camion(8, 2, Colores.Rojo, 6, 10000);
            Moto m1 = new Moto(2, 1, Colores.Negro, 250);
            Automovil a1 = new Automovil(4, 5, Colores.Gris, 5, 5);

            VehiculoTerrestre v1 = new VehiculoTerrestre(3, 0, Colores.Blanco);




            Console.WriteLine("Camion c1 \nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nPeso Carga {4}", c1.cantidadRuedas, c1.cantidadPuertas, c1.color, c1.cantidadMarchas, c1.pesoCarga);
            Console.WriteLine("--------------");

            Console.WriteLine("Automovil a1\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nCantidad Pasajeros: {4}", a1.cantidadRuedas, a1.cantidadPuertas, a1.color, a1.cantidadMarchas, a1.cantidadPasajeros);
            Console.WriteLine("-----------");

            Console.WriteLine("Moto motito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCilindrada: {3}", m1.cantidadRuedas, m1.cantidadPuertas, m1.color, m1.cilindrada);

        }
    }
}
