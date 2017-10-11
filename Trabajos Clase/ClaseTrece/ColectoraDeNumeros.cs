using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTrece
{
    public class ColectoraDeNumeros
    {
        private List<Numero> numeros;

        public ETipoNumero Numeros { get; set; }

        public double Suma { get { return ObtenerResultado(this, ETipoResultado.Suma); } }

        public double Resta { get { return ObtenerResultado(this, ETipoResultado.Resta); } }

        public double Divicion { get { return ObtenerResultado(this, ETipoResultado.Divicion); } }

        public double Multiplicacion { get { return ObtenerResultado(this, ETipoResultado.Multiplicacion); } }

        public ColectoraDeNumeros()
        {
            this.numeros = new List<Numero>();
        }

        public ColectoraDeNumeros(ETipoNumero tipo)
            : this()
        {
            this.Numeros = tipo;
        }

        public static ColectoraDeNumeros operator +(ColectoraDeNumeros Colectora, Numero num)
        {
            if (!Verificadora.VerificarNumero(num, Colectora.Numeros))
            {
                throw new FormatException("Error numero no corresponde al tipo");

            }
            else
            { 
                Colectora.numeros.Add(num);
            }
        
            return Colectora;
        }

        public static ColectoraDeNumeros operator -(ColectoraDeNumeros Colectora, Numero num)
        {
                try
                {
                    if (!(Colectora == num))
                    {
                
                       throw new Exception("El numero no se encuentra en la lista");
                                         
                    }
                    else
                    {
                       foreach (Numero i in Colectora.numeros)
                       {
                           if (i.Valor == num.Valor)
                           {
                              Colectora.numeros.Remove(i);
                              break;
                           }
                       }
 
                    }
                }
                catch (Exception e)
                {

                    throw e;
                    //Console.WriteLine(e.Message);
                }
            return Colectora;
        }

        public static bool operator ==(ColectoraDeNumeros Colectora, Numero num)
        {
            bool retorno=false;
            
            foreach (Numero i in Colectora.numeros)
            {
                if (i.Valor == num.Valor)
                {
                    retorno = true;
                    break;
                }
            }


            return retorno;
        }

        public static bool operator !=(ColectoraDeNumeros Colectora, Numero num)
        {
            return !(Colectora == num);
        }

        public override string ToString()
        {
            string retorno = "";
            
            foreach (Numero i in this.numeros)
            {
                retorno+=i.Valor+"\n";
            }

            return retorno;
        }


        public static double ObtenerResultado(ColectoraDeNumeros cn, ETipoResultado tipo)
        {
            double retorno=0;
            for (int i = 0; i < cn.numeros.Count; i++)
            {
                if (i == 0)
                {
                    retorno = cn.numeros[i].Valor;
                    continue;
                }

                switch (tipo)
                {
                    case ETipoResultado.Suma:
                        retorno += cn.numeros[i].Valor;
                        break;
                    case ETipoResultado.Resta:
                        retorno -= cn.numeros[i].Valor;
                        break;
                    case ETipoResultado.Divicion:
                        retorno /= cn.numeros[i].Valor;
                        break;
                    case ETipoResultado.Multiplicacion:
                        retorno *= cn.numeros[i].Valor;
                        break;
                    default:
                        break;
                }
                
            }

            return retorno;
        }

       
    }
}
