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
    public partial class FShell : Form
    {
        public FShell()
        {
            InitializeComponent();
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            int[] Numeros = Arreglos();
            TxtArregloGen.Text = String.Join(",", Numeros);
            Shell(Numeros);
            void Shell(int[] arreglo)
            {
                int div = arreglo.Length / 2;

                do
                {
                    int aux = 0;
                    for (int i = 0; i < arreglo.Length - div; i++)
                    {
                        for (int j = i + div; j < arreglo.Length; j++)
                        {
                            if (arreglo[i] > arreglo[j])
                            {
                                aux = arreglo[j];
                                arreglo[j] = arreglo[i];
                                arreglo[i] = aux;
                            }
                        }

                    }
                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        TxtArregloOrden.Text = String.Join(",", arreglo);
                    }
                    Console.WriteLine();
                    div = div / 2;
                } while (div != 0);

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
