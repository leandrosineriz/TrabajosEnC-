using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioCuatroPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio 4";

            int n;
            int contador=0;
            double resultado;
            for(n=2;contador<4;n++)
            {
                if((n-1)%2==0 || n-1==1)
                {
                    resultado =(Math.Pow(2, (n - 1)) * (Math.Pow(2, n) - 1));
                    contador++;
                    Console.WriteLine(resultado);

                }
                
            }

            Console.Read();

        }
    }
}
