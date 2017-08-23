using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N()
        {
            string respuesta;
            bool retorno = false;
            Console.WriteLine("Ingrese S para continuar o N para salir");

            respuesta=Console.ReadLine();
            respuesta = respuesta.ToLower();

            while (respuesta != "n" && respuesta != "s")
            {
                Console.WriteLine("Error. reingrese S para seguir o N para salir");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToLower();
            }

            if (respuesta == "s")
            {
                retorno = true;

            }

            return retorno;



        }

    }
}
