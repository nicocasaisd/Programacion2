using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class GestionImpuestos
    {
        List<IAduana> impuestosAduana;
        List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            this.impuestosAduana = new List<IAduana>();
            this.impuestosAfip = new List<IAfip>();
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal totalImpuestosAduana = 0;

            foreach(IAduana paquete in impuestosAduana)
            {
                totalImpuestosAduana += paquete.Impuestos;
            }
            return totalImpuestosAduana;
        }


        public decimal CalcularTotalImpuestosAfip()
        {
            decimal totalImpuestosAfip = 0;

            foreach(IAfip paquete in impuestosAfip)
            {
                totalImpuestosAfip += ((IAfip)paquete).Impuestos;
            }
            return totalImpuestosAfip;
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete item in paquetes)
            {
                RegistrarImpuestos(item);
            }
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            this.impuestosAduana.Add(paquete);
            if(paquete is IAfip)
            {
                this.impuestosAfip.Add((IAfip)paquete);
            }
        }



    }
}
