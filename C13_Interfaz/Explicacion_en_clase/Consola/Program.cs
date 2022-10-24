using C13_Explicacion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> lista = new List<int>();

            IEnumerable<int> enumerable = lista;
            ICollection<int> collection = lista;

            
            collection.Add(1);

            enumerable.ToList();
            */

            Cuervo cuervo = new Cuervo();

            string mensaje;
            //mensaje = cuervo.EnviarMensaje();
            mensaje = ((IEncriptado)cuervo).EnviarMensaje(); 
            

            Console.WriteLine(mensaje);

        }
    }
}
