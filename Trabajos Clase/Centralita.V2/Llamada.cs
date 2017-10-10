using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita.V2
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public abstract float CostoLlamada { get; }

        public float Duracion
        {
            get { return this._duracion; }
            //set { myVar = value; }
        }

        public string NroDestino 
        {
            get{ return this._nroDestino; }
        }

        public string NroOrigen  
        {
            get { return this._nroOrigen; }
            
        }


        public Llamada(string origen, string destino, float duracion)
        {
            this._duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }

        protected virtual string Mostrar()
        {
            return "Duracion: " + this._duracion + "\n | Numero Origen: " + this._nroOrigen + "\n | Numero Destino: " + this._nroDestino;
        }

        public static bool operator ==(Llamada unaLlamada,Llamada otraLlamada)
        {
            bool retorno = false;

            if (String.Compare(unaLlamada.NroDestino, otraLlamada.NroDestino) == 0 && String.Compare(unaLlamada.NroOrigen, otraLlamada.NroOrigen) == 0  && unaLlamada.Equals(otraLlamada))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Llamada unaLlamada, Llamada otraLlamada)
        {
            return !(unaLlamada == otraLlamada);
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            int retorno = 0;

            if (uno.Duracion > dos.Duracion)
                retorno = 1;
            else if (uno.Duracion < dos.Duracion)
                retorno = -1;

            return retorno;
        }

        public static int OrdenarPorCostoLlamada(Llamada uno, Llamada dos)
        {
            int retorno = 0;

            if (uno.CostoLlamada > dos.CostoLlamada)
                retorno = 1;
            else if (uno.CostoLlamada < dos.CostoLlamada)
                retorno = -1;

            return retorno;
        }
        
    }
}
