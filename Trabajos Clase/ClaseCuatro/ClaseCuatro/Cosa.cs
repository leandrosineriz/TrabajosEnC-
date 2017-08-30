using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCuatro
{
    class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        /// <summary>
        /// Constructor que inzializa en 0, "Sin Valor", DateTime.Now
        /// </summary>
        public Cosa()
        {
            this.entero = 0;
            this.cadena = "Sin Valor";
            this.fecha = DateTime.Now;
        }

        /// <summary>
        /// Constructor que inzializa en num, "Sin Valor", DateTime.Now
        /// </summary>
        /// <param name="num">un numero</param>
        public Cosa(int x):this()//como llamar cadenas desde cadena
        {          
            this.entero = x;
            //se Repite Codigo Vamos A Optimizarlo
            /*this.cadena = "Sin Valor";
            this.fecha = DateTime.Now;*/
        }

        /// <summary>
        /// Constructor que inzializa en num, cadena, DateTime.Now
        /// </summary>
        /// <param name="num">un numero</param>
        /// <param name="cadena">un string</param>
        public Cosa(int num,string cadena):this(num)//tiene un orden llama al constructor con parametro num
        {
            this.cadena = cadena;
            //this.fecha = DateTime.Now;

        }

        public Cosa(DateTime fecha, int num, string cadena):this(num,cadena)
        {
            this.fecha = fecha;
 
        }




 /// <summary>
 /// Establece el valor de entero
 /// </summary>
 /// <param name="num">un Numero</param>
        public void EstablecerValor(int num)
        {
            this.entero=num;
        }
        /// <summary>
        /// establece el valor de Cadena
        /// </summary>
        /// <param name="cadena">Una cadena</param>
        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }
        /// <summary>
        /// Establece el valor de Fecha
        /// </summary>
        /// <param name="fecha">Una fecha</param>
        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }
        /// <summary>
        /// Muestra todos los datos por consola
        /// </summary>
        /// <returns>Concatenacion de todos los datos de la clase Cosa</returns>
        public string Mostrar()
        {
            
            return this.entero + " " + this.cadena + " " + this.fecha;
        }

        public string Mostrar(ConsoleColor color)
        {
            
            Console.ForegroundColor = color;
            return this.entero + " " + this.cadena + " " + this.fecha;
        }

      }
}
