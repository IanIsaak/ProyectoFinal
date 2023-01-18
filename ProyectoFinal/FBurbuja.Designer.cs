namespace ProyectoFinal
{
    partial class FBurbuja
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTamañoArreglo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnOrdenar = new System.Windows.Forms.Button();
            this.TxtArregloGen = new System.Windows.Forms.TextBox();
            this.TxtArregloOrden = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca el tamaño del arreglo:";
            // 
            // TxtTamañoArreglo
            // 
            this.TxtTamañoArreglo.Location = new System.Drawing.Point(12, 41);
            this.TxtTamañoArreglo.Name = "TxtTamañoArreglo";
            this.TxtTamañoArreglo.Size = new System.Drawing.Size(230, 27);
            this.TxtTamañoArreglo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "El arreglo generado es:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "El arreglo ordenado es:";
            // 
            // BtnOrdenar
            // 
            this.BtnOrdenar.Location = new System.Drawing.Point(438, 84);
            this.BtnOrdenar.Name = "BtnOrdenar";
            this.BtnOrdenar.Size = new System.Drawing.Size(178, 67);
            this.BtnOrdenar.TabIndex = 6;
            this.BtnOrdenar.Text = "Ordenar!";
            this.BtnOrdenar.UseVisualStyleBackColor = true;
            this.BtnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // TxtArregloGen
            // 
            this.TxtArregloGen.Location = new System.Drawing.Point(12, 118);
            this.TxtArregloGen.Name = "TxtArregloGen";
            this.TxtArregloGen.Size = new System.Drawing.Size(230, 27);
            this.TxtArregloGen.TabIndex = 7;
            // 
            // TxtArregloOrden
            // 
            this.TxtArregloOrden.Location = new System.Drawing.Point(11, 181);
            this.TxtArregloOrden.Name = "TxtArregloOrden";
            this.TxtArregloOrden.Size = new System.Drawing.Size(230, 27);
            this.TxtArregloOrden.TabIndex = 8;
            // 
            // FBurbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 268);
            this.Controls.Add(this.TxtArregloOrden);
            this.Controls.Add(this.TxtArregloGen);
            this.Controls.Add(this.BtnOrdenar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTamañoArreglo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FBurbuja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenación por burbuja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtTamañoArreglo;
        private Label label2;
        private Label label3;
        private Button BtnOrdenar;
        private TextBox TxtArregloGen;
        private TextBox TxtArregloOrden;
    }
}