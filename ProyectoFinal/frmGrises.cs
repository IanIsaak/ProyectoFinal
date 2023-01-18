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
    public partial class frmGrises : Form
    {
        public frmGrises()
        {
            InitializeComponent();
            dgdR.RowCount = 3;
            dgdR.Rows[0].Cells[0].Value = 142;
            dgdR.Rows[0].Cells[1].Value = 221;
            dgdR.Rows[0].Cells[2].Value = 247;
            dgdR.Rows[1].Cells[0].Value = 104;
            dgdR.Rows[1].Cells[1].Value = 253;
            dgdR.Rows[1].Cells[2].Value = 173;
            dgdR.Rows[2].Cells[0].Value = 207;
            dgdR.Rows[2].Cells[1].Value = 126;
            dgdR.Rows[2].Cells[2].Value = 10;

            dgdG.RowCount = 3;
            dgdG.Rows[0].Cells[0].Value = 46;
            dgdG.Rows[0].Cells[1].Value = 25;
            dgdG.Rows[0].Cells[2].Value = 29;
            dgdG.Rows[1].Cells[0].Value = 160;
            dgdG.Rows[1].Cells[1].Value = 238;
            dgdG.Rows[1].Cells[2].Value = 202;
            dgdG.Rows[2].Cells[0].Value = 249;
            dgdG.Rows[2].Cells[1].Value = 250;
            dgdG.Rows[2].Cells[2].Value = 196;

            dgdB.RowCount = 3;
            dgdB.Rows[0].Cells[0].Value = 175;
            dgdB.Rows[0].Cells[1].Value = 90;
            dgdB.Rows[0].Cells[2].Value = 59;
            dgdB.Rows[1].Cells[0].Value = 225;
            dgdB.Rows[1].Cells[1].Value = 18;
            dgdB.Rows[1].Cells[2].Value = 67;
            dgdB.Rows[2].Cells[0].Value = 188;
            dgdB.Rows[2].Cells[1].Value = 163;
            dgdB.Rows[2].Cells[2].Value = 141;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgdGris.RowCount = 3;
            dgdGris.ColumnCount = 3;

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    int r = int.Parse(dgdR.Rows[f].Cells[c].Value.ToString());
                    int g = int.Parse(dgdG.Rows[f].Cells[c].Value.ToString());
                    int b = int.Parse(dgdB.Rows[f].Cells[c].Value.ToString());

                    double valorr;
                    valorr = (r * 0.2989) + (g * 0.5870) + (b * 0.1140);
                    dgdGris.Rows[f].Cells[c].Value = Convert.ToInt32(valorr);


                    //double valorr;
                    //valorr = (r[f, c] * 0.2989) + (g[f, c] * 0.5870) + (b[f, c] * 0.1140);
                    //gris[f, c] = Convert.ToInt32(valorr);

                }
            }
        }
    }
}
