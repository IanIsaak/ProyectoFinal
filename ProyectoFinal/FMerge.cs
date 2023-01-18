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
    public partial class FMerge : Form
    {
        public FMerge()
        {
            InitializeComponent();
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            int[] Numeros = Arreglos();
            TxtArregloGen.Text = String.Join(",", Numeros);
            mergeSort(Numeros, 0, Numeros.Length - 1);
            void mergeSort(int[] arr, int p, int r)
            {
                //arr es arreglo, p es inicio, r es el final del arreglo
                if (p < r)
                {
                    int m = (p + r) / 2;
                    mergeSort(arr, p, m);
                    mergeSort(arr, m + 1, r);
                    merge(arr, p, m, r);
                }
                TxtArregloOrden.Text = String.Join(",", Numeros);
            }
            void merge(int[] arr, int p, int m, int r)
            {
                int i, j, k;

                int n1 = m - p + 1;

                int n2 = r - m;

                int[] L = new int[n1];
                int[] R = new int[n2];

                for (i = 0; i < n1; i++)
                {
                    L[i] = arr[p + i];
                }

                for (j = 0; j < n2; j++)
                {
                    R[j] = arr[m + 1 + j];
                }

                i = 0;
                j = 0;
                k = p;

                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j++;
                    }
                    k++;
                }

                while (i < n1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }

                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
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
