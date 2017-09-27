using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialUnoLibreria
{
    public class Auto : Vehiculo
    {
        protected int _cantidadAsientos;

        public Auto(string patente, EMarcas marca, Byte cantRuedas , int cantAsientos)
            : base(patente, cantRuedas , marca)
        {
            this._cantidadAsientos = cantAsientos;
 
        }

        public Auto(string patente, EMarcas marca, int cantAsientos)
            : this(patente, marca, 4, cantAsientos)
        { }


        public override string ToString()
        {
            return base.ToString() + " | Cantidad de Asientos :" + this._cantidadAsientos;
            
        }



    }
}
