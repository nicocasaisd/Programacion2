using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        string nombre;
        DateTime fechaCreacion;

        protected Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

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

        public string Nombre
        {
            get { return nombre; }
        }

        public string Ficha
        {
            get { return $"{this.nombre} fundado el {this.fechaCreacion.ToShortDateString()}"; }
        }



        public static bool operator==(Equipo a, Equipo b)
        {
            return (a.nombre == b.nombre && a.fechaCreacion == b.fechaCreacion);
        }

        public static bool operator !=(Equipo a, Equipo b)
        {
            return !(a == b);
        }

    }
}
