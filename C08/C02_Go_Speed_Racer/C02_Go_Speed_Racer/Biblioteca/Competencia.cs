using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public short CantidadCompetidores
        {
            get { return cantidadCompetidores; }
            set { cantidadCompetidores = value; }
        }

        public short CantidadVueltas 
        { 
            get {return cantidadVueltas; } 
            set {cantidadVueltas = value; }
        }

    }

    public enum TipoCompetencia
    {
        F1, MotoCross
    }
}
