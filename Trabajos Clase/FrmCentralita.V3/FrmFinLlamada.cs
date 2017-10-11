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
