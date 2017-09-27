using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialUnoLibreria
{
    public class Vehiculo
    {
        protected string _patente;
        protected Byte _cantRuedas;
        protected EMarcas _marca;

        public string Patente { get{ return  this._patente; } }

        //public Byte CantRuedas { get { return this._cantRuedas; } }

        public EMarcas Marca { get { return this._marca; } }

        public Vehiculo(string patente, Byte cantidadRuedas, EMarcas marca)
        {
            this._patente = patente;
            this._cantRuedas = cantidadRuedas;
            this._marca = marca;
        }

        private string Mostrar()
        {
            return "Patente :" + this._patente + " | Cantidad de Ruedas:" + this._cantRuedas + " | Marca :" + this._marca;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


        public static bool operator ==(Vehiculo unVehiculo, Vehiculo otroVehiculo)
        {
            bool retorno = false;

            if (string.Compare(unVehiculo.Patente, otroVehiculo.Patente) == 0 && unVehiculo.Marca == otroVehiculo.Marca)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Vehiculo unVehiculo, Vehiculo otroVehiculo)
        {
            return !(unVehiculo == otroVehiculo);
        }
    }
}
