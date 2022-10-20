using System;
using Biblioteca;

namespace I02_Contabilidad
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            Recibo r1 = new Recibo(1);
            Recibo r2 = new Recibo(2);
            Recibo r3 = new Recibo(3);

            Factura f1 = new Factura(1);
            Factura f2 = new Factura(2);

            _ = contabilidad + r1;
            _ = contabilidad + r3;
            _ = contabilidad + r2;

            _ = contabilidad + f1;
            _ = contabilidad + f2;
        }
    }
}
