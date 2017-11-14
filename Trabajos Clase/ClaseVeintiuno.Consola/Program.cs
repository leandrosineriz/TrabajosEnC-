using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseVeintiUno.Library;

namespace ClaseVeintiuno.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program=new Program();

            Empleado emp = new Empleado();
            emp.LimiteSueldo += new DelEmp(Manejador);
            emp.LimiteSueldo += new DelEmp(program.Manejador2);
            emp.LimiteSueldoEmpleado += new QuienFue(ManejadorQuienFue);
            emp.PresionarA += new PresionarLetraA(ManejadorPresionarLetraA);

            try
            {
                emp.Nombre = "Pepe";
                emp.Apellido = "Juarez";
                emp.Sueldo = 100000;

                //Console.WriteLine(emp);         
               
               
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                
            }
 
            
        }
        
        static void Manejador(string e)
        {
            Console.WriteLine("Estoy en el manejador de evento");
        }

        void Manejador2(string e)
        {
            Console.WriteLine("Estoy en el manejador de evento de instancia");
        }

        static void ManejadorQuienFue(Empleado emp)
        {
            Console.WriteLine(emp);
        }

        static void ManejadorPresionarLetraA(string a)
        {
            if (a.ToString().ToLower() == "a")
            {
                Console.WriteLine("Presionaste A");
                Console.ReadKey();
            }
        }
    }
}
