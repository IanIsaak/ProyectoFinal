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
    public partial class FSumaParesArray : Form
    {
        public FSumaParesArray()
        {
            InitializeComponent();
        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            int[] Numeros = Arreglos();
            TxtArregloGen.Text = String.Join(",", Numeros);
            Suma(Numeros);
            void Suma(int[] arreglo)
            {
                int sum = 0;
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (arreglo[i]%2==0)
                    {
                        sum += arreglo[i];
                    }
                }
                TxtSumaArreglo.Text = String.Join(",", sum);
            }
            int[] Arreglos()
            {
                int[] Numeros = new int[1];
                int n = int.Parse(TxtTamañoArreglo.Text);
                Array.Resize(ref Numeros, n);
                Random Num = new Random();
                for (int i = 0; i < n; i++)
                {
                    Numeros[i] = Num.Next(40);
                }
                return Numeros;
            }
        }
    }
}
