using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita.V3
{
    public class Local : Llamada
    {
        protected float _costo;

        public override float CostoLlamada { get { return this.CalcularCosto(); } }

        public Local(string origen, DateTime time, string destino, float costo)
            : base(origen,destino,time)
        {
            this._costo = costo;
 
        }

        public Local(Llamada unaLlamada, float costo) : 
            this(unaLlamada.NroOrigen,unaLlamada.FechaInicio,unaLlamada.NroDestino,costo)
        {

        }

        protected override string Mostrar()
        {
            return base.Mostrar()+" | Costo: "+this._costo;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private float CalcularCosto()
        {
            return base.Duracion * this._costo;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Local)
                retorno = true;

            return retorno;
        }
    }
}
