using Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Ejercicio01
{
    public class Torneo<T> where T : Equipo
    {
        List<T> equipos;
        string nombre = String.Empty;
        Random rand = new Random();

        #region INVALIDACIONES
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        public Torneo()
        {
            equipos = new List<T>();
        }

        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get 
            {
                T equipo1;
                T equipo2;

                do
                {
                    equipo1 = equipos[rand.Next(0, equipos.Count)];
                    equipo2 = equipos[rand.Next(0, equipos.Count)];

                } while (equipo1 == equipo2);
                return CalcularPartido(equipo1, equipo2); 
            }
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach(T item in torneo.equipos)
            {
                if(item == equipo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if((torneo is not null && equipo is not null) && torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }

            return false;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"TORNEO: {this.nombre}");
            foreach(T item in this.equipos)
            {
                sb.AppendLine($"-Equipo: {item.Nombre}. {item.Ficha}");
            }

            return sb.ToString();
        }

        private string CalcularPartido(T t1, T t2)
        {
            StringBuilder sb = new StringBuilder();
            

            sb.AppendLine($"[{t1.Nombre}] [{rand.Next(0,5)}] - [{rand.Next(0, 5)}] [{t2.Nombre}]");


            return sb.ToString();
        }

    }
}
