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
    public partial class FBusquedaLineal : Form
    {
        public FBusquedaLineal()
        {
            InitializeComponent();
            TxtArregloGen.Text = "9,1,5,7,1,-1,8,12,45,12";
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {

            int[] Numeros = Arreglos();
            Lineal(Numeros);

            int Busqueda(int[] Arr, int llave)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i] == llave)
                    {
                        return i;
                    }
                }
                return -1;
            }

            void Lineal(int[] Numeros)
            {
                int llave = Int16.Parse(TxtPosicion.Text);
                int resultado = Busqueda(Numeros, llave);
                if (resultado == -1)
                {
                    txtResultado.Text = ("El elemento no existe");
                }
                else
                {
                    txtResultado.Text = String.Join("El resultado es: ", resultado + 1);
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
}