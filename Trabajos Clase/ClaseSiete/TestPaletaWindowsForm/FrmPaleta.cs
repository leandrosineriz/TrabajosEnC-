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
    public partial class FrmPaleta : Form
    {
        private Paleta _paleta;

        public FrmPaleta()
        {
            InitializeComponent();
            this._paleta = 5;
        }

        private void FrmPaleta_Load(object sender, EventArgs e)
        {

        }

        private void btnMas_Click_1(object sender, EventArgs e)
        {
            /*Tempera unaTempera = new Tempera(ConsoleColor.Blue, "BIC", 10);
            this._paleta += unaTempera;            
            listBox2.Items.Clear();
            listBox2.Items.Add((string)this._paleta);
            */
            FrmTempera frm = new FrmTempera();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
                this._paleta += frm.getTempera();

            listBox2.Items.Add((string)this._paleta);
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {            
           
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            Tempera unaTempera = new Tempera(ConsoleColor.Blue, "BIC");
            this._paleta -= unaTempera;
            listBox2.Items.Clear();
            listBox2.Items.Add((string)this._paleta);
        }

        private void FrmPaleta_Load_1(object sender, EventArgs e)
        {

        }

       




        
    }
}
