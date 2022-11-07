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
            /*
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
                // Preguntamos si la conexion sigue abierta
                if(con.State == System.Data.ConnectionState.Open)
                {
                    // Cerramos la conexión
                    con.Close();
                }
            }
            */

            // ESCRIBIENDO EN LA BASE DE DATOS

            /*
            SqlConnection con2;
            SqlCommand command2;

            con2 = new SqlConnection(connectionString);
            string consulta = "INSERT INTO EMPLEADOS VALUES('Leilani', 'Kinney', 1, 383946.80, 1, '1996-03-21' , null, 'lkinney@gmail.com')";
            command2 = new SqlCommand(consulta, con2);
            con2.Open();


            int filasAfectadas = command2.ExecuteNonQuery();
            if (filasAfectadas == 0)
            {
                // no se pudo ejecutar
                Console.WriteLine("No se pudo ejecutar la query.");
            }
            else
            {
                // se ejecuto
                Console.WriteLine("Query ejecutada con éxito!");
            }
            */

            // UPDATE DE VALORES
            /*
            // Declaramos empleado
            Empleado emp = new Empleado("Marquitos", "Perez", 1, 100, true, "2020-12-12");

            SqlConnection con2;
            SqlCommand command2;

            con2 = new SqlConnection(connectionString);
            //// Esto está mal
            //string consulta = "UPDATE EMPLEADOS " +
            //    $" SET NOMBRE = '{emp._NOMBRE}'" + 
            //    " WHERE ID_EMPLEADO=2";

            // El @ indica que esto va a ser un parámetro
            string consulta = "UPDATE EMPLEADOS SET NOMBRE=@NOMBRE WHERE ID_EMPLEADO=@ID";
            command2 = new SqlCommand(consulta, con2);

            command2.Parameters.AddWithValue("@NOMBRE", emp._NOMBRE);
            command2.Parameters.AddWithValue("@ID", 5);
            con2.Open();

            int filasAfectadas = command2.ExecuteNonQuery();
            if (filasAfectadas == 0)
            {
                // no se pudo ejecutar
                Console.WriteLine("No se pudo ejecutar la query.");
            }
            else
            {
                // se ejecuto
                Console.WriteLine("Query ejecutada con éxito!");
            }
            */

            // HACER UN DELETE DELETE

            SqlConnection con2;
            SqlCommand command2;

            con2 = new SqlConnection(connectionString);
            string consulta = "DELETE FROM EMPLEADOS WHERE ID_EMPLEADO=@ID";
            command2 = new SqlCommand(consulta, con2);


            command2.Parameters.AddWithValue("@ID", 3);
            con2.Open();

            int filasAfectadas = command2.ExecuteNonQuery();
            if (filasAfectadas == 0)
            {
                // no se pudo ejecutar
                Console.WriteLine("No se pudo ejecutar la query.");
            }
            else
            {
                // se ejecuto
                Console.WriteLine("Query ejecutada con éxito!");
            }
        }
    }
}
