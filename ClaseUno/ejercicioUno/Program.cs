using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            //numeros: 3,4,5,10,8,2,1
            //sacar todos los datos.

            int num;
            int numeroMayor=0; //inicializamos las variables que comparamos.
            int numeroMenor=0;
            int sumaNumeros;
            int promedio;
            int primerNumeroPar;
            int ultimoNumeroImpar;
            int cantidadDePares;
            int lugarDelPrimerPar;
            int lugarDelUltimoPar;

            //int i; (que es i??)
            //bool flag =true; (tiro a las flags) 

            for (int contador = 0; contador < 5; contador++)
            {
                Console.WriteLine("Ingrese un numero: ");
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Error, Ingrese un numero: ");

                }
                if (contador == 0)
                {
                    numeroMayor = num;
                    numeroMenor = num;
                }
                else if (num > numeroMayor)
                {
                    numeroMayor = num;
                }
                else if (num < numeroMenor)
                {
                    numeroMenor = num;
                }


            }

            Console.WriteLine("El mayor es: " + numeroMayor + " y el menor es: " + numeroMenor);
            Console.Read();
        }
    }
}
