using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        // ATRIBUTOS
        private double cantidad;
        private static double cotzRespectoDolar;

        // CONSTRUCTORES
        static Dolar()
        {
            cotzRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
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

        public static explicit operator Peso(Dolar d)
        {
            Peso peso = new Peso(d.cantidad * Peso.GetCotizacion() );
            return peso;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro euro = new Euro(d.cantidad * Euro.GetCotizacion());
            return euro;
        }

        // OPERADORES
        // COMPARACION

        // Dolar vs Dolar
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() == d2.GetCantidad();
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        // Dolar vs Peso
        public static bool operator ==(Dolar d, Peso p)
        {
            return d.cantidad == ((Dolar)p).GetCantidad();
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(p == d);
        }

        // Peso vs Euro
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.GetCantidad() == ((Dolar)e).GetCantidad();
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        // Suma
        public static Dolar operator +(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.cantidad + d2.cantidad);
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).GetCantidad());
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).GetCantidad());
        }

        // Resta
        public static Dolar operator -(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.cantidad - d2.cantidad);
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).GetCantidad());
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).GetCantidad());
        }
    }
}
