using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseQuince.Deposito
{
    public class DepositoDeCocinas
    {
        private int capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this.capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        public bool Agregar(Cocina a)
        {
            return this + a;
        }

        public static bool operator +(DepositoDeCocinas d, Cocina a)
        {
            bool retorno = false;

            if (d.capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                retorno = true;
            }

            return retorno;

        }
        private int GetIndice(Cocina a)
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

        public static bool operator -(DepositoDeCocinas d, Cocina a)
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

        public bool Remover(Cocina a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string retorno = "Capacidad Maxima: " + this.capacidadMaxima + "\nListado de Cocinas:\n";

            foreach (Cocina a in this._lista)
            {
                retorno += a;
            }
            return retorno;
        }

    }
}
