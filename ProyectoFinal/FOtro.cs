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
    public partial class FOtro : Form
    {
        public FOtro()
        {
            InitializeComponent();
        }

        private void BoOtros_Click(object sender, EventArgs e)
        {
            FSumaParesArray Obj1 = new FSumaParesArray();
            Obj1.Show();
        }
    }
}
