using System;
using C12_Ejercicio01;
using Entidades;

namespace C12_E01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Torneo<EquipoDeFutbol> torneoDeFutbol = new Torneo<EquipoDeFutbol>();
            EquipoDeFutbol ef1 = new EquipoDeFutbol("f1", DateTime.Now);
            EquipoDeFutbol ef2 = new EquipoDeFutbol("f2", DateTime.Now);
            EquipoDeFutbol ef3 = new EquipoDeFutbol("f3", DateTime.Now);

            _ = torneoDeFutbol + ef1;
            _ = torneoDeFutbol + ef2;
            _ = torneoDeFutbol + ef3;

            Console.WriteLine(torneoDeFutbol.Mostrar());
            Console.WriteLine(torneoDeFutbol.JugarPartido);
            Console.WriteLine(torneoDeFutbol.JugarPartido);
            Console.WriteLine(torneoDeFutbol.JugarPartido);




        }
    }
}
