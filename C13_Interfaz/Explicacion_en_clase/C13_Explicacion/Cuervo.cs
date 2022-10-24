using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_Explicacion
{
    public class Cuervo : IMensaje, IEncriptado
    {
        public string EnviarMensaje()
        {
            return "Llegó el invierno";
        }

        string IEncriptado.EnviarMensaje()
        {
            return "Jon Snow es el verdadero rey";
        }
    }
}
