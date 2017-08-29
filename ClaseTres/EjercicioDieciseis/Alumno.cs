using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDieciseis
{
    class Alumno
    {
        byte _notaUno;
        byte _notaDos;
        public float _notaFinal;
        string apellido;
        int legajo;
        string nombre;

        public Alumno(string nombre,string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
 
        }

        public void CalcularFinal()
        {
            this._notaFinal=-1;
            if (this._notaUno >= 4 && this._notaDos >= 4)
            {
                Random newNotaFinal = new Random();

                this._notaFinal=newNotaFinal.Next(0,10);
                
            }
 
        }

        public void Estudiar()
        {
            Console.WriteLine("Ingrese la nota uno:");
            while(!byte.TryParse(Console.ReadLine(),out this._notaUno))
            {
                Console.WriteLine("Error. Reingrese la nota uno:");
            }
            while(this._notaUno<0 || this._notaUno>10)
            {
                Console.WriteLine("Reingrese la nota uno:");
                while(!byte.TryParse(Console.ReadLine(),out this._notaUno))
                {
                Console.WriteLine("Error. Reingrese la nota uno:");
                }
            }

            Console.WriteLine("Ingrese la nota dos:");
            while(!byte.TryParse(Console.ReadLine(),out this._notaUno))
            {
                Console.WriteLine("Error. Reingrese la nota dos:");
            }

            while(this._notaUno<0 || this._notaUno>10)
            {
                Console.WriteLine("Reingrese la nota uno:");
                while(!byte.TryParse(Console.ReadLine(),out this._notaUno))
                {
                Console.WriteLine("Error. Reingrese la nota uno:");
                }
            }

 
        }

        public void Mostrar()
        {
 
        }




    }
}
