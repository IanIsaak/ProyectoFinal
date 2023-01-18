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
    public partial class FBurbujaBandera : Form
    {
        public FBurbujaBandera()
        {
            InitializeComponent();
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            int[] Numeros = Arreglos();
            TxtArregloGen.Text = String.Join(",", Numeros);
            BurbujaB(Numeros);
            void BurbujaB(int[] Numeros)
            {
                int cont = 0;
                int bandera;
                for (int j = 0; j < Numeros.Length - 1; j++)
                {
                    bandera = 0;
                    for (int i = 0; i < (Numeros.Length - 1 - j); i++)
                    {
                        if (Numeros[i] > Numeros[i + 1])
                        {
                            int Aux = Numeros[i];
                            Numeros[i] = Numeros[i + 1];
                            Numeros[i + 1] = Aux;
                            bandera = 1;
                        }
                        TxtArregloOrden.Text = String.Join(",", Numeros);
                        cont++;
                    }
                    if (bandera == 0) { break; }
                }
            }
            int[] Arreglos()
            {
                int[] Numeros = new int[1];
                int n = int.Parse(TxtTamañoArreglo.Text);
                Array.Resize(ref Numeros, n);
                Random Num = new Random();
                for (int i = 0; i < n; i++)
                {
                    Numeros[i] = Num.Next(1000);
                }
                return Numeros;
            }
        }
    }
}
