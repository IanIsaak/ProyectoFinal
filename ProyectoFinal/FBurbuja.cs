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
    public partial class FBurbuja : Form
    {
        public FBurbuja()
        {
            InitializeComponent();
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            int[] Numeros = Arreglos();
            TxtArregloGen.Text = String.Join(",", Numeros);
            Burbuja(Numeros);
            void Burbuja(int[] Numeros)
            {
                int cont = 0;
                for (int j = 0; j < Numeros.Length - 1; j++)
                {
                    for (int i = 0; i < (Numeros.Length - 1 - j); i++)
                    {
                        if (Numeros[i] > Numeros[i + 1])
                        {
                            int Aux = Numeros[i];
                            Numeros[i] = Numeros[i + 1];
                            Numeros[i + 1] = Aux;
                        }
                        TxtArregloOrden.Text = String.Join(",", Numeros);
                        cont++;
                    }
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
