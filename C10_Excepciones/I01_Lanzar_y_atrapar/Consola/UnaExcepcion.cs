using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
