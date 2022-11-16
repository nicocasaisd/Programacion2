using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ejercicio_ClaseSello
{
    internal class Sello
    {
        // Declaro atributo mensaje
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return ArmarFormatoMensaje();
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        private static string ArmarFormatoMensaje()
        {
            string mensajeFormateado = "";
            string asteriscos = string.Empty; // string vacio
            int largoMensaje;

            largoMensaje = Sello.mensaje.Length;
            // techo y piso del recuadro
            for(int i=0; i<(largoMensaje+2); i++)
            {
                asteriscos += "*";
            }
            // cuerpo
            mensajeFormateado = asteriscos+"\n*"+Sello.mensaje+"*\n"+asteriscos;

            return mensajeFormateado;
        }
    }
}

// String builder C#