using System;
using System.Security.Cryptography.X509Certificates;

namespace Biblioteca
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color 
        { 
            get { return this.colorTinta; } 
            set { this.colorTinta = value; } 
        }
        
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
            string textoResultante = "";
            foreach(char item in texto)
            {
                // resto la tinta
                this.UnidadesDeEscritura -= 1F;
                // si es menor al limite, break
                if (this.UnidadesDeEscritura < 0)
                {
                    UnidadesDeEscritura = 0;
                    break;
                }
                // lo paso al textoResultante
                textoResultante += item;
            }

            return new EscrituraWrapper(this.colorTinta, textoResultante);
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
            return $"Boligrafo de color {this.Color} con nivel de tinta {this.UnidadesDeEscritura}";
        }
    }
}
