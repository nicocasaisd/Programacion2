using System;
using System.Security.Cryptography.X509Certificates;

namespace Biblioteca
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        ConsoleColor IAcciones.Color { get ; set; }
        float IAcciones.UnidadesDeEscritura 
        { 
            get { return this.tinta; } 
            set { this.tinta = value; } 
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            UnidadesDeEscritura -= texto.Length * 0.3F;
            if (UnidadesDeEscritura < 0) { UnidadesDeEscritura = 0; }

            return new EscrituraWrapper(this.colorTinta, texto);
        }

        bool IAcciones.Recargar(int unidades)
        {
            if(unidades > 0)
            {
                this.tinta += unidades;
                return true;
            }
            return false;
        }
    }
}
