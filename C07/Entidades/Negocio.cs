using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public int ClientesPendientes 
        { 
            get { return this.clientes.Count; }
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

        public static bool operator +(Negocio n, Cliente c)
        {
            bool clienteEnCola = false;

            // por cada cliente en la cola actual
            foreach(Cliente cCola in n.clientes)
            {
                // si el cliente que quiero meter está en la cola, cambio el bool
                if(c == cCola)
                {
                    clienteEnCola = true;
                }
            }

            if(!clienteEnCola)
            {
                n.clientes.Enqueue(c);
            }

            return !clienteEnCola;
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;

            Cliente cli = n.Cliente;
            retorno = n.caja.Atender(cli);

            return retorno;
        }


    }
}
