using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        
        public Tinta()
        {
            this._color = ConsoleColor.Black;
            this._tipo = ETipoTinta.comun;
        }
        public Tinta(ETipoTinta tipoTinta):this()
        {
            this._tipo = tipoTinta;       
        }
        public Tinta(ETipoTinta tipoTinta, ConsoleColor color)
            : this(tipoTinta)
        {
            this._color = color;
        }

        
        private string Mostrar()
        {
            return "Color Tinta:"+this._color +"\nColor Tipo:"+this._tipo;
        }
        static public string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        //Comparar objetos de tipo tinta

        public static bool operator ==(Tinta tintaUno,Tinta tintaDos)
        {
            bool retorno= false;
            if (tintaUno._color == tintaDos._color && tintaDos._tipo == tintaUno._tipo)
            {
                retorno = true;
            }

            return retorno;
        }
        //Esto es poco eficiente por que la logica es mas compleja con mas atributos
        /*
        public static bool operator !=(Tinta tintaUno, Tinta tintaDos)
        {
            bool retorno = true;
            if (tintaUno._color == tintaDos._color && tintaDos._tipo == tintaUno._tipo)
            {
                retorno = false;
            }

            return retorno;
        }
         */


        //El opuesto debe ser de esta forma para asegurarse de que funcione
        public static bool operator !=(Tinta tintaUno, Tinta tintaDos)
        {
            return !(tintaUno == tintaDos);
        }


        //Sobrecarga de Conversores de Tipo Para que retorne un string

        /*public static explicit operator string(Tinta tinta)
        {

            return tinta.Mostrar();
        }*/

        public static implicit operator string(Tinta tinta)
        {

            return tinta._tipo.ToString();
        }

    }
}
