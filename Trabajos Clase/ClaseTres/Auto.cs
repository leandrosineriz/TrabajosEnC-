using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTres
{
    class Auto
    {
        private string marca;
        private string patente;
        private float precio;
        public static int cantInstancias;
        public static DateTime f_inicio;
        public static DateTime f_ultimo;

        static Auto()
        {
            Auto.f_inicio = DateTime.Now;
            
        }

        public Auto(string marca, string patente, float precio)
        {
            this.marca = marca;
            this.patente = patente;
            this.precio = precio;
            Auto.f_ultimo = DateTime.Now;
            Auto.f_ultimo=Auto.f_ultimo.AddYears(1);
            Auto.cantInstancias++;
        }

        private string Mostrar()
        {
            return this.marca+" "+this.patente+" "+this.precio.ToString();
        }

        static public string Mostrar(Auto unAuto)
        {
            return unAuto.Mostrar();         
        }
        
        
    }
}
