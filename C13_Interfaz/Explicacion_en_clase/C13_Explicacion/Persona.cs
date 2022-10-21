using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_Explicacion
{
    public class Persona : ICazador
    {
        

        public string Cazar()
        {
            return "Cazo como un humano";
        }
    }
}
