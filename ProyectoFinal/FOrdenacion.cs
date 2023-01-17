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
    public partial class FOrdenacion : Form
    {
        public FOrdenacion()
        {
            InitializeComponent();
        }

        private void BoBurbuja_Click(object sender, EventArgs e)
        {
            FBurbuja Obj1 = new FBurbuja();
            Obj1.Show();
        }

        private void BoBurbujaBandera_Click(object sender, EventArgs e)
        {
            FBurbujaBandera Obj2 = new FBurbujaBandera();
            Obj2.Show();
        }

        private void BoOrdenacionSeleccion_Click(object sender, EventArgs e)
        {
            FSeleccion Obj3 = new FSeleccion();
            Obj3.Show();
        }

        private void BoOrdenacionInsercion_Click(object sender, EventArgs e)
        {
            FInsercion Obj4 = new FInsercion();
            Obj4.Show();
        }

        private void BoOrdenacionShell_Click(object sender, EventArgs e)
        {
            FShell Obj5 = new FShell();
            Obj5.Show();
        }

        private void BoOrdenacionQuick_Click(object sender, EventArgs e)
        {
            FQuick Obj6 = new FQuick();
            Obj6.Show();
        }

        private void BoOrdenacionRadix_Click(object sender, EventArgs e)
        {
            FRadix Obj7 = new FRadix(); 
            Obj7.Show();
        }
    }
}
