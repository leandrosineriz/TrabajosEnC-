using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialUnoLibreria
{
    public class Camion : Vehiculo
    {
        protected float _tara;

        public Camion(string patente, EMarcas marca, Byte cantRuedas, float tara)
            : base(patente, cantRuedas, marca)
        {
            this._tara = tara;
        }

        public Camion(Vehiculo unVehiculo, float tara) 
            : this(unVehiculo.Patente, unVehiculo.Marca, 4, tara) 
        { }

        public override string ToString()
        {
            return base.ToString()+" | Tara :"+this._tara;
        }

    }
}
