namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BoAlgorimosBusqueda_Click(object sender, EventArgs e)
        {
            FBusqueda Obj1 = new FBusqueda();
            Obj1.Show();
        }

        private void BoAlgoritmosOrdenacion_Click(object sender, EventArgs e)
        {
            FOrdenacion Obj2 = new FOrdenacion();
            Obj2.Show();
        }

        private void BoOptimizacion_Click(object sender, EventArgs e)
        {
            FOptimizacion Obj3 = new FOptimizacion();
            Obj3.Show();
        }

        private void BoProcesamientoImagen_Click(object sender, EventArgs e)
        {
            FImagen Obj4 = new FImagen();
            Obj4.Show();
        }

        private void BoOtro_Click(object sender, EventArgs e)
        {
            FOtro Obj5 = new FOtro();
            Obj5.Show();
        }
    }
}