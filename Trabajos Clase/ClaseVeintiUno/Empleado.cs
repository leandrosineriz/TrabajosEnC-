using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseVeintiUno.Library
{

    public delegate void DelEmp(string e);
    public delegate void QuienFue(Empleado emp);
    public delegate void PresionarLetraA(string a);
    public delegate void EmpleadoEvent(object obj, EventArgs e);

    public class Empleado
    {       
        private string _nombre;
        private string _apellido;
        private double _sueldo;

        public double Sueldo
        {
            get { return _sueldo; }
            set 
            {
                if (value > 0 && value <= 9500)
                {
                    _sueldo = value;
                     this.LimiteSueldoEventArgs(this, new EmpleadoEventArgs());
                }
                    
                else if (value > 9500)
                {
                    this.LimiteSueldo("");
                    this.LimiteSueldoEmpleado(this);
                   
                    
                }                   
                else
                    throw new Exception();
            
            }
        }
        
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public override string ToString()
        {
            return "NOMBRE COMPLETO: "+this.Nombre+" "+this.Apellido+" - Sueldo: "+this.Sueldo;
        }

        public event DelEmp LimiteSueldo;

        public event QuienFue LimiteSueldoEmpleado;

        public event PresionarLetraA PresionarA;

        public event EmpleadoEvent LimiteSueldoEventArgs;
    }
}
