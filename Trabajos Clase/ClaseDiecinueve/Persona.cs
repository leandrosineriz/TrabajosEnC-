using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClaseDiecinueve
{
    [XmlInclude(typeof(Alumno))]
    public class Persona 
    {
        private string _nombre;
        private string _apellido;

        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }

        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }
        public Persona() { }
        public Persona(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }

        public override string ToString()
        {
            return "\nNombre Completo: "+this.Nombre+" "+this.Apellido;
        }
    }
}
