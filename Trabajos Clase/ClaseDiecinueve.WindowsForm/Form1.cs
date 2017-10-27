using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ClaseDiecinueve.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
            StreamWriter strWrite=new StreamWriter(saveFileDialog1.FileName,true);

            strWrite.WriteLine("Hola Mundo");

            strWrite.Close();
 
            }

            

            
        }

        private void leerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader strRead = new StreamReader(openFileDialog1.FileName);
                /*
                while (!strRead.EndOfStream)
                {
                    this.listBox1.Items.Add(strRead.ReadLine());                    
                }
                */
                MessageBox.Show(strRead.ReadToEnd());
                strRead.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
