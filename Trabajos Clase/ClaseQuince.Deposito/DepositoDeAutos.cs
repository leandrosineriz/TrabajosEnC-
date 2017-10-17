using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseQuince.Deposito
{
    public class DepositoDeAutos
    {
        private int capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this.capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;

            if (d.capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                retorno = true;
            }

            return retorno;

        }
        private int GetIndice(Auto a)
        {
            int retorno = -1;

            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i].Equals(a))
                {
                    retorno = i;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            int indice = d.GetIndice(a);

            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                retorno = true;
            }

            return retorno;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string retorno = "Capacidad Maxima: " + this.capacidadMaxima + "\nListado de Autos:\n";

            foreach (Auto a in this._lista)
            {
                retorno += a;
            }
            return retorno;
        }


    }
}
