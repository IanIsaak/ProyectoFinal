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
    public partial class frmBin : Form
    {
        public frmBin()
        {
            InitializeComponent();

            dgvPrimario.RowCount = 3;
            dgvPrimario.ColumnCount = 3;
            dgvPrimario.Rows[0].Cells[0].Value = 142;
            dgvPrimario.Rows[0].Cells[1].Value = 221;
            dgvPrimario.Rows[0].Cells[2].Value = 247;
            dgvPrimario.Rows[1].Cells[0].Value = 104;
            dgvPrimario.Rows[1].Cells[1].Value = 253;
            dgvPrimario.Rows[1].Cells[2].Value = 173;
            dgvPrimario.Rows[2].Cells[0].Value = 207;
            dgvPrimario.Rows[2].Cells[1].Value = 126;
            dgvPrimario.Rows[2].Cells[2].Value = 10;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvGenerado.RowCount = 3;
            dgvGenerado.ColumnCount = 3;

            int valor = Int16.Parse(txtValor.Text);

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    int numero = int.Parse(dgvPrimario.Rows[f].Cells[c].Value.ToString());

                    if (numero >= valor)
                    {
                        dgvGenerado.Rows[f].Cells[c].Value = 1;
                    }
                    else
                    {
                        dgvGenerado.Rows[f].Cells[c].Value = 0;
                    }

                }
            }


        }
    }
}
