using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CartucheraMultiuso
    {
        public List<IAcciones> listaAcciones;

        public CartucheraMultiuso()
        {
            this.listaAcciones = new List<IAcciones>();
        }

        public bool RecorrerElementos()
        {
            bool retorno = false;
            foreach(IAcciones item in listaAcciones)
            {
                item.UnidadesDeEscritura--;
            }
            return retorno;
        }

        public void MostrarElementos()
        {
            foreach(IAcciones item in listaAcciones)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
