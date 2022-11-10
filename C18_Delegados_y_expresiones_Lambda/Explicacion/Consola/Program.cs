using System;
using System.Reflection.Metadata.Ecma335;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int,int> lambda = (n1, n2) => Console.WriteLine($"{n1}, {n2}");
            lambda += (a1, a2) => Console.WriteLine($"{a1*a1}, {a2*a2}");
            lambda += (c1, c2) => { _ = c1 * c2; };
            lambda += (c1, c2) =>  _ = c1 * c2;
            // lambda += (c1, c2) => {  return c1 * c2; }; // no se puede porque debe retornar void

            lambda(12, 101);

            Func<int, int, bool> lambdaComparador;

            lambdaComparador = (a1, a2) => a1 == a2;
            lambdaComparador = (a1, a2) => { return a1 == a2; };
            lambdaComparador = (s1, s2) => { return s1 >= s2; };
            lambdaComparador = (x, y) => { return false; };
            lambdaComparador = (x, y) => 
            { 
                return false; 
            };

        }
    }
}
