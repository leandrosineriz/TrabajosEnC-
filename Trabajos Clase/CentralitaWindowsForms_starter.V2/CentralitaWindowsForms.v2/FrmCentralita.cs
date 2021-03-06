﻿using System;
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
    public partial class FrmCentralita : Form
    {
        private Centralita.V2.Centralita miCentralita;

        public FrmCentralita()
        {
            InitializeComponent();
            miCentralita = new Centralita.V2.Centralita();
            this.cboOrdenamiento.Items.Add("Ordenar por Duracion");
            this.cboOrdenamiento.Items.Add("Ordenar por Costo Llamada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LlamadaProvincial frm = new LlamadaProvincial();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                miCentralita+=frm.Llamadas;

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
                    this.miCentralita.Llamadas.Sort(Centralita.V2.Llamada.OrdenarPorDuracion);
                    this.lstVisor.Items.Clear();
                    this.agregarElementosAlVisor();
                    break;
                case 1:
                    this.miCentralita.Llamadas.Sort(Centralita.V2.Llamada.OrdenarPorCostoLlamada);
                    this.lstVisor.Items.Clear();
                    this.agregarElementosAlVisor();
                    break;
                default:
                    break;
            }
         }
            
        private void agregarElementosAlVisor()
        {
                foreach (Centralita.V2.Llamada i in this.miCentralita.Llamadas)
                    {
                        this.lstVisor.Items.Add(i);
                    }
        }
            
        
    }
}
