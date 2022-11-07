using System;

namespace Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public int Id
        {
            get { return id; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellido
        {
            get { return apellido; }
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(int id, string nombre, string apellido) :this(nombre, apellido)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return $"{id}, {nombre}, {apellido}";
        }
    }
}
