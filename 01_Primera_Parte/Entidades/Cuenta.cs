using System;
using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        // ATRIBUTOS
        private string titular;
        private decimal cantidad;

        // CONSTRUCTOR
        public Cuenta()
        {
            this.titular = "Desconocido";
            this.cantidad = 0;
        }

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        // METODOS

        public string GetTitular()
        {
            return this.titular;
        }

        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {this.titular}");
            sb.AppendLine($"Cantidad: {this.cantidad.ToString()}");

            return sb.ToString();
        }

        public void Ingresar(decimal monto)
        {
            if(monto >= 0)
            {
                this.cantidad += monto;
            }
        }

        public void Retirar(decimal monto)
        {
            if(monto >= 0)
            {
                this.cantidad -= monto;
            }
        }
    }
}
