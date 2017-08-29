using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona unaPersona=new Persona();

            Persona.Saludar();

            unaPersona.SaludarDos();

            Console.Read();

        }
    }
}
