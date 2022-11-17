using System;
using Biblioteca;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            PaqueteFragil paqueteFragil = new PaqueteFragil("001", 100, "BsAs", "Tucuman", 2);
            PaquetePesado paquetePesado = new PaquetePesado("002", 100, "Ushuaia", "La Quiaca", 7);

            Console.WriteLine("-----------");
            Console.WriteLine(paqueteFragil.ObtenerInformacionDePaquete());
            Console.WriteLine($"Impuestos: {paqueteFragil.Impuestos}, Total: {paqueteFragil.AplicarImpuestos()}");

            Console.WriteLine("-----------");
            Console.WriteLine(paquetePesado.ObtenerInformacionDePaquete());
            Console.WriteLine($"Impuestos Aduana: {paquetePesado.Impuestos}, Impuestos Afip: {((IAfip)paquetePesado).Impuestos}, Total: {paquetePesado.AplicarImpuestos()}");


        }
    }
}
