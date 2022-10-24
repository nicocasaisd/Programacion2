using System;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				MiClase objeto = new MiClase();
			}
			catch (UnaExcepcion ex)
			{
				Console.WriteLine(ex);
				
			}
        
		}
    }
}
