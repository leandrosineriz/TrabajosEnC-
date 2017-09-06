using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseSeisLibreriaa
{
    public class Paleta
    {
        private Tempera[] _colores;
        private int _cantMaximaColores;

        /// <summary>
        /// CONSTRUCTORES
        /// </summary>
        /// 
        private Paleta() : this(5)
        {

        }

        private Paleta(int cantidadArray)
        {
            this._cantMaximaColores = cantidadArray;
            this._colores = new Tempera[_cantMaximaColores];
        }


        /// <summary>
        /// METODOS
        /// </summary>
        /// <returns></returns>
        /// 
        private string Mostrar()
        {
            string retorno = "Cantidad de Colores: " +
                this._cantMaximaColores + "\nColores: \n";

            foreach (Tempera i in this._colores)
            {
                retorno += Tempera.Mostrar(this._colores[i]);
                retorno += "\n";
            }

            return retorno;
        }

        /// <summary>
        /// SOBRECARGAS
        /// </summary>
        /// <param name="unaPaleta"></param>
        /// <returns></returns>
        /// 
        public static explicit operator string(Paleta unaPaleta)
        {
            return unaPaleta.Mostrar();

        }

        public static implicit operator Paleta(int num)
        {
            return new Paleta(num);
        }


        /// <summary>
        /// SOBRECARGAS EXTRAS CASA
        /// </summary>
        /// <param name="unaPaleta"></param>
        /// <param name="unaTempera"></param>
        /// <returns></returns>

        public static bool operator ==(Paleta unaPaleta, Tempera unaTempera)
        {
            bool banderaTemperaEnPaleta = false;

            foreach (Tempera i in unaPaleta._colores)
            {
                if (unaPaleta._colores[i] == unaTempera)
                {
                    banderaTemperaEnPaleta = true;
                    break;
                }
            }

            return banderaTemperaEnPaleta;
        }

        public static bool operator !=(Paleta unaPaleta, Tempera unaTempera)
        {
            return !(unaPaleta == unaTempera);
        }


        public static Paleta operator +(Paleta unaPaleta, Tempera unaTempera)
        {
            if (unaPaleta != unaTempera)
            {
                foreach (Tempera i in unaPaleta._colores)
                {
                    if (unaPaleta._colores[i] == null)
                    {
                        unaPaleta._colores[i] = unaTempera;
                        break;
                    }
                }
            }

            return unaPaleta;
        }

        public static Paleta operator -(Paleta unaPaleta, Tempera unaTempera)
        {
            if (unaPaleta == unaTempera)
            {
                foreach (Tempera i in unaPaleta._colores)
                {
                    if (unaPaleta._colores[i] == unaTempera)
                    {
                        unaPaleta._colores[i] = null;
                        break;
                    }
                }
            }

            return unaPaleta;
        }

        public static Paleta operator +(Paleta unaPaleta, Paleta otraPaleta)
        {
            int contadorUnaPaleta = 0;
            int contadorOtraPaleta = 0;
            int auxCantMax = 0;


            foreach (Tempera i in unaPaleta._colores)
            {
                if (unaPaleta._colores[i] != null)
                {
                    contadorUnaPaleta++;
                }
            }

            foreach (Tempera i in unaPaleta._colores)
            {
                if (unaPaleta._colores[i] != null)
                {
                    contadorOtraPaleta++;
                }
            }

            auxCantMax = contadorUnaPaleta + contadorOtraPaleta;

            Paleta retornoPaleta = auxCantMax;

            foreach (Tempera i in unaPaleta._colores)
            {
                retornoPaleta = retornoPaleta + unaPaleta._colores[i];
            }

            foreach (Tempera i in otraPaleta._colores)
            {
                retornoPaleta = retornoPaleta + otraPaleta._colores[i];
            }

            return retornoPaleta;

        }
    }

}
