using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseQuince.Deposito
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustial;
        private double _precio;

        public int Codigo { get { return this._codigo; } }

        public bool EsIndustrial { get { return this._esIndustial; } }

        public double Precio { get { return this._precio; } }

        public Cocina()
        { }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustial = esIndustrial;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            bool retorno = false;

            if (a.Codigo == b.Codigo)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Cocina)
            {
                if (this == (Cocina)obj)
                    retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            return "Codigo: " + this.Codigo + " - Precio: " + this.Precio + " - Es Industrial: " + this.EsIndustrial + "\n";
        }


    }
}
