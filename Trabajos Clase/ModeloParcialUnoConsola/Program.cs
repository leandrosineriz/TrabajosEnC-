using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloParcialUnoLibreria;

namespace ModeloParcialUnoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero unLavadero = new Lavadero("Lavadero Juancito");
            Moto unaMoto = new Moto("FFF", EMarcas.Fiat, 2, 60);
            Camion unCamion = new Camion("AAA", EMarcas.Iveco, 6, 500);
            Auto unAuto = new Auto("CCC", EMarcas.Honda, 4);
            unLavadero += unaMoto;
            unLavadero += unCamion;
            unLavadero += unAuto;

            Console.WriteLine(unLavadero.MiLavadero);
            Console.WriteLine(unLavadero.MostrarTotalFacturado());
            Console.WriteLine(unLavadero.MostrarTotalFacturado(EVehiculos.Camion));
            Console.WriteLine("\n\n\nOrdenar Por Patente:");

            unLavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine(unLavadero.MiLavadero);           
            

            Console.WriteLine("\n\n\nOrdenar Por Marca:");
            unLavadero.Vehiculos.Sort(unLavadero.OrdenarVehiculosPorMarca);
            Console.WriteLine(unLavadero.MiLavadero);           


            Console.WriteLine("\n\n\n");
            unLavadero -= unaMoto;
            Console.WriteLine(unLavadero.MiLavadero);
            Console.WriteLine(unLavadero.MostrarTotalFacturado());



            Console.Read();
        }
    }
}
