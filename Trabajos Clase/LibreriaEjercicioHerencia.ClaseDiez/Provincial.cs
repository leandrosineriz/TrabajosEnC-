﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEjercicioHerencia.ClaseDiez
{
    class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        public float CostoLlamada { get { return this.CalcularCosto(); } }

        public Provincial(string origen, float duracion, string destino, Franja miFranja)
            : base(origen,destino,duracion)
        {
            this._franjaHoraria = miFranja;
 
        }

        public Provincial(Franja miFranja, Llamada unaLlamada) :
            this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, miFranja)
        {
 
        }

        public new string Mostrar()
        {
            return "Duracion: " + base.Duracion + "\nNumero Origen: " + base.NroOrigen + "\nNumero Destino: " + base.NroDestino + "\nFranja Horaria: " + this._franjaHoraria + "\nCosto Llamada: "+this.CostoLlamada;
        }

        public float CalcularCosto()
        {
            float retorno=0;

            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = base.Duracion * (float)0.99;
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
    }
}