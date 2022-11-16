using System;

namespace Billetes
{
    public class Peso
    {
        // ATRIBUTOS
        private double cantidad;
        private static double cotzRespectoDolar;

        // CONSTRUCTORES
        static Peso()
        {
            Peso.cotzRespectoDolar = 102.65;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
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
        public static explicit operator Dolar(Peso p)
        {
            Dolar dolar = new Dolar(p.cantidad / Peso.cotzRespectoDolar);
            return dolar;
        }

        public static explicit operator Euro(Peso p)
        {
            //Euro euro = new Euro((Dolar)p);
            //return euro;
            return (Euro)((Dolar)p);
            
        }

        // COMPARACION

        // Peso vs Peso
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        // Peso vs Dolar
        public static bool operator ==(Peso p, Dolar d)
        {
            return p.GetCantidad() == ((Peso) d).GetCantidad();
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        // Peso vs Euro
        public static bool operator ==(Peso p, Euro e)
        {
            return p.GetCantidad() == ((Peso)e).GetCantidad();
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static Peso operator +(Peso p1, Peso p2)
        {
            return new Peso(p1.cantidad + p2.cantidad);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso( p.cantidad + ((Peso)d).GetCantidad() );
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso( p.cantidad + ((Peso)e).GetCantidad() );
        }

        public static Peso operator -(Peso p1, Peso p2)
        {
            return new Peso(p1.cantidad - p2.cantidad);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.cantidad - ((Peso)d).GetCantidad());
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.cantidad - ((Peso)e).GetCantidad());
        }



    }
}
