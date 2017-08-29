using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDoce
{
    class Program
    {
        static void Main(string[] args)
        {
            //string binario;
            double numDecimal;
            //binario=Conversor.DecimalBinario(20);
            numDecimal = Conversor.BinarioDecimal("1010");
            //Console.WriteLine(binario);
            Console.Read();
        }
    }
}
