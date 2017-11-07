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
    public partial class frmPrincipal : Form
    {
        ProveedorDeDatos proveedor;
        List<Persona> listaPersona;
        DataTable listaPersonaDT;

        public frmPrincipal()
        {
            //SI PUEDE LEER LOS DATOS DE LA BD LOS CARGA SI NO CARGA LOS DATOS DE LOS BACKUP EN XML DE LA ULTIMA VEZ
            try
            { 
                InitializeComponent();
                proveedor = new ProveedorDeDatos();
                listaPersona = proveedor.ObtenerPersonaBD();
                listaPersonaDT = proveedor.ObtenerPersonaBD(true);

            }
            catch (Exception)
            {
                listaPersonaDT = new DataTable();

                listaPersonaDT.ReadXml("Esquema.xml");
                listaPersonaDT.ReadXml("Datos.xml");            
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lsboxPersonas.DataSource = listaPersonaDT;
            dgwPersonas.DataSource = listaPersonaDT;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmABM frm = new frmABM();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                //this.lsboxPersonas.Items.Clear();
                proveedor.AgregarPersonaBD(frm.Fila);
               
                
               /* foreach (Persona i in listaPersona)
                {
                    lsboxPersonas.Items.Add(i);
                }*/
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                frmABM frm = new frmABM(this.listaPersona[lsboxPersonas.SelectedIndex]);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //this.lsboxPersonas.Items.Clear();
                    proveedor.ModificarPersonaBD(frm.Persona);
                    listaPersona = proveedor.ObtenerPersonaBD();
                    foreach (Persona i in listaPersona)
                    {
                        lsboxPersonas.Items.Add(i);
                    }
                }

            }
            catch (Exception)
            {


            }

        }

        private void btnELiminar_Click(object sender, EventArgs e)
        {
            try
            {
                frmABM frm = new frmABM(this.listaPersona[lsboxPersonas.SelectedIndex],"Eliminar");

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //this.lsboxPersonas.Items.Clear();
                    proveedor.EliminarPersonaBD(frm.Persona);
                    listaPersonaDT = proveedor.ObtenerPersonaBD(true);
                    dgwPersonas.Update();
                    foreach (Persona i in listaPersona)
                    {
                        lsboxPersonas.Items.Add(i);
                    }
                }

            }
            catch (Exception)
            {


            }
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            listaPersonaDT.WriteXmlSchema("Esquema.xml");

            listaPersonaDT.WriteXml("Datos.xml");
            
        }
    }
}
