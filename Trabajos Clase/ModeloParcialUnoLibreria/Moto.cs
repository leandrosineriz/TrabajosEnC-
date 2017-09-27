using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialUnoLibreria
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        public Moto(string patente, EMarcas marca, Byte cantRuedas, float cilindrada)
            : base(patente, cantRuedas, marca)
        {
            this._cilindrada = cilindrada;
        }

        public override string ToString()
        {
            return base.ToString()+" | Cilindrada :"+this._cilindrada;
        }
        
    }
}
