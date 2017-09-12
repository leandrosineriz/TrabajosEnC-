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
                this._cantMaximaColores + "   \nColores: \n";

            for (int i = 0; i < this._cantMaximaColores;i++)
            {
                if (this._colores.GetValue(i) != null)
                {
                    retorno += Tempera.Mostrar(this._colores[i]);
                    retorno += "\n";
                }
                
            }

            return retorno;
        }

        private static int ObtenerIndiceDisponibleEnArray(Paleta unaPaleta)
        {
            int retorno = -1;

            for (int i = 0; i < unaPaleta._cantMaximaColores; i++)
            {
                if (unaPaleta._colores.GetValue(i) == null)
                {
                    retorno = i;
                    break;
                }
            }

            return retorno;


        }

        private static int ObtenerIndiceDisponibleEnArray(Paleta unaPaleta, Tempera unaTempera)
        {
            int retorno = -1;


            for (int i = 0; i < unaPaleta._cantMaximaColores; i++)
            {
                if (unaPaleta._colores.GetValue(i) != null)
                {
                    if (unaPaleta._colores[i] == unaTempera)
                    {
                        retorno = i;
                        break;
                    }

                }
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

            for (int i = 0; i < unaPaleta._cantMaximaColores;i++)
            {
                if (unaPaleta._colores.GetValue(i) != null)
                {
                    if (unaPaleta._colores[i] == unaTempera)
                    {
                        banderaTemperaEnPaleta = true;
                        break;
                    }
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
            int auxDisponible;
         
            auxDisponible=Paleta.ObtenerIndiceDisponibleEnArray(unaPaleta, unaTempera);

            if (auxDisponible != -1)
            {
                unaPaleta._colores[auxDisponible] += unaTempera;
            }
             else
            {
                auxDisponible = Paleta.ObtenerIndiceDisponibleEnArray(unaPaleta);

              if (auxDisponible != -1)
              {
                unaPaleta._colores[auxDisponible] = unaTempera;
              }

            }                                        
            
            
            return unaPaleta;
        }

            
        

        public static Paleta operator -(Paleta unaPaleta, Tempera unaTempera)
        {
            int auxDisponible;
         
            auxDisponible=Paleta.ObtenerIndiceDisponibleEnArray(unaPaleta, unaTempera);

            if (auxDisponible != -1)
            {
                unaPaleta._colores[auxDisponible] = null;
            }
            
            
            return unaPaleta;
        }

        public static Paleta operator +(Paleta unaPaleta, Paleta otraPaleta)
        {
            /*int contadorUnaPaleta = 0;
            int contadorOtraPaleta = 0;
            */
            int auxCantMax = 0;

            /*
            for (int i=0; i < unaPaleta._cantMaximaColores;i++)
            {
                if (unaPaleta._colores.GetValue(i) != null)
                {
                    contadorUnaPaleta++;
                }
            }

            for (int i = 0; i < unaPaleta._cantMaximaColores; i++)
            {
                if (otraPaleta._colores.GetValue(i) != null)
                {
                    contadorOtraPaleta++;
                }
            }
            */

            auxCantMax = unaPaleta._cantMaximaColores + otraPaleta._cantMaximaColores;

            Paleta retornoPaleta = auxCantMax;

            unaPaleta._colores.CopyTo(retornoPaleta._colores, 0);
            otraPaleta._colores.CopyTo(retornoPaleta._colores, unaPaleta._cantMaximaColores);


            return retornoPaleta;

        }


        public void setValueColores(int indice,Tempera unaTempera)
        {
            this._colores[indice] = unaTempera;
 
        }
    }



}
