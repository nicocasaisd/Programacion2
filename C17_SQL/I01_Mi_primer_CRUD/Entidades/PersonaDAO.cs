using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PersonaDAO
    {
        // Atributos estaticos
        static string connectionString;
        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader lector;

        static PersonaDAO()
        {
            // Constructor estático
            connectionString = "Server=.;Database=MICRUD_DB;Trusted_Connection=True;";
            // instancio la conexion y le paso el string de conexion
            conexion = new SqlConnection(connectionString);
            // instancio el objeto comando y seteo sus propiedades
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static void Guardar()
        {

        }

        public static List<Persona> Leer()
        {
            List<Persona> listaPersonas = new List<Persona>();

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT * FROM Personas";
                lector = comando.ExecuteReader();
                // bucle
                while(lector.Read())
                {
                    int id = (int)lector["ID"];
                    string nombre = lector["Nombre"].ToString();
                    string apellido = lector["Apellido"].ToString();

                    Persona auxiliar = new Persona(id, nombre, apellido);
                    listaPersonas.Add(auxiliar);
                }

            }
            catch (Exception)
            {
                throw new Exception("No se pudo leer de la base de datos.");
            }
            finally
            {
                if(conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return listaPersonas;
        }

        public static void LeerPorId()
        {

        }

        public static int Modificar(int id, string nombre, string apellido)
        {
            int retorno = 0;

            try
            {
                conexion.Open();
                // Ejecucion parametrizada
                comando.CommandText = "UPDATE Personas SET Nombre = @Nombre , Apellido = @Apellido"+
                                    " WHERE ID = @Id";
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Id", id);
                //Ejecuto
                retorno = comando.ExecuteNonQuery();
                // Clear parametros
                comando.Parameters.Clear();

            }
            catch (Exception)
            {

                throw new Exception("No se pudo conectar a la base de datos");
            }
            finally
            {
                if(conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return retorno;
        }

        public static void Borrar()
        {

        }

    }
}
