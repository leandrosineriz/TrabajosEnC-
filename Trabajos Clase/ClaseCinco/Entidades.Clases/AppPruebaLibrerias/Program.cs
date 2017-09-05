using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clases;

namespace AppPruebaLibrerias
{
    class Program
    {
        static void Main(string[] args)
        {
            Entidades.Clases.Tinta unaTinta=new Entidades.Clases.Tinta();
            Tinta otraTinta = new Tinta(ETipoTinta.comun);
            Pluma unaPluma = new Pluma("Bic", otraTinta);
            /*
            if (unaTinta == otraTinta)
            {
                Console.WriteLine(Tinta.Mostrar(unaTinta));
            }
            else
            {
                Console.WriteLine("No son Iguales");
            }
             * */
            /*
            //Mostrando con una sobrecarga de conversor
            Console.WriteLine((string)otraTinta);
            Console.Read();
            */
            int contador = 0;
            while (contador<100)
            {
                contador++;
                unaPluma = unaPluma + unaTinta;
                Console.WriteLine((string)unaPluma);
 
            }
            contador = 0;
            while (contador < 100)
            {
                contador++;
                unaPluma = unaPluma - unaTinta;
                Console.WriteLine((string)unaPluma);

            }
            Console.Read();
            

            
        }
    }
}
