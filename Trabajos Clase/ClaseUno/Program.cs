using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseUno
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numeroUno;
            int numeroDos;
            int resultado;
            string dato; 
            bool esNumero;     

            Console.WriteLine("Ingrese el numero uno:");
           // dato = Console.ReadLine();
           // esNumero = int.TryParse(Console.ReadLine(), out numeroUno);

            while (!int.TryParse(Console.ReadLine(), out numeroUno))
            {
                Console.WriteLine("error ,Ingrese el numero uno:");
               // dato = Console.ReadLine();
              //  esNumero = int.TryParse(Console.ReadLine(), out numeroUno);
            
            }

            Console.WriteLine("Ingrese el numero Dos:");
            dato = Console.ReadLine();
            numeroDos = int.Parse(dato);

            resultado = numeroUno + numeroDos;

            Console.Write("El resultado es: " + resultado);

            Console.Read();
        }
    }
}
