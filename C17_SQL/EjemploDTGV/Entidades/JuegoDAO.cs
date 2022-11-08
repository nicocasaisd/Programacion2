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
            try
            {
                conexion.Open();
                comando.CommandText = "INSERT INTO JUEGOS VALUES(@codigo_usuario, @nombre, @precio, @genero)";
                comando.Parameters.AddWithValue("@codigo_usuario", juego.CodigoUsuario.ToString());
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@precio", juego.Precio.ToString());
                comando.Parameters.AddWithValue("@genero", juego.Genero);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

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
            SqlDataReader lector;
            Juego auxJuego = new Juego();

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM JUEGOS\r\nWHERE CODIGO_JUEGO = {codigoJuego}";
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    int codigo_juego = (int)lector["CODIGO_JUEGO"];
                    int codigo_usuario = (int)lector["CODIGO_USUARIO"];
                    string nombre = lector["NOMBRE"].ToString();
                    double precio = (double)lector["PRECIO"];
                    string genero = lector["GENERO"].ToString();

                    auxJuego = new Juego(nombre, precio, genero, codigo_juego, codigo_usuario);
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

            return auxJuego;
        }

        public static void Modificar(Juego juego)
        {
            try
            {
                conexion.Open();
                comando.CommandText = "UPDATE JUEGOS\r\nSET PRECIO = @precio, NOMBRE = @nombre, GENERO = @genero\r\nWHERE CODIGO_JUEGO=@codigo_juego\r\n";
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@genero", juego.Genero);
                comando.Parameters.AddWithValue("@codigo_juego", juego.CodigoJuego);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

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
        }

    }
}
