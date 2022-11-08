using Entidades;
using System;


namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(Usuario item in UsuarioDAO.Leer())
            {
                Console.WriteLine(item);
            }

            foreach(Biblioteca item in JuegoDAO.Leer())
            {
                Console.WriteLine(item.CodigoJuego);
            }
        }
    }
}
