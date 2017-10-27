using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDiecinueve
{
    public class Alumno : Persona
    {
        public int legajo;

        public Alumno() { }

        public Alumno(int legajo,string nombre,string apellido)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.legajo = legajo;
        }


    }
}
