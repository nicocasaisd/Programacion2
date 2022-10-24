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

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        ConsoleColor IAcciones.Color 
        { 
            get { return ConsoleColor.DarkGray; }
            set { throw new NotImplementedException(); } 
        }
        float IAcciones.UnidadesDeEscritura 
        { 
            get { return this.tamanioMina; } 
            set { this.tamanioMina = value; }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            string textoResultante = "";
            foreach (char item in texto)
            {
                // resto la tinta
                ((IAcciones)this).UnidadesDeEscritura -= 0.5F;
                // si es menor al limite, break
                if (((IAcciones)this).UnidadesDeEscritura < 0)
                {
                    ((IAcciones)this).UnidadesDeEscritura = 0;
                    break;
                }
                // lo paso al textoResultante
                textoResultante += item;
            }

            return new EscrituraWrapper( ((IAcciones)this).Color, textoResultante);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Lapiz de color {((IAcciones)this).Color} con nivel de mina {((IAcciones)this).UnidadesDeEscritura}";
        }
    }
}
