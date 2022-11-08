using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioDAO
    {
        public static string cadenaConexion;
        public static SqlCommand comando;
        public static SqlConnection conexion;

        static UsuarioDAO()
        {
            // Constructor estático
            cadenaConexion = "Server=.;Database=EJERCICIOS_UTN;Trusted_Connection=True;";
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            SqlDataReader lector;

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT CODIGO_USUARIO, USERNAME FROM USUARIOS";
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Usuario aux = new Usuario(lector["USERNAME"].ToString(), (int)lector["CODIGO_USUARIO"]);
                    listaUsuarios.Add(aux);
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


            return listaUsuarios;
        }

    }
}
