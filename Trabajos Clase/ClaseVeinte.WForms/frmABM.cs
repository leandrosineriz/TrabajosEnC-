using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseVeinte.Library;

namespace ClaseVeinte.WForms
{
    public partial class frmABM : Form
    {
        private Persona _persona;
        DataRow _fila;

        public Persona Persona { get { return this._persona; } }      

        public frmABM()
        {
            InitializeComponent();
        }
        
        public frmABM(Persona persona)
            : this()
        {          
            this._persona = persona; 
        }

        public frmABM(Persona persona, string a)
            :this(persona)
        {           
            this.txtApellido.Text = persona.apellido;
            this.txtEdad.Text = persona.edad.ToString();
            this.txtNombre.Text = persona.nombre;
            this.txtApellido.Enabled = false;
            this.txtEdad.Enabled = false;
            this.txtNombre.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._persona == null)
                {
                    this._persona = new Persona(1, this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtEdad.Text));
                    
                }
                else
                {
                    this._persona = new Persona(this._persona.id, this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtEdad.Text));
 
                }

                this.DialogResult = DialogResult.OK;            
            }
            catch (Exception)
            {

                this.DialogResult = DialogResult.Abort;
            }          
            
        }

        private void  btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
