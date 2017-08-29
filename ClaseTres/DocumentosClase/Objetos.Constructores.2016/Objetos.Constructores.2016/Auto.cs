using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Constructores._2016
{
    class Auto
    {
        #region Atributos

        #region De Instancia

        public int cantRuedas;
        private ConsoleColor color;
        
        #endregion

        #region De Clase

        private static DateTime fechaCreacion;
        public static int cantidadObj;
        public static DateTime fechaUltimaInstancia;

        #endregion

        #endregion

        #region Métodos

        #region De Instancia

        public string Mostrar()
        {
            return this.cantRuedas.ToString() + " - " + this.marca.ToString() + " - " + this.color.ToString() + "\n";
        }

        #endregion

        #region De Clase

        public static string Mostrar(Auto a)
        {
            return a.Mostrar();
        }

        public static void DiferenciaEntreInstancias() 
        {
           TimeSpan dif =  Auto.fechaUltimaInstancia - Auto.fechaCreacion;

           Console.WriteLine(dif.TotalMilliseconds);
        }

        #endregion

        #endregion

    }
}
