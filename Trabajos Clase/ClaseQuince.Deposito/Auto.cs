using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseQuince.Deposito
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color { get { return this._color; } }

        public string Marca { get { return this._marca; } }

        public Auto()
        { }

        public Auto(string color,string marca)
        {
            this._color = color;
            this._marca = marca;

        }

        public static bool operator ==(Auto a,Auto b)
        {
            bool retorno = false;

            if (string.Compare(a.Color,b.Color)==0 && string.Compare(a.Marca,b.Marca)==0)
            {
                retorno = true;
            }

            return retorno;     
        }

        public static bool operator !=(Auto a,Auto b)
        {
            return !(a==b);
        }


        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Auto)
            {
                if ((Auto)obj==this)
                {
                    retorno = true;
 
                }
            }

            return retorno;
        }

        public override string ToString()
        {
            return "Marca: "+this.Marca+"   Color: "+this.Color+"\n";
        }
    }
}
