using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class MiClase
    {
        public static void MetodoEstatico()
        {
            throw new DivideByZeroException();
        }

        public MiClase()
        {
            try
            {
                MiClase.MetodoEstatico();
            }
            catch (DivideByZeroException ex)
            {

                throw new UnaExcepcion("En el constructor de MiClase", ex);
            }
        }

        public MiClase(Exception ex)
        {

        }
    }
}
