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
    public partial class LlamadaProvincial : Llamada
    {
        public LlamadaProvincial()
        {
            InitializeComponent();
                                
            foreach (Franja i in Enum.GetValues(typeof(Franja)))
            {
                this.cmbFranja.Items.Add(i);
                
            }
            this.cmbFranja.Text = Franja.Franja_1.ToString();

        }
    }
}
