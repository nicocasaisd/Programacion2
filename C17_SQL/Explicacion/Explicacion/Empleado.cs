using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicacion
{
    public class Empleado
    {
        public string nombre;
        public int id_puesto;
        public double sueldo;

        public Empleado(string nombre, int id_puesto, double sueldo)
        {
            this.nombre = nombre;
            this.id_puesto = id_puesto;
            this.sueldo = sueldo;
        }
    }
}
