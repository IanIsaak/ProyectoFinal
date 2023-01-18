namespace ProyectoFinal
{
    partial class FOptimizacion
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
            this.BoRutaCritica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoRutaCritica
            // 
            this.BoRutaCritica.Location = new System.Drawing.Point(325, 167);
            this.BoRutaCritica.Name = "BoRutaCritica";
            this.BoRutaCritica.Size = new System.Drawing.Size(161, 81);
            this.BoRutaCritica.TabIndex = 0;
            this.BoRutaCritica.Text = "Ruta Critica";
            this.BoRutaCritica.UseVisualStyleBackColor = true;
            // 
            // FOptimizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoRutaCritica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FOptimizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmos de optimización";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BoRutaCritica;
    }
}