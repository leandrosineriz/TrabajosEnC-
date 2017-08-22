using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnoPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title= "Ejercicio 1";

            
            int num;
            double cuadradoDeNum;
            double cuboDeNum;


            Console.WriteLine("Ingrese un numero positivo: ");
          
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Error, Reingresar un numero: ");

            }
            
            while(num<=0)
            {
                Console.WriteLine("Error, Reingresar un numero: ");

                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Error, Reingresar un numero: ");

                }
            }

            cuadradoDeNum=Math.Pow(num, 2);
            cuboDeNum = Math.Pow(num, 3);

            Console.WriteLine("El cuadrado del numero: " + num + " es: " + cuadradoDeNum + " y su cubo es: " + cuboDeNum);
            Console.Read();


        }
    }
}
