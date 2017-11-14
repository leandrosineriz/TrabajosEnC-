using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseVeintiUno.WForm
{
    public partial class OtroOtroFormEventos : Form
    {
        public OtroOtroFormEventos()
        {
            InitializeComponent();
        }

        private void OtroOtroFormEventos_Load(object sender, EventArgs e)
        {           
           this.button1.Click += new EventHandler(ManejadorGenerico);                   
        }

        void ManejadorGenerico(object obj, EventArgs e)
        {

            if (obj is Button)
            {
                if (button1.Equals(obj))
                {
                    MessageBox.Show("Button 1");
                    this.button1.Click -= new EventHandler(ManejadorGenerico);
                    this.button2.Click += new EventHandler(ManejadorGenerico);
                }
                else if (button2.Equals(obj))
                {
                    MessageBox.Show("Button 2");
                    this.button2.Click -= new EventHandler(ManejadorGenerico);
                    this.button3.Click += new EventHandler(ManejadorGenerico);
                }
                else if (button3.Equals(obj))
                {
                    MessageBox.Show("Button 3");
                    this.button3.Click -= new EventHandler(ManejadorGenerico);
                    this.button4.Click += new EventHandler(ManejadorGenerico);
                }
                else if (button4.Equals(obj))
                {
                    MessageBox.Show("Button 4");
                    this.button4.Click -= new EventHandler(ManejadorGenerico);
                    this.button1.Click += new EventHandler(ManejadorGenerico);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
