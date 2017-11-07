using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseVeinte.Library
{
    public class Persona
    {
        public int id;
        public string nombre;
        public string apellido;
        public int edad;

        public Persona(int id, string nombre, string apellido, int edad)
        {
            this.apellido = apellido;
            this.edad = edad;
            this.id = id;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return "\nID: "+this.id+"  \nNOMBRE COMPLETO: "+this.nombre+" "+this.apellido+"  \nEdad: "+this.edad;
        }

    }
}
