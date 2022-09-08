using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bus
    {
        // Atributo estático utilizada por todas las instancias de Bus.
        // Representa la hora en que el primer autobús del día inicia su ruta.
        public static DateTime horaDeInicio;

        //atributo de instancia
        public int numeroDeRuta;

        // Constructor estático para inicializar la variable estática.
        // Se invoca antes de que se ejecute el constructor de la primera instancia.
        static Bus()
        {
            horaDeInicio = DateTime.Now;

            // La siguiente declaración produce la primera línea de salida,
            // y la línea aparece solo una vez.
            Console.WriteLine("El constructor estático establece la hora de inicio en {0}",
                horaDeInicio.ToLongTimeString());
        }

        // Constructor de instancia.
        public Bus(int numeroDeRuta)
        {
            this.numeroDeRuta = numeroDeRuta;
            Console.WriteLine("Bus #{0} creado.", numeroDeRuta);
        }

        // Metodo de instancia.
        public void Conducir()
        {
            TimeSpan tiempoTrascurrido = DateTime.Now - horaDeInicio;

            // Para fines de demostración, tratamos los milisegundos como minutos para simular
            // tiempos reales de autobús. ¡No haga esto en su programa!
            Console.WriteLine($"{ this.numeroDeRuta } está comenzando su ruta { tiempoTrascurrido.Milliseconds } minutos después de la hora de inicio { horaDeInicio.ToShortTimeString() }.");
        }
    }
}
