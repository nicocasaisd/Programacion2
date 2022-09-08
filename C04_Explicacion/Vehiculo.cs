using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_Explicacion
{
    public class Vehiculo
    {
        public int puertas;
        public string marca;
        public string color;
        public int litrosDeNafta;

        // CONSTRUCTORES
        public Vehiculo(int puertas, string marca, string color, int litrosDeNafta)
        {
            this.puertas = puertas;
            this.marca = marca;
            this.color = color;
            this.litrosDeNafta = litrosDeNafta;
        }

        public Vehiculo() : this(-1, "Nulo", "Nulo", -1)
        {}

        public Vehiculo(int puertas) : this(puertas, "Nulo", "Nulo", -1)
        {}

        public Vehiculo(int puertas, string marca) : this(puertas, marca, "Nulo", -1)
        {}

        public Vehiculo(int puertas, string marca, string color) : this(puertas, marca, color, -1)
        {}

        static Vehiculo()
        {
            Console.WriteLine("Se inicializa el constructor estatico");
        }

        // PROPIEDADES
        public string Color 
        {
            get { return this.color; } 
            set
            { 
                if(value != null)
                {
                    this.color = value;
                }
            }
        }

        // SOBRECARGA DE OPERADORES

        public static int operator +(Vehiculo a, int b)
        {
            return (int)(a.litrosDeNafta + b);
        }

        public static bool operator ==(Vehiculo a, Vehiculo b)
        {
            return a.color == b.color;
        }

        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }

        // SOBRECARGA DE CASTEO
        public static implicit operator string(Vehiculo a)
        {
            return a.color;
        }

        public static explicit operator int(Vehiculo a)
        {
            return a.litrosDeNafta;
        }
        //
    }
}
