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
    public partial class FBusquedaBinaria : Form
    {
        public FBusquedaBinaria()
        {
            InitializeComponent();
            TxtArregloGen.Text = "9,1,5,7,1,-1,8,12,45,12";
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            int[] Numeros = Arreglos();
            Binaria(Numeros);

            void Binaria(int[] Numeros)
            {
                int IMin, IMax, pivote, NumeroB, indice;
                indice = -1;
                NumeroB = 10;
                IMin = 0;
                IMax = Numeros.Length - 1;

                do
                {
                    pivote = (IMax + IMin) / 2;
                    if (NumeroB == Numeros[pivote])
                    {
                        indice = pivote;
                    }
                    else if (NumeroB > Numeros[pivote])
                    {
                        IMin = pivote + 1;
                    }
                    else
                    {
                        IMax = pivote - 1;
                    }
                } while (IMax > IMin);
                txtResultado.Text = String.Join("El resultado es: ", pivote + 1);
            }
        }

            int[] Arreglos()
            {
                int[] Numeros = new int[10];
                Numeros[0] = 9;
                Numeros[1] = 1;
                Numeros[2] = 5;
                Numeros[3] = 7;
                Numeros[4] = 1;
                Numeros[5] = -1;
                Numeros[6] = 8;
                Numeros[7] = 12;
                Numeros[8] = 45;
                Numeros[9] = 12;
                return Numeros;
            }
        }

    }
