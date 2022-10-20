using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Contabilidad<T,U>
    {
        List<T> egresos;
        List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }

        public static bool operator +(Contabilidad<T,U> c, T egreso)
        {
            if(c is not null)
            {
                c.egresos.Add(egreso);
                return true;
            }
            return false;
        }

        public static bool operator +(Contabilidad<T, U> c, U ingreso)
        {
            if (c is not null)
            {
                c.ingresos.Add(ingreso);
                return true;
            }
            return false;
        }
    }
}
