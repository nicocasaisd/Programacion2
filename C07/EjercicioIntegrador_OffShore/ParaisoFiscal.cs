
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador_OffShore
{
    internal class ParaisoFiscal
    {
        // ATRIBUTOS
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicioActividades;

        //CONSTRUCTORES

        static ParaisoFiscal()
        {
            ParaisoFiscal.cantidadDeCuentas = 0;
            ParaisoFiscal.fechaInicioActividades = DateTime.Now;
        }

        private ParaisoFiscal()
        {
            this._listadoCuentas = new List<CuentaOffShore>();
            //ParaisoFiscal.cantidadDeCuentas++;
        }

        private ParaisoFiscal(eParaisosFiscales lugar) : this()
        {
            this._lugar = lugar;
        }

        // METODOS

        public void MostrarParaiso()
        {
            int indice = 0;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fecha de inicio: {ParaisoFiscal.fechaInicioActividades.ToString()}");
            sb.AppendLine($"Locacion: {this._lugar.ToString()}");
            sb.AppendLine($"Cant de cuentas: {this._listadoCuentas.Count}");
            sb.AppendLine("**** Listado de cuentas offshore **** \n");
            
            foreach (CuentaOffShore cuenta in this._listadoCuentas)
            {
                sb.Append($"Detalle dueño {indice}: {Cliente.RetornarDatos(cuenta.Dueño)}");
                sb.AppendLine($"Saldo: {cuenta.Saldo}\n");
                indice++;
            }

            Console.WriteLine(sb.ToString());
        }

        // SOBRECARGAS

        public static implicit operator ParaisoFiscal(eParaisosFiscales lugar)
        {
            ParaisoFiscal nuevoParaiso = new ParaisoFiscal(lugar);
            
            return nuevoParaiso;
        }

        public static bool operator ==(ParaisoFiscal paraiso, CuentaOffShore cuenta)
        {
            bool retorno = false;
            foreach(CuentaOffShore cuentaLista in paraiso._listadoCuentas)
            {
                if (cuenta == cuentaLista)
                {
                    retorno = true;
                }
            }
            
            return retorno;
        }

        public static bool operator !=(ParaisoFiscal paraiso, CuentaOffShore cuenta)
        {
            return !(paraiso == cuenta);
        }

        public static ParaisoFiscal operator +(ParaisoFiscal paraiso, CuentaOffShore cuenta)
        {
            if(paraiso == cuenta)
            {
                foreach (CuentaOffShore cuentaLista in paraiso._listadoCuentas)
                {
                    if (cuenta == cuentaLista)
                    {
                        cuentaLista.Saldo += cuenta.Saldo;
                    }
                }
                Console.WriteLine("La cuenta ya existe en el listado. Se actualizó el saldo.");
            }
            else
            {
                paraiso._listadoCuentas.Add(cuenta);
                Console.WriteLine("Se agregó la cuenta al paraíso.");
            }

            return paraiso;
        }

        public static ParaisoFiscal operator -(ParaisoFiscal paraiso, CuentaOffShore cuenta)
        {
            if (paraiso != cuenta)
            {
                Console.WriteLine("La cuenta no existe en el listado.");
            }
            else
            {
                paraiso._listadoCuentas.Remove(cuenta);
                Console.WriteLine("Se quitó la cuenta del paraíso.");
            }

            return paraiso;
        }

    }
}
