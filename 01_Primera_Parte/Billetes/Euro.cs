using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        // ATRIBUTOS
        private double cantidad;
        private static double cotzRespectoDolar;

        // CONSTRUCTORES
        static Euro()
        {
            cotzRespectoDolar = 1.17;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        // GETTERS
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        // SOBRECARGAS

        // CASTEO
        public static explicit operator Dolar(Euro e)
        {
            Dolar dolar = new Dolar(e.cantidad / Euro.cotzRespectoDolar);
            return dolar;
        }

        public static explicit operator Peso(Euro e)
        {
            Peso peso = new Peso( ((Peso)(Dolar)e).GetCantidad() );
            return peso;
        }


        // OPERADORES
        // COMPARACION

        // Euro vs Euro
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        // Euro vs Dolar
        public static bool operator ==(Euro e, Dolar d)
        {
            return e == ((Euro)d);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        // Euro vs Peso
        public static bool operator ==(Euro e, Peso p)
        {
            return e == ((Euro)p);
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        // Suma
        public static Euro operator +(Euro e1, Euro e2)
        {
            return new Euro(e1.cantidad + e2.cantidad);
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.cantidad + ((Euro)p).GetCantidad());
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).GetCantidad());
        }

        // Resta
        public static Euro operator -(Euro e1, Euro e2)
        {
            return new Euro(e1.cantidad - e2.cantidad);
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.cantidad - ((Euro)p).GetCantidad());
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).GetCantidad());
        }
    }
}
