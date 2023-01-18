using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FImagen : Form
    {
        public FImagen()
        {
            InitializeComponent();
        }

        private void BoEscalaGrises_Click(object sender, EventArgs e)
        {
            frmGrises Obj1 = new frmGrises();
            Obj1.Show();
        }
    }
}
