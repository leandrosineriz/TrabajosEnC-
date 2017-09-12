using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseSeisLibreriaa;

namespace TestPaletaWindowsForm
{
    public partial class FrmTempera : Form
    {
        private Tempera _tempera;

        public FrmTempera()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string auxMarca = this.txtMarca.Text;
            ConsoleColor auxColor =(ConsoleColor)Enum.Parse(typeof(ConsoleColor), this.txtColor.Text);
            int auxCantidad = int.Parse(this.txtCantidad.Text);
            _tempera=new Tempera(auxColor,auxMarca,auxCantidad);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            
        }

        public Tempera getTempera()
        {
            return this._tempera;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
