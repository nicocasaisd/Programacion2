using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace C08_Herencia_Explicacion.Biblioteca
{
    internal class Perro : Mascota
    {
        public Perro(string nombre, int patas, string sexo) : base(nombre, patas, sexo)
        {

        }

        public string Ladrar()
        {
            base.Saludar();
            return this.nombre;
        }
    }
}
