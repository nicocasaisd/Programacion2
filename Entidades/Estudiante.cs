using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        // ATRIBUTOS
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        // METODOS
        
        static Estudiante()
        {
            // Llama al constructor de Random usando un seed por defecto
            random = new Random();
            Console.WriteLine("Se ha inicializado el objeto random.");
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal = -1;
            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 11);
            }
            return notaFinal;
        }

        private float CalcularPromedio()
        {
            return (float) (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public string Mostrar()
        {
            double notaFinal = CalcularNotaFinal();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} {this.apellido} - legajo: {this.legajo}");
            sb.AppendLine($"Nota primer parcial: {this.notaPrimerParcial} | Nota segundo parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            if(notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            

            return sb.ToString();
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
        
    }
}
