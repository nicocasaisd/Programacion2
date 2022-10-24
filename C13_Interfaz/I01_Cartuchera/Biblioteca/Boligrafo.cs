using System;
using System.Security.Cryptography.X509Certificates;

namespace Biblioteca
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color { get ; set; }
        
        public float UnidadesDeEscritura 
        { 
            get { return this.tinta; } 
            set { this.tinta = value; } 
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            UnidadesDeEscritura -= texto.Length * 0.3F;
            if (UnidadesDeEscritura < 0) { UnidadesDeEscritura = 0; }

            return new EscrituraWrapper(this.colorTinta, texto);
        }

        public bool Recargar(int unidades)
        {
            if(unidades > 0)
            {
                this.tinta += unidades;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Boligrafo de color {this.colorTinta} con nivel de tinta {this.tinta}";
        }
    }
}
