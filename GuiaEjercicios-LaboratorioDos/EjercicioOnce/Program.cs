using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0;
            int contador;
            bool respuesta;
            int valorMinimo=0;
            int valorMaximo=0;
            int promedio;
            int sumaNumeros=0;

            

            for (contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("Ingrese un numero:");

                while (!int.TryParse(Console.ReadLine(),out numero))
                {
                    Console.WriteLine("Error. Reingrese un numero:");
                }

                respuesta = Validacion.Validar(numero, -100, 100);
                while (!respuesta)
                {
                    Console.WriteLine("Error. Reingrese un numero:");

                    while (!int.TryParse(Console.ReadLine(),out numero))
                    {
                        Console.WriteLine("Error. Reingrese un numero:");
                    }

                    respuesta = Validacion.Validar(numero, -100, 100);
 
                }

                if (contador == 0)
                {
                    valorMaximo = numero;
                    valorMinimo = numero;
                }
                else if (numero > valorMaximo)
                {
                    valorMaximo = numero;
                }
                else if (numero < valorMinimo)
                {
                    valorMinimo = numero;
                }

                sumaNumeros += numero;
            }

            promedio = sumaNumeros / contador;

            Console.WriteLine("el maximo es: "+valorMaximo+" el valor minimo es: "+valorMinimo+" el promedio es: "+promedio);
            Console.Read();
        }
    }
}
