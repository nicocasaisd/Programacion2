using System.Text;

namespace C05b_Entidades
{
    public class Ingresante
    {
        #region Atributos
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        #endregion

        #region Metodos

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine($"Pais: {this.pais}");
            sb.AppendLine($"Edad: {this.edad}");
            foreach(string s in cursos)
            {
                sb.AppendLine($"Cursa: {s}");
            }
            return sb.ToString();
        }


        #endregion


    }
}