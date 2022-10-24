using System;

namespace Biblioteca
{
    public abstract class Paquete
    {
        #region ATRIBUTOS

        string codigoSeguimiento;
        protected decimal costoEnvio;
        string destino;
        string origen;
        double pesoKg;

        #endregion

        #region PROPIEDADES
        public abstract bool TienePrioridad
        {
            get;
        }

        #endregion 
    }
}
