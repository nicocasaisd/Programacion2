using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    // Declaro el delegado
    public delegate void DelegadoString(string msg);

    public class Persona
    {
		
		// Declaro el evento
		public event DelegadoString EventoString;


		private string nombre;
        private string apellido;

		public Persona()
		{
		}

        public string Nombre
		{
			get { return nombre; }
			set 
			{ 
				nombre = value;
				if(EventoString is not null)
				{
					EventoString.Invoke("Se ha cambiado el nombre");
				}
			}
		}

		public string Apellido
		{
			get { return apellido; }
			set
			{ 
				apellido = value;
                if (EventoString is not null)
                {
                    EventoString.Invoke("Se ha cambiado el apellido");
                }
            }
		}

		public string Mostrar()
		{
			return $"{Nombre} {Apellido}";
		}


	}
}
