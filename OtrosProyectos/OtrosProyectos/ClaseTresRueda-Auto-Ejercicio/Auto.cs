using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTresRueda_Auto_Ejercicio
{
    
    class Auto
    {
        eFabricante fabricante;
        //Rueda ruedaDD = new Rueda();
        //Rueda ruedaDI = new Rueda();
        //Rueda ruedaTD = new Rueda();
       // Rueda ruedaTI = new Rueda();
        static int contadorDeObjetos;

        public Auto()
        {
            fabricante = 0;
            contadorDeObjetos++;
        }

        static Auto()
        {
            contadorDeObjetos = 0;
        }

    }
}
