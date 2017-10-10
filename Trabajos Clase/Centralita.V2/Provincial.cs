using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita.V2
{
    public class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        public override float CostoLlamada { get { return this.CalcularCosto(); } }

        public Provincial(string origen, float duracion, string destino, Franja miFranja)
            : base(origen,destino,duracion)
        {
            this._franjaHoraria = miFranja;
 
        }

        public Provincial(Franja miFranja, Llamada unaLlamada) :
            this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, miFranja)
        {
 
        }

        protected override string Mostrar()
        {
            return base.Mostrar()+"\n | Franja Horaria: "+this._franjaHoraria+"\n | Costo Llamada: "+this.CostoLlamada;
        }

        

        public override string ToString()
        {
            return this.Mostrar();
        }

        public float CalcularCosto()
        {
            float retorno=0;

            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                        retorno = base.Duracion * 0.99f;
                         break;

                case Franja.Franja_2:
                        retorno = base.Duracion * (float)1.25;
                         break;

                case Franja.Franja_3:
                        retorno = base.Duracion * (float)0.66;
                         break;
            }

            return retorno;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Provincial)
                retorno = true;

            return retorno;
        }
    }
}
