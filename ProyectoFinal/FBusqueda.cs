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
    public partial class FBusqueda : Form
    {
        public FBusqueda()
        {
            InitializeComponent();
        }

        private void BoBusquedaLineal_Click(object sender, EventArgs e)
        {
            FBusquedaLineal Obj1 = new FBusquedaLineal();
            Obj1.Show();
        }

        private void BoBusquedaBinaria_Click(object sender, EventArgs e)
        {
            FBusquedaBinaria Obj2 = new FBusquedaBinaria();
            Obj2.Show();
        }
    }
}
