using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTresRueda_Auto_Ejercicio
{
    enum eFabricante { Ford=1, Chevrolet, Honda };

    class Program
    {
        static void Main(string[] args)
        {
           // Auto miAuto = new Auto();
            //Rueda miRueda = new Rueda();
            
            eFabricante fabricante=eFabricante.Ford;

            Console.Write(fabricante);
            Console.Read();

            

        }
    }
}
