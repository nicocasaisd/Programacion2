﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ejercicio01
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {

            bool retorno = true;

            if (valor > max || valor < min)
            {
                retorno = false;
            }
            return retorno;

            // return valor >= min && valor <= max;
        }
    }
}
