using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador_OffShore
{
    internal class Cliente
    {
        // ATRIBUTOS
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;

        // CONSTRUCTORES
        private Cliente()
        {
            this._aliasParaIncognito = "Sin alias";
            this._nombre = "NN";
            this._tipoDeCliente = eTipoCliente.SinTipo;
        }

        public Cliente(eTipoCliente tipoCliente) : this()
        {
            this._tipoDeCliente = tipoCliente;
        }

        public Cliente(eTipoCliente tipoCliente, string nombre) : this(tipoCliente)
        {
            this._nombre = nombre;
            this.CrearAlias();
        }

        // METODOS

        private void CrearAlias()
        {
            Random random = new Random();
            int numeroRandom = random.Next(1000, 2000);

            this._aliasParaIncognito = numeroRandom + this._tipoDeCliente.ToString();
        }

        public string GetAlias()
        {
            if(this._aliasParaIncognito == "Sin alias")
            {
                this.CrearAlias();
            }
            return this._aliasParaIncognito;
        }

        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this._nombre}");
            sb.AppendLine($"Alias: {this._aliasParaIncognito}");
            sb.AppendLine($"Tipo de cliente: {this._tipoDeCliente.ToString()}");
            return sb.ToString();
        }

        public static string RetornarDatos(Cliente cli)
        {
            if(cli is not null)
            {
                return cli.RetornarDatos();
            }
            else 
            { 
                return ""; 
            }
        }
        
    }
}
