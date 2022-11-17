using System;

namespace Biblioteca
{
    public abstract class Paquete : IAduana
    {
        #region ATRIBUTOS

        string codigoSeguimiento;
        protected decimal costoEnvio;
        string destino;
        string origen;
        double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        #endregion



        #region PROPIEDADES
        public abstract bool TienePrioridad
        {
            get;
        }
        public abstract decimal Impuestos { get; }

        #endregion

        #region METODOS

        public string ObtenerInformacionDePaquete()
        {
            return $"Cod: {codigoSeguimiento}, \nCosto: {costoEnvio}, \nDestino: {destino}, Origen: {origen}, \nPeso: {pesoKg}, \nPrioridad: {TienePrioridad}";
        }

        public abstract decimal AplicarImpuestos();

        #endregion
    }
}
