using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEjercicioHerencia.ClaseDiez
{
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;


       

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

        public string Mostrar()
        {
            return "Duracion: " + this._duracion + "\nNumero Origen: " + this._nroOrigen + "\nNumero Destino: " + this._nroDestino;
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            int retorno = 0;

            if (uno.Duracion > dos.Duracion)
            {
                retorno = 1;
            }
            else if (uno.Duracion == dos.Duracion)
            {
                retorno = 0;
            }
            else
            {
                retorno = -1;
            }
            return retorno;
        }
        
    }
}
