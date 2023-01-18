namespace ProyectoFinal
{
    partial class FBusqueda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoBusquedaLineal = new System.Windows.Forms.Button();
            this.BoBusquedaBinaria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoBusquedaLineal
            // 
            this.BoBusquedaLineal.Location = new System.Drawing.Point(339, 72);
            this.BoBusquedaLineal.Name = "BoBusquedaLineal";
            this.BoBusquedaLineal.Size = new System.Drawing.Size(117, 88);
            this.BoBusquedaLineal.TabIndex = 0;
            this.BoBusquedaLineal.Text = "Busqueda Lineal";
            this.BoBusquedaLineal.UseVisualStyleBackColor = true;
            this.BoBusquedaLineal.Click += new System.EventHandler(this.BoBusquedaLineal_Click);
            // 
            // BoBusquedaBinaria
            // 
            this.BoBusquedaBinaria.Location = new System.Drawing.Point(339, 233);
            this.BoBusquedaBinaria.Name = "BoBusquedaBinaria";
            this.BoBusquedaBinaria.Size = new System.Drawing.Size(117, 88);
            this.BoBusquedaBinaria.TabIndex = 1;
            this.BoBusquedaBinaria.Text = "Busqueda Binaria";
            this.BoBusquedaBinaria.UseVisualStyleBackColor = true;
            this.BoBusquedaBinaria.Click += new System.EventHandler(this.BoBusquedaBinaria_Click);
            // 
            // FBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoBusquedaBinaria);
            this.Controls.Add(this.BoBusquedaLineal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmos de busqueda";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BoBusquedaLineal;
        private Button BoBusquedaBinaria;
    }
}