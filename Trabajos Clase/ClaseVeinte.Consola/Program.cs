using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseVeinte.Library;
using System.Data;

namespace ClaseVeinte.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ProveedorDeDatos proveedor = new ProveedorDeDatos();
            //List<Persona> personas = proveedor.ObtenerPersonaBD();
            DataTable personasDT = proveedor.ObtenerPersonaBD(true);
            //DataRow personasDR 
            Console.WriteLine(personasDT.IsInitialized);

            /*
            foreach (Persona i in personas)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(proveedor.ObtenerPersonaPorIDBD(1));


            Persona aux3 = new Persona(8, "Nuevo", "NUEVONUEVO", 66);


            if (proveedor.AgregarPersonaBD(aux3))
            {
                Console.WriteLine("<--------------------------------------------------------------->");

                personas = proveedor.ObtenerPersonaBD();

                foreach (Persona i in personas)
                {
                    Console.WriteLine(i);
                }
            }
            
            if (proveedor.EliminarPersonaBD(aux3))
            {
                Console.WriteLine("<--------------------------------------------------------------->");

                personas = proveedor.ObtenerPersonaBD();

                foreach (Persona i in personas)
                {
                    Console.WriteLine(i);
                }
            }

            Persona aux1 = new Persona(1, "Modificado", "MODIFICADO", 66);

            if (proveedor.ModificarPersonaBD(aux1))
            {
                Console.WriteLine("<--------------------------------------------------------------->");

                personas = proveedor.ObtenerPersonaBD();

                foreach (Persona i in personas)
                {
                    Console.WriteLine(i);
                }
            }
            
            */
           
            Console.ReadKey();


        }
    }
}
