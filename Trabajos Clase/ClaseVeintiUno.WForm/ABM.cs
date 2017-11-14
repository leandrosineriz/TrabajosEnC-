using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseVeintiUno.Library;

namespace ClaseVeintiUno.WForm
{
    public partial class ABM : Form
    {
        private Empleado emp;

        public Empleado Empleado { get { return this.emp; } }

        public ABM()
        {
            InitializeComponent();
            this.emp = new Empleado();
            emp.LimiteSueldo += new DelEmp(Manejador);
            emp.LimiteSueldo += new DelEmp(Manejador2);
            emp.LimiteSueldoEmpleado += new QuienFue(ManejadorQuienFue);
            emp.LimiteSueldoEventArgs += new EmpleadoEvent(ManejadorEmpleadoEventArgs);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            emp.LimiteSueldo -= new DelEmp(Manejador2);
            emp.LimiteSueldo -= new DelEmp(Manejador);
            emp.Apellido = this.txtApellido.Text;
            emp.Nombre = this.txtNombre.Text;
            emp.Sueldo = double.Parse(this.txtSueldo.Text);

            this.DialogResult = DialogResult.OK;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        static void Manejador(string e)
        {
            MessageBox.Show("Estoy en el manejador de evento");         
        }

        static void Manejador2(string e)
        {
            MessageBox.Show("Estoy en el manejador de evento 2");
        }

        static void ManejadorQuienFue(Empleado emp)
        {
            MessageBox.Show(emp.ToString());
        }

        static void ManejadorEmpleadoEventArgs(Object obj, EventArgs e)
        {
            ((EmpleadoEventArgs)e).Sueldo = ((Empleado)obj).Sueldo;

            MessageBox.Show(((EmpleadoEventArgs)e).Sueldo.ToString());
        }


    }
}
