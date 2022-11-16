using System;

namespace C05_Entidades
{
    public class Empleado
    {
        #region Atributos

        private string nombre;
        private int legajo;
        private float sueldo;

        #endregion

        #region Constrctores
        public Empleado()
        {
            this.nombre = "NN";
            this.legajo = 1000;
            this.sueldo = 0;
        }

        public Empleado(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Empleado(string nombre, int legajo, float sueldo): this(nombre)
        {
            this.legajo = legajo;
            this.sueldo = sueldo;
        }

        #endregion

        #region Propiedades

        public string Nombre
        {
            get { return this.nombre;  }
            set { this.nombre = value; }
        }

        public int Legajo 
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        public float Sueldo
        {
            get { return this.sueldo; }
            set { this.sueldo = value; }
        }

        #endregion

        #region Metodos


        public string Saludar()
        {
            return $"Hola soy {this.nombre}, mi legajo es {this.legajo} y estoy saludando a todos.";
        }

        public string Saludar(string nombre)
        {
            return $"Hola soy {this.nombre}, mi legajo es {this.legajo} y estoy saludando a {nombre}.";
        }

        public string Saludar(int veces)
        {
            string cadena = "";

            for(int i=0; i<veces;i++)
            {
                cadena += $"{this.nombre}";
            }

            return cadena;
        }

        #endregion

        #region Operadores

        public static bool operator==(Empleado e1, Empleado e2)
        {
            return (e1.nombre == e2.nombre && e1.legajo == e2.legajo);
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        public static implicit operator string(Empleado e1)
        {
            return $"{e1.nombre}, {e1.legajo.ToString()}" ;
        }

        #endregion
    }
}
