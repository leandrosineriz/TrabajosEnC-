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
    public partial class FrmCentralita : Form
    {
        private Centralita.V3.Centralita miCentralita;

        public FrmCentralita()
        {
            InitializeComponent();
            miCentralita = new Centralita.V3.Centralita();
            this.cboOrdenamiento.Items.Add("Ordenar por Duracion");
            this.cboOrdenamiento.Items.Add("Ordenar por Costo Llamada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LlamadaProvincial frm = new LlamadaProvincial();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                miCentralita += frm.Llamadas;

                this.lstVisor.Items.Clear();
                this.agregarElementosAlVisor();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlamadaLocal frm = new LlamadaLocal();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                miCentralita += frm.Llamadas;

                this.lstVisor.Items.Clear();

                this.agregarElementosAlVisor();
            }
        }

        private void cboOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cboOrdenamiento.SelectedIndex)
            {
                case 0:
                    this.miCentralita.Llamadas.Sort(Centralita.V3.Llamada.OrdenarPorCostoLlamada);
                    this.lstVisor.Items.Clear();
                    this.agregarElementosAlVisor();
                    break;
                case 1:
                    this.miCentralita.Llamadas.Sort(Centralita.V3.Llamada.OrdenarPorCostoLlamada);
                    this.lstVisor.Items.Clear();
                    this.agregarElementosAlVisor();
                    break;
                default:
                    break;
            }
        }

        private void agregarElementosAlVisor()
        {
            foreach (Centralita.V3.Llamada i in this.miCentralita.Llamadas)
            {
                this.lstVisor.Items.Add(i);
            }
        }

        private void btnFinLlamada_Click(object sender, EventArgs e)
        {
            if (this.lstVisor.SelectedIndex != -1)
            {
                Centralita.V3.Llamada unaLlamada = this.miCentralita.Llamadas[this.lstVisor.SelectedIndex];
                FrmFinLlamada frm = new FrmFinLlamada(unaLlamada);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.miCentralita.Llamadas.RemoveAt(this.lstVisor.SelectedIndex);
                    lstVisor.Items.Clear();
                    this.agregarElementosAlVisor();


                }
            }

        }


    }
}
