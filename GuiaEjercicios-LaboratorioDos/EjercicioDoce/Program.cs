using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respuesta;
            int numero;
            int sumaNumeros=0;

            do
            {
                Console.WriteLine("Ingrese un numero:");

                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Error. Ingrese un numero:");
                }

                sumaNumeros += numero;


                respuesta = ValidarRespuesta.ValidaS_N();
            } while (respuesta == true);

            Console.WriteLine("La suma de los numeros es: "+sumaNumeros);
            Console.Read();
            
        }
    }
}
