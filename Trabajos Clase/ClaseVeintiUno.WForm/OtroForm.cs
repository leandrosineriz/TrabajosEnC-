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
    public partial class OtroForm : Form
    {
        public OtroForm()
        {
            InitializeComponent();
        }

        private void OtroForm_Load(object sender, EventArgs e)
        {
            /*
            this.button1.Click += new EventHandler(this.ManejadorGenerico);
            this.label1.Click += new EventHandler(this.ManejadorGenerico);
            this.textBox1.Click += new EventHandler(this.ManejadorGenerico);
            */
            foreach(Control c in this.Controls)
            {
                c.Click += new EventHandler(this.ManejadorGenerico);
            }
            
        }
      
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }
        
        void ManejadorGenerico(object obj, EventArgs e)
        {

            MessageBox.Show(obj.ToString());
            if (obj is TextBox)
            {
                ((TextBox)obj).Font = new Font("Comic Sans MS", 30);
                ((TextBox)obj).Size=new Size(300,10);
                ((TextBox)obj).BackColor = Color.Red;
            }
            else if (obj is Label)
            {
                ((Label)obj).FlatStyle = FlatStyle.Popup;
                ((Label)obj).BorderStyle = BorderStyle.Fixed3D;
            }
            else if (obj is Button)
            {
                ((Button)obj).Location = new Point(0,0);
                
            }
        }

    }
}
