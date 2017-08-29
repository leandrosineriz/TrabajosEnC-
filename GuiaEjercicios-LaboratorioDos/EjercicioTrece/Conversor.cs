using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDoce
{
    class Conversor
    {

        public static string DecimalBinario(double numero)
        {
            string retorno="";
       
            while(numero>1)
            {
               if (numero % 2 == 0)
             {
                retorno += "0";

             } if (numero % 2 == 1)
             {
                retorno += "1";
                numero--;
             }

             numero=numero/2;
            }
              
            if (numero == 1)
            {
               retorno += "1";
            }
            else if(numero == 0)
            {
                retorno+="0";
            }

            return retorno;
 
        }

        public static double BinarioDecimal(string binario)
        {
            double retorno=0;
            int catidadDeBit;
            string ultimoElemento;
            int contador;
            catidadDeBit = binario.Length;
            for (contador = 0; contador < catidadDeBit;contador++)
            {
                ultimoElemento = binario.Substring(contador, 1);
            }
            


            return retorno;
 
        }
    }
}
