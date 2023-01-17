namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoAlgoritmosOrdenacion = new System.Windows.Forms.Button();
            this.BoAlgorimosBusqueda = new System.Windows.Forms.Button();
            this.BoOptimizacion = new System.Windows.Forms.Button();
            this.BoProcesamientoImagen = new System.Windows.Forms.Button();
            this.BoOtro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoAlgoritmosOrdenacion
            // 
            this.BoAlgoritmosOrdenacion.Location = new System.Drawing.Point(110, 51);
            this.BoAlgoritmosOrdenacion.Name = "BoAlgoritmosOrdenacion";
            this.BoAlgoritmosOrdenacion.Size = new System.Drawing.Size(122, 71);
            this.BoAlgoritmosOrdenacion.TabIndex = 0;
            this.BoAlgoritmosOrdenacion.Text = "Algoritmos Ordenacion";
            this.BoAlgoritmosOrdenacion.UseVisualStyleBackColor = true;
            this.BoAlgoritmosOrdenacion.Click += new System.EventHandler(this.BoAlgoritmosOrdenacion_Click);
            // 
            // BoAlgorimosBusqueda
            // 
            this.BoAlgorimosBusqueda.Location = new System.Drawing.Point(543, 51);
            this.BoAlgorimosBusqueda.Name = "BoAlgorimosBusqueda";
            this.BoAlgorimosBusqueda.Size = new System.Drawing.Size(122, 71);
            this.BoAlgorimosBusqueda.TabIndex = 1;
            this.BoAlgorimosBusqueda.Text = "Algoritmos Busqueda";
            this.BoAlgorimosBusqueda.UseVisualStyleBackColor = true;
            this.BoAlgorimosBusqueda.Click += new System.EventHandler(this.BoAlgorimosBusqueda_Click);
            // 
            // BoOptimizacion
            // 
            this.BoOptimizacion.Location = new System.Drawing.Point(110, 263);
            this.BoOptimizacion.Name = "BoOptimizacion";
            this.BoOptimizacion.Size = new System.Drawing.Size(122, 71);
            this.BoOptimizacion.TabIndex = 2;
            this.BoOptimizacion.Text = "Algoritmos Optimizacion";
            this.BoOptimizacion.UseVisualStyleBackColor = true;
            this.BoOptimizacion.Click += new System.EventHandler(this.BoOptimizacion_Click);
            // 
            // BoProcesamientoImagen
            // 
            this.BoProcesamientoImagen.Location = new System.Drawing.Point(543, 263);
            this.BoProcesamientoImagen.Name = "BoProcesamientoImagen";
            this.BoProcesamientoImagen.Size = new System.Drawing.Size(122, 71);
            this.BoProcesamientoImagen.TabIndex = 3;
            this.BoProcesamientoImagen.Text = "Procesamiento Imagen";
            this.BoProcesamientoImagen.UseVisualStyleBackColor = true;
            this.BoProcesamientoImagen.Click += new System.EventHandler(this.BoProcesamientoImagen_Click);
            // 
            // BoOtro
            // 
            this.BoOtro.Location = new System.Drawing.Point(339, 162);
            this.BoOtro.Name = "BoOtro";
            this.BoOtro.Size = new System.Drawing.Size(122, 71);
            this.BoOtro.TabIndex = 4;
            this.BoOtro.Text = "Algoritmos Otro";
            this.BoOtro.UseVisualStyleBackColor = true;
            this.BoOtro.Click += new System.EventHandler(this.BoOtro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoOtro);
            this.Controls.Add(this.BoProcesamientoImagen);
            this.Controls.Add(this.BoOptimizacion);
            this.Controls.Add(this.BoAlgorimosBusqueda);
            this.Controls.Add(this.BoAlgoritmosOrdenacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BoAlgoritmosOrdenacion;
        private Button BoAlgorimosBusqueda;
        private Button BoOptimizacion;
        private Button BoProcesamientoImagen;
        private Button BoOtro;
    }
}