using System;
using Entidades;

namespace C03_Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos los boligrafos
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);
            string dibujo;

            // Pruebo Pintar() con azul

            boligrafoAzul.Pintar(3, out dibujo);
            boligrafoAzul.DibujarEnConsola(dibujo);
            Console.WriteLine($"Boligrafo azul: {boligrafoAzul.GetTinta()}/{Boligrafo.cantidadTintaMaxima}");

            // Pruebo Pintar() con rojo
            boligrafoRojo.Pintar(20, out dibujo);
            boligrafoRojo.DibujarEnConsola(dibujo);
            Console.WriteLine($"Boligrafo rojo: {boligrafoRojo.GetTinta()}/{Boligrafo.cantidadTintaMaxima}");

            // Pruebo que se acabe la tinta
            if(!boligrafoRojo.Pintar(40, out dibujo))
            {
                Console.WriteLine("No tiene suficiente tinta para gastar.");
            }
            boligrafoRojo.DibujarEnConsola(dibujo);
            Console.WriteLine($"Boligrafo rojo: {boligrafoRojo.GetTinta()}/{Boligrafo.cantidadTintaMaxima}");

            // Recargo la tinta
            boligrafoRojo.Recargar();
            Console.WriteLine($"Boligrafo rojo: {boligrafoRojo.GetTinta()}/{Boligrafo.cantidadTintaMaxima}");
            // Lo descargo manualmente
            if (!boligrafoRojo.Pintar(40, out dibujo))
            {
                Console.WriteLine("No tiene suficiente tinta para gastar.");
            }
            boligrafoRojo.DibujarEnConsola(dibujo);
            Console.WriteLine($"Boligrafo rojo: {boligrafoRojo.GetTinta()}/{Boligrafo.cantidadTintaMaxima}");


        }
    }
}
