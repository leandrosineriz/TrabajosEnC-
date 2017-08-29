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
            int sumaDeLosNumeros=0;
            float promedio=0;
            int primerNumeroPar=0;
            bool primerNumeroParEncontrado=false;
            int ultimoNumeroImpar=0;
            int cantidadDePares=0;
            int lugarDelPrimerPar=0;
            int lugarDelUltimoImpar=0;
            int contador = 0;

            //int i; (que es i??)
            //bool flag =true; (tiro a las flags) 

            for ( contador = 1; contador <= 7; contador++)
            {
                Console.WriteLine("Ingrese un numero: ");
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Error, Ingrese un numero: ");

                }
                if (contador == 1)
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

                sumaDeLosNumeros += num;

                if(num%2==0 && primerNumeroParEncontrado==false)
                {
                    primerNumeroPar = num;
                    primerNumeroParEncontrado = true;
                    lugarDelPrimerPar = contador;
                }

                if(num%2!=0)
                {
                    ultimoNumeroImpar = num;
                    lugarDelUltimoImpar = contador;
                }

                if(num%2==0)
                {
                    cantidadDePares++;
                }




            }

            promedio = (float)sumaDeLosNumeros / contador;


            Console.WriteLine("El mayor es: " + numeroMayor + " y el menor es: " + numeroMenor);
            Console.WriteLine("La suma de los numeros es:" + sumaDeLosNumeros + " y su promedio es:" + promedio);
            Console.WriteLine("El primer numero par es:" + primerNumeroPar + " ,la posicion del primer par es:" + lugarDelPrimerPar + " y la cantidad de pares es:" + cantidadDePares);
            Console.WriteLine("El ultimo numero impar es:" + ultimoNumeroImpar + ",la posicion del ultimo impar es:" + lugarDelUltimoImpar);
            Console.Read();
        }
    }
}
