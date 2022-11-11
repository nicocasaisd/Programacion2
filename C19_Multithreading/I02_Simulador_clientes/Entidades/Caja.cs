using System;

namespace Entidades
{
    public delegate void DelegadoClienteAtendido(Caja caja, string str);

    public class Caja
    {
        static Random rnd;
        private Queue<string> clientesALaEspera;
        private string nombreCaja;
        private DelegadoClienteAtendido delegadoClienteAtendido;

        public int CantidadClientesALaEspera 
        {
            get { return this.clientesALaEspera.Count; };  
        }

        public string NombreCaja
        {
            get { return this.nombreCaja; }
        }


        static Caja()
        {
            rnd = new Random();
        }

        public Caja(string nombre, DelegadoClienteAtendido delegado)
        {
            this.clientesALaEspera = new Queue<string>();
            this.NombreCaja = nombre;
            this.delegadoClienteAtendido = delegado;

        }



        
    }
}
