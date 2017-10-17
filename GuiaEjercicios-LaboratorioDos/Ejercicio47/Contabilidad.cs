using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public class Contabilidad<T , U >
        where U : new()
    {
        private List<T> _egresos;
        private List<U> _ingresos;


        public  Contabilidad()
        {            
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            c._egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c._ingresos.Add(ingreso);
            return c;
        }

        public override string ToString()
        {
            string retorno = "Egresos:\n";

            foreach (T i in this._egresos)
            {
                retorno += i+"\n";
            }

            retorno += "Ingresos:\n";

            foreach (U i in this._ingresos)
            {
                retorno += i + "\n";
            }


            return retorno;
        }
 

    }
}
