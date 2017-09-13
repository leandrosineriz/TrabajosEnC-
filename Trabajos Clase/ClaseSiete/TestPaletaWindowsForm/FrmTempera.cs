using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseOcho.ClasesGenericas;

namespace TestPaletaWindowsForm
{
    public partial class FrmTempera : Form
    {
        private Tempera _tempera;

        public FrmTempera()
        {
            
            InitializeComponent();

            foreach (ConsoleColor i in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cboColores.Items.Add(i);
                
            }

            this.cboColores.SelectedItem = ConsoleColor.Black;
            this.cboColores.DropDownStyle=ComboBoxStyle.DropDownList;
        }

        public FrmTempera(Tempera unaTempera):this()
        {
            this.txtMarca.Text = unaTempera.getMarca();
            this.txtCantidad.Text =unaTempera.getCantidad().ToString();
            this.cboColores.SelectedItem = unaTempera.getColor();
 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /*string auxMarca = this.txtMarca.Text;
            //ConsoleColor auxColor =(ConsoleColor)Enum.Parse(typeof(ConsoleColor), this.txtColor.Text);
            int auxCantidad = int.Parse(this.txtCantidad.Text);
            _tempera=new Tempera(auxMarca,auxCantidad);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            */
            string auxMarca = this.txtMarca.Text;
            int auxCantidad = int.Parse(this.txtCantidad.Text);
            _tempera = new Tempera((ConsoleColor)this.cboColores.SelectedItem, auxMarca, auxCantidad);

            this.DialogResult = DialogResult.OK;

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


        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
