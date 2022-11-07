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
            // Constructor estático
            cadenaConexion = "Server=.;Database=EJERCICIOS_UTN;Trusted_Connection=True;";
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }


        public static void Eliminar(int codigoJuego)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE JUEGOS WHERE CODIGO_JUEGO={codigoJuego}";
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public static void Guardar(Juego juego)
        {

        }

        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> bibliotecas = new List<Biblioteca>();
            SqlDataReader lector;

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT U.USERNAME, J.GENERO, J.NOMBRE, J.CODIGO_JUEGO\r\nFROM JUEGOS AS J\r\nJOIN USUARIOS AS U\r\nON J.CODIGO_USUARIO = U.CODIGO_USUARIO";
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    string usuario = lector["USERNAME"].ToString();
                    string genero = lector["GENERO"].ToString();
                    string nombre = lector["NOMBRE"].ToString();
                    int codigo_juego = (int)lector["CODIGO_JUEGO"];

                    bibliotecas.Add(new Biblioteca(usuario, genero, nombre, codigo_juego));

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

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
