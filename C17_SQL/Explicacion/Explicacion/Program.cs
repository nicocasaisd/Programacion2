using System;
using System.Data.SqlClient;

namespace Explicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con;
            SqlCommand command;
            SqlDataReader reader;

            string connectionString = "Server=.;Database=EMPRESA_DB;Trusted_Connection=True;";

            con = new SqlConnection(connectionString); // recibe un string de conexión
            // Hay que abrir la conexion
            con.Open();

            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;

            command.Connection = con;

            command.CommandText = "SELECT * FROM EMPLEADOS";

            // Realizamos la consulta y la guardamos en un objeto DataReader
            reader = command.ExecuteReader();

            // Lee de a 1 solo registro
            reader.Read();

            // Accedemos a los datos
            string nombre = reader["NOMBRE"].ToString();
            // Otras formas de acceder a los datos
            double sueldo = (double)reader[4];
            int id = reader.GetInt32(3);

            // Mostramos los datos
            //Console.WriteLine($"Nombre: {nombre}   Sueldo: {sueldo} Id: {id}");

            // Lo metemos dentro de un bloque try-catch
            try
            {
                // Bucle para leer
                while (reader.Read())
                {
                    // Accedemos a los datos
                    string n = reader["NOMBRE"].ToString();
                    // Otras formas de acceder a los datos
                    double s = (double)reader[4];
                    int i = reader.GetInt32(3);

                    //Instanciamos un empleado
                    Empleado emp = new Empleado(n, i, s);

                    // Mostramos los datos
                    Console.WriteLine($"Nombre: {emp.nombre}   Sueldo: {emp.sueldo} Id: {emp.id_puesto}");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                // Cerramos la conexión
                con.Close();
            }
            
            



            
        }
    }
}
