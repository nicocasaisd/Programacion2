using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PaquetePesado:Paquete, IAfip
    {
        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg) : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        {
        }

        public override bool TienePrioridad => false;


        #region IMPLEMENTACION IMPLICITA
        public override decimal Impuestos
        {
            get { return this.costoEnvio * 0.35M; }
        }

        public override decimal AplicarImpuestos()
        {
            return this.costoEnvio + this.Impuestos + ((IAfip)this).Impuestos;
        }
        #endregion

        #region IMPLEMENTACION EXPLICITA

        decimal IAfip.Impuestos
        {
            get { return this.costoEnvio * 0.25M; }
        }

        #endregion
    }
}
