using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(
                () =>
                {
                    Console.WriteLine("Inicia task 1");
                    try
                    {
                        throw new Exception("Desde el hilo 1 tiro la excepcion");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                );
            Task t2 = new Task(() =>
            {
                Console.WriteLine("Inicia task 2");
                //throw new Exception("Desde adentro del hilo 2");
                Console.WriteLine("Mensaje desde el hilo 2");
            });

            t1.Start();
            try
            {
                t2.Start();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error atrapado en el try externo");
            }

            Task.WaitAll(t1,t2);
            Console.WriteLine("Fin del programa");
        }

        //public delegate void DelegadoAccion();

            

    }
}
