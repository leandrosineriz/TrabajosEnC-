using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita.V3;


namespace FrmCentralita.V3
{
    public partial class LlamadaProvincial : Llamada
    {
        private Provincial _miProvincial;

        public override Centralita.V3.Llamada Llamadas
        {
            get
            {
                return this._miProvincial;
            }
            set
            {
                
            }
        }

        public LlamadaProvincial()
        {
            InitializeComponent();

            this.txtDuracion.Text = DateTime.Now.ToString();
            this.txtDuracion.Enabled = false;
                                
            foreach (Franja i in Enum.GetValues(typeof(Franja)))
            {
                this.cmbFranja.Items.Add(i);
                
            }
            this.cmbFranja.Text = Franja.Franja_1.ToString();

        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            string auxOrigen = this.textBox1.Text;
            string auxDestino = this.textBox2.Text;
            Franja auxFranja = (Franja)this.cmbFranja.SelectedItem;

            this._miProvincial = new Provincial(auxOrigen, DateTime.Parse(this.txtDuracion.Text), auxDestino, auxFranja);

            base.btnAceptar_Click(sender, e);
        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }
    }
}
