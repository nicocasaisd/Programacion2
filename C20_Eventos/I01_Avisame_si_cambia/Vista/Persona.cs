using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    public class Persona
    {
		// Declaro el delegado
		public delegate void DelegadoString(string msg);
		// Declaro el evento
		public event DelegadoString EventoString;


		private string nombre;
        private string apellido;

		public Persona(string nombre, string apellido)
		{
			this.nombre = nombre;
			this.apellido = apellido;
		}

        public string Nombre
		{
			get { return nombre; }
			set 
			{ 
				nombre = value;
				EventoString.Invoke("Se ha cambiado el nombre");
			}
		}

		public string Apellido
		{
			get { return apellido; }
			set
			{ 
				apellido = value;
                EventoString.Invoke("Se ha cambiado el apellido");
            }
		}

		public string Mostrar()
		{
			return $"{Nombre} {Apellido}";
		}


	}
}
