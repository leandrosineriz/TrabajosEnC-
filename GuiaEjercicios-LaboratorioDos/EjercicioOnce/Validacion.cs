﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validacion
    {

        public static bool Validar(int numero, int minimo, int maximo)
        {
            bool retorno=false;
            if (numero <= maximo && numero >= minimo)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
