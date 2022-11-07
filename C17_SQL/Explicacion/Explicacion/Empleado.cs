using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicacion
{
    public class Empleado
    {
        public string _NOMBRE;
        public string _APELLIDO;
        public int _ID_PUESTO;
        public double _SALARIO;
        public bool _ESTA_ACTIVO;
        public string _FECHA_ALTA;

        public Empleado(string nOMBRE, string aPELLIDO, int iD_PUESTO, double sALARIO, bool eSTA_ACTIVO, string fECHA_ALTA)
        {
            _NOMBRE = nOMBRE;
            _APELLIDO = aPELLIDO;
            _ID_PUESTO = iD_PUESTO;
            _SALARIO = sALARIO;
            _ESTA_ACTIVO = eSTA_ACTIVO;
            _FECHA_ALTA = fECHA_ALTA;
        }
    }
}
