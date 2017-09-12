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

namespace FrmTempera
{
    public partial class FrmTempera : Form
    {


        private Tempera _tempera;
        

        public FrmTempera()
        {
            InitializeComponent();
        }

        private void FrmTempera_Load(object sender, EventArgs e)
        {

        }

        public Tempera getTempera()
        {
            return this._tempera;
        }
    }
}
