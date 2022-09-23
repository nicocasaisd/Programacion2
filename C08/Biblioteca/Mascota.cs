using System;

namespace Biblioteca
{
    public class Mascota
    {
        protected string nombre;
        private int patas;
        private string sexo;

        public Mascota(string nombre, int patas, string sexo)
        {
            this.nombre = nombre;
            this.patas = patas;
            this.sexo = sexo;
        }

        public string Saludar()
        {
            return "Hola soy " + this.nombre;
        }
    }
}
