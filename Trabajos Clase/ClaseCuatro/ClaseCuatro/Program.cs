using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCuatro
{
    class Program
    {
        enum eCosa { cosaUno=25, cosaDos , cosaTres }

        static void Main(string[] args)
        {
            Cosa cosita = new Cosa(DateTime.UtcNow,8,"Cosita");
            ConsoleColor color = ConsoleColor.Cyan;
            //DateTime fechaAhora=;
            
            /*cosita.EstablecerValor(1);
            cosita.EstablecerValor("Hola");
            //con el constructor se pueden pasar los valores de una fecha en int
            cosita.EstablecerValor(new DateTime(2017,08,29,09,51,10));
            */

            Random numeroRandom=new Random();
            int num;
            int contador=0;
            int contadorRojo = 0;
            int contadorVerde = 0;
            int contadorMagenta = 0;

            
            while (contador < 100)
            {
                num=numeroRandom.Next(1, 70);
                contador++;
            switch (num)
            {
                    
                case 1: color = ConsoleColor.Green;
                    contadorVerde++;
                    break;
                case 2:
                    color = ConsoleColor.Magenta;
                    contadorMagenta++;
                        break;
                case 3:
                    color=ConsoleColor.Red;
                    contadorRojo++;
                        break;
                
                default:
                        color = ConsoleColor.Red;
                        contadorRojo++;
                    break;
            }
                Console.WriteLine(cosita.Mostrar(color));
 
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Rojos:" + contadorRojo + "Verdes:" + contadorVerde + "Magenta:" + contadorMagenta);

            Console.Read();
        }
    }
}
