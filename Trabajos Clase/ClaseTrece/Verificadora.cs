using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTrece
{
    public static class Verificadora
    {
        public static int MyProperty { get; set; }

        public static bool VerificarNumero(Numero num, ETipoNumero tipo)
        {
            bool retorno = false;

            switch (tipo)
            {
                case ETipoNumero.Par:
                    if (num.Valor % 2 == 0)
                        retorno = true;
                    break;
                case ETipoNumero.Impar:
                    if (num.Valor % 2 != 0)
                        retorno = true;
                    break;
                case ETipoNumero.Positivo:
                    if (num.Valor > 0)
                        retorno = true;
                    break;
                case ETipoNumero.Negativo:
                    if (num.Valor < 0)
                        retorno = true;
                    break;
                case ETipoNumero.Cero:
                    if (num.Valor == 0)
                        retorno = true;
                    break;
                default:
                    break;
            }



            return retorno;
        }
    }
}
