using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_Constructores
{
    internal class Empleado
    {
        public int salario;

        public Empleado()
        { }

        public Empleado(int salarioAnual)
        {
            this.salario = salarioAnual;
        }

        public Empleado(int salarioSemanal, int cantidadDeSemanas)
            : this(salarioSemanal * cantidadDeSemanas)
        { }
    }
}
