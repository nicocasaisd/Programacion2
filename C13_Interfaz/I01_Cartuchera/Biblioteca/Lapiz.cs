using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;


        public ConsoleColor Color 
        { 
            get { return ConsoleColor.Gray; } 
            set => throw new NotImplementedException(); 
        }
        public float UnidadesDeEscritura 
        { 
            get { return this.tamanioMina; } 
            set { this.tamanioMina = value; }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            UnidadesDeEscritura -= texto.Length * 0.1F;
            if (UnidadesDeEscritura < 0) { UnidadesDeEscritura = 0; }

            return new EscrituraWrapper(Color, texto);
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
    }
}
