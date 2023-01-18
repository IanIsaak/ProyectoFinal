namespace ProyectoFinal
{
    partial class FImagen
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
            this.BoVisualizacion = new System.Windows.Forms.Button();
            this.BoEscalaGrises = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoVisualizacion
            // 
            this.BoVisualizacion.Location = new System.Drawing.Point(346, 256);
            this.BoVisualizacion.Name = "BoVisualizacion";
            this.BoVisualizacion.Size = new System.Drawing.Size(114, 57);
            this.BoVisualizacion.TabIndex = 0;
            this.BoVisualizacion.Text = "Binarización";
            this.BoVisualizacion.UseVisualStyleBackColor = true;
            // 
            // BoEscalaGrises
            // 
            this.BoEscalaGrises.Location = new System.Drawing.Point(346, 116);
            this.BoEscalaGrises.Name = "BoEscalaGrises";
            this.BoEscalaGrises.Size = new System.Drawing.Size(114, 57);
            this.BoEscalaGrises.TabIndex = 1;
            this.BoEscalaGrises.Text = "Escala de grises";
            this.BoEscalaGrises.UseVisualStyleBackColor = true;
            // 
            // FImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoEscalaGrises);
            this.Controls.Add(this.BoVisualizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesamiento de imagenes";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BoVisualizacion;
        private Button BoEscalaGrises;
    }
}