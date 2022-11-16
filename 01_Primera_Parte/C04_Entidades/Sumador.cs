using System;

namespace C04_Entidades
{
    public class Sumador
    {
        // ATRIBUTOS
        private int cantidadSumas;

        // CONSTRUCTORES

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {}

        // METODOS

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;

            return a + b; // suma
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;

            return a + b; // concatena
        }

        // SOBRECARGA DE OPERADORES

        public static explicit operator int(Sumador a)
        {
            return a.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }


    }
}
