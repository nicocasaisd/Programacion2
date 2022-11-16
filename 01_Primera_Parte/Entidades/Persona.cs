using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

        // CONSTRUCTOR
        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        // METODOS

        // SETTERS
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        // GETTERS
        public string GetNombre()
        {
            return this.nombre;
        }
        public DateTime GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }
        public string GetDni()
        {
            return this.dni;
        }

        // METODOS
        private int CalcularEdad()
        {
            int edad = 0;
            DateTime hoy = DateTime.Now;
            DateTime diaUno = new DateTime(1, 1, 1);

            // calculo diferencia de fecha a partir de hoy
            TimeSpan diferencia = hoy.Subtract(this.fechaDeNacimiento);

            // Calculo la edad en años
            // (al dia uno le sumo el tiempo transcurrido desde el nacimiento)
            // y me quedo con el campo Year al que le resto 1

            edad = (diaUno + diferencia).Year - 1; // la suma devuelve un tipo DateTime

            return edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Fecha de nacimiento: {this.fechaDeNacimiento.ToShortDateString()}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.Append($"Edad: {this.CalcularEdad()}");

            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            string esMayor = "Es menor de edad";
            int edad;

            edad = this.CalcularEdad();
            if(edad >= 18)
            {
                esMayor = "Es mayor de edad";
            }

            return esMayor;
        }
    }
}
