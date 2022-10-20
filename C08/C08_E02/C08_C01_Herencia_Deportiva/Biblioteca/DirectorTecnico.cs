using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        public DirectorTecnico(string nombre) : base(nombre)
        {
        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
    }
}
