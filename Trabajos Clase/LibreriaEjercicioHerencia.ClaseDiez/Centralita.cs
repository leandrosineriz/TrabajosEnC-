using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEjercicioHerencia.ClaseDiez
{
    class Centralita
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
                        {
                            retornoLocal += ((Local)i).CostoLlamada;
                        }                    
                        break;
                
                    case TipoLlamada.Provincial:

                        if (i is Provincial)
                        {
                            retornoProvincial += ((Provincial)i).CostoLlamada;
                        }                  
                        break;
                
                    case TipoLlamada.Todas:
                        if (i is Local)
                        {
                            retornoTodas += ((Local)i).CostoLlamada;
                        }
                        if (i is Provincial)
                        {
                            retornoTodas += ((Provincial)i).CostoLlamada;
                        } 
                    
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


    }
}
