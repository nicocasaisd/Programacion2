using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        // ATRIBUTOS
        private PuestoDeAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        // PROPIEDADES
        public Cliente Cliente 
        { 
            get { return this.clientes.Dequeue(); } 
            set 
            { 
                if(!this.clientes.Contains(value))
                {
                    this.clientes.Enqueue(value);
                }
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoDeAtencion(PuestoDeAtencion.Puesto.Caja1);
        }

        // METODOS
        public static bool operator ==(Negocio n, Cliente c)
        {
            return n.clientes.Contains(c);
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }


    }
}
