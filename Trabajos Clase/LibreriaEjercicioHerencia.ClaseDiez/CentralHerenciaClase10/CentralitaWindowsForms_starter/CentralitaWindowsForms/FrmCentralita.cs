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
    public partial class FrmCentralita : Form
    {
        private Centralita miCentralita;

        public FrmCentralita()
        {
            InitializeComponent();
            miCentralita = new Centralita();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LlamadaProvincial frm = new LlamadaProvincial();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                miCentralita+=frm.MiLlamada;

                this.lstVisor.Items.Clear();
                foreach(LibreriaEjercicioHerencia.ClaseDiez.Llamada i in miCentralita.Llamadas)
                {
                    this.lstVisor.Items.Add(i.ToString());

                }
                

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlamadaLocal frm = new LlamadaLocal();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                miCentralita += frm.UnaLocal;

                this.lstVisor.Items.Clear();

                foreach (LibreriaEjercicioHerencia.ClaseDiez.Llamada i in miCentralita.Llamadas)
                {
                    this.lstVisor.Items.Add(i.ToString());
                }
            }
        }
    }
}
