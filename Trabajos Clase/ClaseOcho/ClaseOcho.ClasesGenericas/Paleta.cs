using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseOcho.ClasesGenericas
{
    public class Paleta
    {
        private List <Tempera> _colores;
        

        /// <summary>
        /// CONSTRUCTORES
        /// </summary>
        /// 
        public Paleta()
        {
            
            this._colores = new List <Tempera>();

        }

        


        /// <summary>
        /// METODOS
        /// </summary>
        /// <returns></returns>
        /// 
        private string Mostrar()
        {
            string retorno = "";

            foreach(Tempera item in this._colores)
            {  
                retorno += Tempera.Mostrar(item);
                retorno += "\n";        
            }

            return retorno;
        }

          
        public List <Tempera> getTemperas()
        {
            return this._colores;
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


        /// <summary>
        /// SOBRECARGAS EXTRAS CASA
        /// </summary>
        /// <param name="unaPaleta"></param>
        /// <param name="unaTempera"></param>
        /// <returns></returns>

        public static bool operator ==(Paleta unaPaleta, Tempera unaTempera)
        {
            bool banderaTemperaEnPaleta = false;

            foreach(Tempera item in unaPaleta._colores)
            { 
                
                    if (item == unaTempera)
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
            
            if (unaPaleta==unaTempera)
            {
                int auxCant=unaPaleta._colores.Count;

                for (int i = 0; i < auxCant; i++)
                {
                    if (unaPaleta._colores.ElementAt(i) == unaTempera)
                    {
                        unaPaleta._colores[i] += unaTempera;
                        break;
                    }
                }
            }
             else
            {
                unaPaleta._colores.Add(unaTempera);

            }                                        
            
            
            return unaPaleta;
        }

            
        

        public static Paleta operator -(Paleta unaPaleta, Tempera unaTempera)
        {

            if (unaPaleta==unaTempera)
            {
                int auxCant = unaPaleta._colores.Count;

                for (int i = 0; i < auxCant; i++)
                {
                    if (unaPaleta._colores.ElementAt(i) == unaTempera)
                    {
                        unaPaleta._colores.RemoveAt(i);
                        break;
                    }
                }
                
            }
            
            return unaPaleta;
        }

        public static Paleta operator +(Paleta unaPaleta, Paleta otraPaleta)
        {
            Paleta retornoPaleta=new Paleta();

            foreach(Tempera item in unaPaleta._colores)
            {
                retornoPaleta._colores.Add(item);
            }
            foreach (Tempera item in otraPaleta._colores)
            {
                retornoPaleta._colores.Add(item);
            }
            return retornoPaleta;
        }


        public void setValueColores(int indice,Tempera unaTempera)
        {
            this._colores[indice] = unaTempera;
 
        }
    }



}
