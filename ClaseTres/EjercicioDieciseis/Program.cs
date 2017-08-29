using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDieciseis
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumnoUno = new Alumno("juan","perez",1001);
            Alumno alumnoDos = new Alumno("pedro","ramirez",2002);
            Alumno alumnoTres = new Alumno("sofia","martinez",3003);

            alumnoUno.Estudiar();
            alumnoUno.CalcularFinal();

            Console.WriteLine(alumnoUno._notaFinal);
            Console.Read();
        }
    }
}
