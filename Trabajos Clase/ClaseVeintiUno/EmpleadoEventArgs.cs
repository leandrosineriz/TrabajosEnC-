using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseVeintiUno.Library
{
    public class EmpleadoEventArgs : EventArgs
    {
        private double _sueldo;

        public double Sueldo
        {
            get { return _sueldo; }
            set { _sueldo = value; }
        }
        
    }
}
