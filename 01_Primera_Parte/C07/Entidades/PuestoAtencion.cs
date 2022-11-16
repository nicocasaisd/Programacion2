using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class PuestoDeAtencion
    {
        // ATRIBUTOS
        public enum Puesto
        {
            Caja1, Caja2
        }

        static private int numeroActual;
        Puesto puesto;

        static PuestoDeAtencion()
        {
            PuestoDeAtencion.numeroActual = 0;
        }

        public PuestoDeAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        // PROPIEDADES
        public static int NumeroActual
        {
            get {
                PuestoDeAtencion.numeroActual++;
                return PuestoDeAtencion.numeroActual;
                }
        }

        // METODOS
        public bool Atender(Cliente cli)
        {
            if(cli is not null)
            {
                Console.WriteLine($"Atendiendo al cliente {cli.Numero} : {cli.Nombre}");
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }

    }
}
