using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCentralita.V3
{
    public partial class FrmFinLlamada : Llamada
    {
        public override Centralita.V3.Llamada Llamadas
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public FrmFinLlamada()
        {
            InitializeComponent();          
            
        }

        public FrmFinLlamada(Centralita.V3.Llamada unaLlamada) : this() 
        {
            this.textBox1.Text = unaLlamada.NroOrigen;
            this.textBox2.Text = unaLlamada.NroDestino;
            this.txtDuracion.Text = unaLlamada.FechaInicio.ToString();
            this.txtBoxCostoFinal.Text = unaLlamada.CostoLlamada.ToString();

            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.ReadOnly = true;
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.BorderStyle = BorderStyle.FixedSingle;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.txtDuracion.BackColor = System.Drawing.Color.White;
            this.txtBoxCostoFinal.BackColor = System.Drawing.Color.White;
 
            this.textBox1.Font = new Font("Pepe", 15, FontStyle.Regular);

            //this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.txtDuracion.Enabled = false;
            this.txtBoxCostoFinal.Enabled = false;

        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            base.btnAceptar_Click(sender, e);
        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }

    }
}
