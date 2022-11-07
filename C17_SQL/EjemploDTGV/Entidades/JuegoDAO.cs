using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class JuegoDAO
    {
        public static string cadenaConexion;
        public static SqlCommand comando;
        public static SqlConnection conexion;

        static JuegoDAO()
        {

        }


        public static void Eliminar(int codigoJuego)
        {

        }

        public static void Guardar(Juego juego)
        {

        }

        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> bibliotecas = new List<Biblioteca>();

            return bibliotecas;
        }

        public static Juego LeerPorId(int codigoJuego)
        {
            
        }

        public static void Modificar(Juego juego)
        {

        }

    }
}
