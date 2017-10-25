using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseQuince.Deposito
{
    public class Depositos<T> where T : new()
    {
        private int capacidadMaxima;
        private List<T> _lista;

        public int Capacidad { get { return this.capacidadMaxima; } }
        public List<T> Lista { get { return this._lista; } }

        public Depositos()
        {
            this._lista = new List<T>();
        }

        public Depositos(int capacidad)
            : this()
        {
                                  
              if (capacidad > 50 )
              {
                  this.capacidadMaxima = 50;
                  //throw new Exception("La capacidad no puede superar 50.");
              }
              else if (capacidad < 1)
              {
                  this.capacidadMaxima = 1;
                  //throw new Exception("La capacidad no puede ser menor a 1.");
              }
              else
              {
                  this.capacidadMaxima = capacidad;
              }

              
                       
        }

        public bool Agregar(T a)
        {
            return this + a;
        }

        public static bool operator +(Depositos<T> d, T a)
        {
            bool retorno = false;
            
            

            
            
               if (d.capacidadMaxima == 0)
               {
                   throw new DepositoLlenoExeption();
                
               }
               else
               {
                    d._lista.Add(a);
                    d.capacidadMaxima--;
               }
                 
            
            
            
            retorno = true;


            return retorno;

        }
        private int GetIndice(T a)
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

        public static bool operator -(Depositos<T> d, T a)
        {
            bool retorno = false;
            int indice = d.GetIndice(a);

            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                d.capacidadMaxima++;
                retorno = true;
            }

            return retorno;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string retorno = "Capacidad Maxima: " + this.capacidadMaxima + "\nListado de Cocinas:\n";

            foreach (T a in this._lista)
            {
                retorno += a;
            }
            return retorno;
        }

    }
}
