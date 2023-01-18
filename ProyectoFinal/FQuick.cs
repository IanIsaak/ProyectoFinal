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
    public partial class FQuick : Form
    {
        public FQuick()
        {
            InitializeComponent();
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            int[] Numeros = Arreglos();
            TxtArregloGen.Text = String.Join(",", Numeros);
            QuickSort(Numeros, 0, Numeros.Length - 1);
            void QuickSort(int[] numeros, int primero, int ultimo)
            {
                int i, j, central;
                double pivote;
                central = (primero + ultimo) / 2;
                pivote = numeros[central];
                i = primero;
                j = ultimo;
                do
                {
                    Console.WriteLine("Pivote> " + pivote);
                    while (numeros[i] < pivote) i++;
                    while (numeros[j] > pivote) j--;
                    if (i <= j)
                    {
                        int temp;
                        temp = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = temp;
                        i++;
                        j--;
                    }
                    TxtArregloOrden.Text = String.Join(",", Numeros);
                } while (i <= j);

                if (primero < j)
                {
                    QuickSort(numeros, primero, j);

                }
                if (i < ultimo)
                {
                    QuickSort(numeros, i, ultimo);

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
