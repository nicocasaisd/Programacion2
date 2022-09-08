using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        #region Atributos
        // ATRIBUTOS
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta; // entero de 16bits signed
        #endregion

        // CONSTRUCTOR
        public Boligrafo()
        {
            this.color = ConsoleColor.Black;
            this.tinta = 0;
        }
        public Boligrafo(short tinta, ConsoleColor color) : this()
        {
            this.SetTinta(tinta);
            this.color = color;
        }

        #region I/O
        // GETTERS
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        // SETTERS
        private bool SetTinta(short tinta)
        {
            bool retorno = false;
            if(this.tinta + tinta <= cantidadTintaMaxima && this.tinta + tinta >= 0)
            {
                this.tinta += tinta;
                retorno = true;
            }
            return retorno;
        }

        #endregion


        // METODOS
        public void Recargar()
        {
            this.SetTinta((short)(Boligrafo.cantidadTintaMaxima - this.tinta));
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = String.Empty;
            bool retorno = false;

            if(this.SetTinta((short)-gasto))
            {
                for(int i=0; i<gasto; i++)
                {
                    dibujo += "*";
                }
                retorno = true;
            }

            return retorno;
        }

        public void DibujarEnConsola(string dibujo)
        {
            Console.ForegroundColor = this.GetColor();
            Console.WriteLine(dibujo);
            Console.ResetColor();
        }
    }
}
