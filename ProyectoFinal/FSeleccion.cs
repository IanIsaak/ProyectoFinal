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
    public partial class FSeleccion : Form
    {
        public FSeleccion()
        {
            InitializeComponent();
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            int[] Numeros = Arreglos();
            TxtArregloGen.Text = String.Join(",", Numeros);
            Seleccion(Numeros);
            void Seleccion(int[] Numeros)
            {
                int UElemento = Numeros.Length - 1;
                for (int j = 0; j < Numeros.Length; j++)
                {
                    int IMayor = 0;
                    for (int i = 1; i <= UElemento; i++)
                    {
                        if (Numeros[IMayor] < Numeros[i])
                        {
                            IMayor = i;
                        }
                    }
                    int Aux = Numeros[UElemento];
                    Numeros[UElemento] = Numeros[IMayor];
                    Numeros[IMayor] = Aux;
                    UElemento--;
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
