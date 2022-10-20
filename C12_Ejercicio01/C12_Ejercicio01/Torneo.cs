using Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Ejercicio01
{
    public class Torneo<T> where T : Equipo
    {
        List<T> equipos = new List<T>();
        string nombre;
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

        public string JugarPartido
        {
            get { return CalcularPartido(equipos[rand.Next(0, equipos.Count)], equipos[rand.Next(0, equipos.Count)]); }
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
            //if(torneo.equipos.Contains(equipo))
            //{
            //    return true;
            //}

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
                sb.AppendLine($"-Equipo: {item.Nombre}");
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
