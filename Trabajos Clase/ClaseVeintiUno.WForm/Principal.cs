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
    public partial class Principal : Form
    {
        List<Empleado> listaEmpleados = new List<Empleado>();

        public Principal()
        {
            InitializeComponent();

            foreach (Empleado e in this.listaEmpleados)
            {
                this.listBox1.Items.Add(e);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABM frm = new ABM();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.listBox1.Items.Clear();
                listaEmpleados.Add(frm.Empleado);

                foreach (Empleado i in this.listaEmpleados)
                {
                    this.listBox1.Items.Add(i);
                }
 
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            OtroOtroFormEventos frm = new OtroOtroFormEventos();

            frm.ShowDialog();
        }
    }
}
