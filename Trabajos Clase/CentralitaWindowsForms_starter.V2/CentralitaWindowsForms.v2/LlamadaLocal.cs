using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita.V2;

namespace CentralitaWindowsForms.V2
{
    public partial class LlamadaLocal : Llamada
    {
        private Local _unaLocal;

        public override Centralita.V2.Llamada Llamadas
        {
            get
            {
                return this._unaLocal;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
 

        public LlamadaLocal()
        {
            InitializeComponent();
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            float auxDuracion = float.Parse(this.txtDuracion.Text);
            string auxOrigen = this.textBox1.Text;
            string auxDestino = this.textBox2.Text;
            float auxCosto = float.Parse(this.textBox3.Text);
            this._unaLocal = new Local(auxOrigen, auxDuracion, auxDestino, auxCosto);

            base.btnAceptar_Click(sender, e);
        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
