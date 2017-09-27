using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialUnoLibreria
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private static float _precioAuto;
        private static float _precioCamion;
        private static float _precioMoto;
        private string razonSocial;


        public List<Vehiculo> Vehiculos { get { return this._vehiculos; } set { this._vehiculos = value; } }

        public string MiLavadero 
        { 
            get 
            {
                string retorno = "Razon Social :"+this.razonSocial+" | Precio Auto :"+_precioAuto+" | Precio Camion :"+_precioCamion+" | Precio Moto :"+_precioMoto+"\n Vehiculos:";

                foreach (Vehiculo i in this._vehiculos)
                {
                    retorno+="\n"+i.ToString();
                }

                return retorno;
            } 
        }

        static Lavadero()
        {
            Random rand=new Random();
            _precioAuto = rand.Next(150,565);
            _precioCamion = rand.Next(150, 565);
            while(_precioCamion==_precioAuto)
                _precioCamion = rand.Next(150, 565);

            _precioMoto = rand.Next(150, 565);
            while(_precioMoto==_precioCamion && _precioMoto==_precioAuto)
                _precioMoto = rand.Next(150, 565);
        }

        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }


        public Lavadero(string razonSocial)
            : this()
        {
            this.razonSocial = razonSocial;
        }


        public double MostrarTotalFacturado()
        {
            double retorno=0;

            foreach (Vehiculo i in this._vehiculos)
            {
                if (i is Auto)
                {
                    retorno += _precioAuto;
                }
                else if (i is Camion)
                {
                    retorno += _precioCamion;
                }
                else if (i is Moto)
                {
                    retorno += _precioMoto;
                }
            }

            return retorno;

        }

        public double MostrarTotalFacturado(EVehiculos tipo)
        {
            double retorno=0;
            foreach (Vehiculo i in this._vehiculos)
            {
                switch (tipo)
                {
                   case EVehiculos.Auto:
                        if (i is Auto)
                        {
                            retorno += _precioAuto;
                        }
                    break;
                   case EVehiculos.Camion:
                    if (i is Camion)
                    {
                        retorno += _precioCamion;
                    }
                    break;
                   case EVehiculos.Moto:
                    if (i is Moto)
                    {
                        retorno += _precioMoto;
                    }
                    break;
                }     
 
            }
           

            return retorno;
        }


        public static int operator ==(Lavadero unLavadero, Vehiculo unVehiculo)
        {
            int retorno = -1;

            for(int i=0;i<unLavadero.Vehiculos.Count;i++)
            {
                if(unLavadero.Vehiculos[i] == unVehiculo)
                {
                    retorno=i;
                    break;
                }
            }
            
            return retorno;
        }

        public static int operator !=(Lavadero unLavadero, Vehiculo unVehiculo)
        {
            return -1;
        }


        public static Lavadero operator +(Lavadero unLavadero, Vehiculo unVehiculo)
        {
            Lavadero auxLavadero = unLavadero;
            int bandera=0;

            foreach (Vehiculo i in unLavadero.Vehiculos)
            {
                
                if (i == unVehiculo)
                {
                    bandera = 1;
                    break;
                }
            }

            if (bandera == 0)
            {
                auxLavadero.Vehiculos.Add(unVehiculo);
            }

            return auxLavadero;
        }

        public static Lavadero operator -(Lavadero unLavadero, Vehiculo unVehiculo)
        {
            Lavadero auxLavadero = unLavadero;
            int auxIndice= unLavadero==unVehiculo;

            if (auxIndice != -1)
            {
                auxLavadero.Vehiculos.RemoveAt(auxIndice);
            }

            return auxLavadero;
            
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo unVehiculo, Vehiculo otroVehiculo)
        {
            int retorno;

            if (string.Compare(unVehiculo.Patente, otroVehiculo.Patente) == 0)
            {
                retorno = 0;
            }
            else if (string.Compare(unVehiculo.Patente, otroVehiculo.Patente) == 1)
            {
                retorno = 1;
            }
            else
            {
                retorno = -1;
            }

            return retorno;
        }


        public int OrdenarVehiculosPorMarca(Vehiculo unVehiculo, Vehiculo otroVehiculo)
        {
            int retorno;

            if (unVehiculo.Marca == otroVehiculo.Marca)
            {
                retorno = 0;
            }
            else if (unVehiculo.Marca > otroVehiculo.Marca)
            {
                retorno = 1;
            }
            else 
            {
                retorno = -1;
            }

            return retorno;

        }
    }
}
