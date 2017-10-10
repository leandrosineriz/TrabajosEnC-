using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita.V2
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciaPorLocal { get { return this.CalcularGanancia(TipoLlamada.Local); } }

        public float GananciaPorProvincial { get { return this.CalcularGanancia(TipoLlamada.Provincial); } }

        public float GananciaTotal { get { return this.CalcularGanancia(TipoLlamada.Todas);  } }

        public List<Llamada> Llamadas { get { return this._listaDeLlamadas; } }

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
 
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float retornoLocal=0;
            float retornoProvincial = 0;
            float retornoTodas = 0;
            float retorno=0;

            foreach (Llamada i in this._listaDeLlamadas)
            {               
                switch (tipo)
                {
                
                    case TipoLlamada.Local:
                    
                        if (i is Local)                       
                            retornoLocal += i.CostoLlamada;                                           
                        break;
                
                    case TipoLlamada.Provincial:

                        if (i is Provincial)                       
                            retornoProvincial += i.CostoLlamada;                                        
                        break;
                
                    default:                                      
                            retornoTodas += i.CostoLlamada;                                             
                        break;
                }
            }

            switch (tipo)
            {

                case TipoLlamada.Local:
                    retorno = retornoLocal;
                    break;

                case TipoLlamada.Provincial:
                    retorno = retornoProvincial;
                    break;

                case TipoLlamada.Todas:
                    retorno = retornoTodas;
                    break;
            }

            return retorno;
            
 
        }

        private string Mostrar()
        {
            string retorno = "";

            retorno += "Razon Social: " + this._razonSocial + "\nGanancia Total: " + this.GananciaTotal + "\nGanacia por llamadas Locales: " + this.GananciaPorLocal + "\nGanancia por llamadas Provinciales: " + this.GananciaPorProvincial+"\nLista Llamadas:\n";

            foreach (Llamada i in this._listaDeLlamadas)
            {
                retorno += i.ToString();
            }


            return retorno;

        }

        private void AgregarLlamada(Llamada unaLlamada)
        {
            this._listaDeLlamadas.Add(unaLlamada);
        }


        public static bool operator ==(Centralita miCentralita, Llamada unaLlamada)
        {
            bool retorno = false;

            foreach(Llamada i in miCentralita._listaDeLlamadas)
            {
                if (i == unaLlamada)
                {
                    retorno = true;
                    break;
                }              

            }           

            return retorno;
        }

        public static bool operator !=(Centralita miCentralita, Llamada unaLlamada)
        {
            return !(miCentralita == unaLlamada);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static Centralita operator +(Centralita miCentralita, Llamada unaLlamada)
        {                        
                
            if (!(miCentralita == unaLlamada))
            {
                miCentralita.AgregarLlamada(unaLlamada);
            }

            return miCentralita;
        }
    }
}
