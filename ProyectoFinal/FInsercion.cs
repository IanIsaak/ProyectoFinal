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
    public partial class FInsercion : Form
    {
        public FInsercion()
        {
            InitializeComponent();
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            int[] Numeros = Arreglos();
            TxtArregloGen.Text = String.Join(",", Numeros);
            Insercion(Numeros);
            void Insercion(int[] Numeros)
            {
                int temp, j;
                for (int i = 1; i < Numeros.Length; i++)
                {
                    temp = Numeros[i];
                    j = i - 1;

                    while (j >= 0 && Numeros[j] > temp)
                    {
                        Numeros[j + 1] = Numeros[j];
                        j--;
                    }
                    Numeros[j + 1] = temp;
                    TxtArregloOrden.Text = String.Join(",", Numeros);
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
