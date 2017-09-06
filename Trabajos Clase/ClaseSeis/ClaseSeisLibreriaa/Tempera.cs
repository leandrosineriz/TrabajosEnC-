using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseSeisLibreriaa
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private int _cantidad;


        /// <summary>
        /// Constructores
        /// </summary>
        public Tempera()
        {
            this._color = ConsoleColor.Black;
            this._marca = "Sin Marca";
            this._cantidad = 0;        
        }

        public Tempera(ConsoleColor color)
            : this()
        {
            this._color = color;
        }

        public Tempera(ConsoleColor color,string marca):
             this(color)
        {
            this._marca = marca;
        }

        public Tempera(ConsoleColor color, string marca, int cantidad)
            : this(color,marca)
        {
            this._cantidad = cantidad;

        }


        /// <summary>
        /// Metodos
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            return this._color + " " + this._marca + " " + this._cantidad; 
        }

        public static string Mostrar(Tempera unaTempera)
        {
            return unaTempera.Mostrar();
        }

        /// <summary>
        /// Sobrecargas
        /// </summary>
        /// <param name="unaTempera"></param>
        /// <param name="otraTempera"></param>
        /// <returns></returns>
        public static bool operator ==(Tempera unaTempera, Tempera otraTempera)
        {
            bool retorno = false;

            if (unaTempera._color == otraTempera._color && unaTempera._marca == otraTempera._marca)
            {
                retorno = true;
 
            }

            return retorno;
        }

        public static bool operator !=(Tempera unaTempera, Tempera otraTempera)
        {
            return !(unaTempera == otraTempera);
        }

        public static Tempera operator +(Tempera unaTempera, double incrementoCant)
        {
            double auxCantTempera;

            if (incrementoCant > 0)
            {
                auxCantTempera=unaTempera._cantidad + incrementoCant;

                if (auxCantTempera<= 100)
                {
                    unaTempera._cantidad += (int)incrementoCant;
                }

                
            }


            return unaTempera;

        }

        public static implicit operator int(Tempera unaTempera)
        {
            return unaTempera._cantidad;

        }
    }
}
