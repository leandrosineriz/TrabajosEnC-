using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTrece
{
    public class Numero
    {
        protected int _numero;

        public int Valor { get { return this._numero; } }

        public Numero(int numero)
        {
            this._numero = numero;
 
        }

        public static int operator +(Numero uno, Numero Dos)
        {
            return uno.Valor + Dos.Valor;
        }

        public static int operator -(Numero uno, Numero Dos)
        {
            return uno.Valor - Dos.Valor;
        }

        public static int operator *(Numero uno, Numero Dos)
        {
            return uno.Valor * Dos.Valor;
        }

        public static double operator /(Numero uno, Numero Dos)
        {
            return (double)uno.Valor / Dos.Valor;
        }
    }
}
