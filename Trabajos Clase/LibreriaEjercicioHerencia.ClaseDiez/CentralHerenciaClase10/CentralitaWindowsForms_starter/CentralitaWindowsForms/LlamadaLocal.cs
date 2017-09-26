using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaEjercicioHerencia.ClaseDiez;

namespace CentralitaWindowsForms
{
    public partial class LlamadaLocal : Llamada
    {
        private Local _unaLocal;
 

        public LlamadaLocal()
        {
            InitializeComponent();
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            float auxDuracion = float.Parse(this.txtDuracion.Text);
            string auxOrigen = this.textBox1.Text;
            string auxDestino = this.textBox2.Text;

            base.btnAceptar_Click(sender, e);
        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }
    }
}
