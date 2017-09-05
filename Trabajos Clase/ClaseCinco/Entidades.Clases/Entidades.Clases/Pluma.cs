using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;


        //Constructores

        public Pluma()
        {
            this._marca = "Sin Marca";
            this._tinta = null;
            this._cantidad = 0;
        }

        public Pluma(string marca):this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, Tinta tinta)
            : this(marca)
        {
            this._tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad)
            : this(marca, tinta)
        {
            this._cantidad = cantidad;
        }

        //Metodos

        private string Mostrar()
        {
            return "Marca: " + this._marca + "\nTinta: " + this._tinta + "\nCantidad: " + this._cantidad;
 
        }


        //Sobrecargas

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            bool retorno=false;

            if (pluma._tinta == tinta)
            {
                retorno = true;
 
            }

            return retorno;
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta && pluma._cantidad<=100)
            {
                pluma._cantidad++;
            }
            return pluma;
        }

        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta && pluma._cantidad>=0)
            {
                pluma._cantidad--;
            }
            return pluma;
        }

        public static explicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }

    }
}
