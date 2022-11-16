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
                //if(!this.clientes.Contains(value))
                //{
                //    this.clientes.Enqueue(value);
                //}
                _ = this + value;
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

        public Negocio(string nombre) :this()
        {
            this.nombre = nombre;
        }

        // METODOS
        public static bool operator ==(Negocio n, Cliente c)
        {
            //return n.clientes.Contains(c);
            // el metodo Contains utiliza el Equals , no funciona
            foreach(Cliente item in n.clientes)
            {
                if(c == item)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            // si el cliente no esta en la cola
            if(n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            if(n.clientes.Count > 0)
            {
                Cliente cli = n.Cliente;
                retorno = n.caja.Atender(cli);
            }

            return retorno;
        }

    }
}
