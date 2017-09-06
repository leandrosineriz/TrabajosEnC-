using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseSeisLibreriaa;
using Entidades.Clases;

namespace ClaseSeis
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Tempera unaTempera = new Tempera(ConsoleColor.Blue, "BIC", 10);
            Tempera otraTempera = new Tempera(ConsoleColor.Blue, "BIC", 50);
            double incremento = 90;
            int cantidad;

            if (unaTempera == otraTempera)
            {
                unaTempera += incremento;

                cantidad = otraTempera;

                Console.WriteLine(Tempera.Mostrar(unaTempera)+" CANTIDAD: "+cantidad);

            }
            else
            {
                Console.WriteLine("no son iguales");
            }
            */

            Paleta unaPaleta = 10;

            Console.WriteLine(unaPaleta);

            Console.Read();
        }
    }
}
