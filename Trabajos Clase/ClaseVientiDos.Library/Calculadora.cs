using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseVeintiDos.Library
{
    
    public delegate void DelOperaciones();

    public class Calculadora
    {
        public double primerNumero;
        public double segundoNumero;
        public string operador;
        public double resultado;
        public DateTime _horaCalculo;
        public bool terminado;

        public Calculadora()
        {
            this.operador = "0";
            this.terminado = false;
            this.primerNumero = 0;
            this.segundoNumero = 0;
        }

        public void Sumar()
        {
            this.resultado= this.primerNumero + this.segundoNumero;
            this._horaCalculo = DateTime.Now;
            this.terminado = true;
        }

        public void Restar()
        {
            this.resultado= this.primerNumero - this.segundoNumero;
            this._horaCalculo = DateTime.Now;
            this.terminado = true;
        }

        public void Dividir()
        {
            double retorno=0;
            if (this.segundoNumero != 0)
                retorno = this.primerNumero / this.segundoNumero;

            this.resultado= retorno;
            this._horaCalculo = DateTime.Now;
            this.terminado = true;
        }

        public void Multiplicar()
        {
            this.resultado= this.primerNumero * this.segundoNumero;
            this._horaCalculo = DateTime.Now;
            this.terminado = true;
        }


    }
}
