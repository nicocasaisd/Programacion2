using Entidades;
using System;
using System.Collections.Generic;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listaPersonas;

            listaPersonas = PersonaDAO.Leer();

            if(listaPersonas.Count != 0)
            {
                foreach(Persona persona in listaPersonas)
                {
                    Console.WriteLine($"ID: {persona.Id} , Nombre: {persona.Nombre}, Apellido: {persona.Apellido}");
                }
            }
            else
            {
                Console.WriteLine("La lista de personas está vacía.");
            }


        }
    }
}
