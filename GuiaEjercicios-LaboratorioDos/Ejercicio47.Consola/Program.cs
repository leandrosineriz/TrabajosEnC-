using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio47;

namespace Ejercicio47.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> c1 = new Contabilidad<Factura, Recibo>();
            Contabilidad<Recibo, Documento> c2 = new Contabilidad<Recibo, Documento>();
            Recibo r1 = new Recibo(1);

            c1 += r1;

            Console.WriteLine(c1);
            Console.Read();

        }
    }
}
