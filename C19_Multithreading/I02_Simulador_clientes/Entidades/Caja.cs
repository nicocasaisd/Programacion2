using System;

namespace Entidades
{
    public class Caja
    {
        static Random rnd;
        private Queue<string> clientesALaEspera;
        private string nombreCaja;

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

        public Caja(string nombre)
        {
            this.clientesALaEspera = new Queue<string>();
            this.NombreCaja = nombre;
        }



        
    }
}
