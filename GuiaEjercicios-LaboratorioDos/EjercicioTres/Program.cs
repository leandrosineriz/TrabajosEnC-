using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioTresPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador;
            int num=1;

            Console.WriteLine("Ingrese un numero: ");

            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Error, Reingresar un numero: ");

            }

            for(contador=0;contador<=num;contador++)
            {
                if(contador%2==0)
                {
                    Console.WriteLine(contador);
                }
            }
            Console.Read();
        }
    }
}
