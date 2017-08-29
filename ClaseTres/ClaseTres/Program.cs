using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTres
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan diferenciaTiempo;
            double dias;
            Auto A1 = new Auto("Fiat","A001",130.000f);
            Auto A2 = new Auto("Ford","BOOZ",80.000f);
            diferenciaTiempo = Auto.f_ultimo - Auto.f_inicio;
            dias = diferenciaTiempo.TotalDays;
            Console.WriteLine("A1:" + Auto.Mostrar(A1) + "\nA2:" + Auto.Mostrar(A2)+"\nCantidad de instancias:"+Auto.cantInstancias+"\nFecha Primer Auto:"+Auto.f_inicio+"\nFecha Ultimo Auto:"+Auto.f_ultimo+"\nDiferencia tiempo:"+diferenciaTiempo+"\nDias:"+dias);
            Console.Read();

        }
    }
}
