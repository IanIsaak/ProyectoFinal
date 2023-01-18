namespace ProyectoFinal
{
    partial class FMerge
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
            this.TxtArregloOrden = new System.Windows.Forms.TextBox();
            this.TxtArregloGen = new System.Windows.Forms.TextBox();
            this.BtnOrdenar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTamañoArreglo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtArregloOrden
            // 
            this.TxtArregloOrden.Location = new System.Drawing.Point(17, 192);
            this.TxtArregloOrden.Name = "TxtArregloOrden";
            this.TxtArregloOrden.Size = new System.Drawing.Size(230, 27);
            this.TxtArregloOrden.TabIndex = 29;
            // 
            // TxtArregloGen
            // 
            this.TxtArregloGen.Location = new System.Drawing.Point(18, 129);
            this.TxtArregloGen.Name = "TxtArregloGen";
            this.TxtArregloGen.Size = new System.Drawing.Size(230, 27);
            this.TxtArregloGen.TabIndex = 28;
            // 
            // BtnOrdenar
            // 
            this.BtnOrdenar.Location = new System.Drawing.Point(444, 95);
            this.BtnOrdenar.Name = "BtnOrdenar";
            this.BtnOrdenar.Size = new System.Drawing.Size(178, 67);
            this.BtnOrdenar.TabIndex = 27;
            this.BtnOrdenar.Text = "Ordenar!";
            this.BtnOrdenar.UseVisualStyleBackColor = true;
            this.BtnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "El arreglo ordenado es:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "El arreglo generado es:";
            // 
            // TxtTamañoArreglo
            // 
            this.TxtTamañoArreglo.Location = new System.Drawing.Point(18, 52);
            this.TxtTamañoArreglo.Name = "TxtTamañoArreglo";
            this.TxtTamañoArreglo.Size = new System.Drawing.Size(230, 27);
            this.TxtTamañoArreglo.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Introduzca el tamaño del arreglo:";
            // 
            // FMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 269);
            this.Controls.Add(this.TxtArregloOrden);
            this.Controls.Add(this.TxtArregloGen);
            this.Controls.Add(this.BtnOrdenar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTamañoArreglo);
            this.Controls.Add(this.label1);
            this.Name = "FMerge";
            this.Text = "FMerge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtArregloOrden;
        private TextBox TxtArregloGen;
        private Button BtnOrdenar;
        private Label label3;
        private Label label2;
        private TextBox TxtTamañoArreglo;
        private Label label1;
    }
}