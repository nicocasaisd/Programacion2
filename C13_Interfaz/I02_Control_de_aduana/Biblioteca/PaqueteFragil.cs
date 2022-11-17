using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PaqueteFragil : Paquete
    {
        public PaqueteFragil(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg) : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        {
        }

        public override bool TienePrioridad => true;

        public override decimal Impuestos
        {
            get { return this.costoEnvio * 0.35M; }
        }

        public override decimal AplicarImpuestos()
        {
            return this.costoEnvio + this.Impuestos;
        }
    }
}
