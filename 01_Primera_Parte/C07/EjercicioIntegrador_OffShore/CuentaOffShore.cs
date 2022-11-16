using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador_OffShore
{
    internal class CuentaOffShore
    {
        // ATRIBUTOS
        private Cliente _dueño;
        private int _numeroCuenta;
        private double _saldo;

        //CONSTRUCTORES
        public CuentaOffShore(Cliente dueño, int numero, double saldoInicial)
        {
            this._dueño = dueño;
            this._numeroCuenta = numero;
            this._saldo = saldoInicial;
        }

        public CuentaOffShore(string nombre, eTipoCliente tipo, int numero, double saldoInicial) : this(new Cliente(tipo, nombre), numero, saldoInicial)
        { 
            
        }

        //PROPIEDADES

        public Cliente Dueño
        {
            get { return this._dueño; }
        }

        public double Saldo
        {
            get { return this._saldo; }
            set { this._saldo = value; }
        }

        // METODOS

        public static bool operator ==(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            bool retorno = false;
            if(cos1.Dueño.GetAlias() == cos2.Dueño.GetAlias() && cos1._numeroCuenta == cos2._numeroCuenta)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2);
        }

        public static explicit operator int(CuentaOffShore cos)
        {
            return cos._numeroCuenta;
        }

    }
}
