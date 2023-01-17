namespace ProyectoFinal
{
    partial class FOrdenacion
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
            this.BoBurbuja = new System.Windows.Forms.Button();
            this.BoBurbujaBandera = new System.Windows.Forms.Button();
            this.BoOrdenacionSeleccion = new System.Windows.Forms.Button();
            this.BoOrdenacionInsercion = new System.Windows.Forms.Button();
            this.BoOrdenacionShell = new System.Windows.Forms.Button();
            this.BoOrdenacionMerge = new System.Windows.Forms.Button();
            this.BoOrdenacionRadix = new System.Windows.Forms.Button();
            this.BoOrdenacionQuick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoBurbuja
            // 
            this.BoBurbuja.Location = new System.Drawing.Point(330, 33);
            this.BoBurbuja.Name = "BoBurbuja";
            this.BoBurbuja.Size = new System.Drawing.Size(135, 58);
            this.BoBurbuja.TabIndex = 0;
            this.BoBurbuja.Text = "Ordenacion Burbuja";
            this.BoBurbuja.UseVisualStyleBackColor = true;
            this.BoBurbuja.Click += new System.EventHandler(this.BoBurbuja_Click);
            // 
            // BoBurbujaBandera
            // 
            this.BoBurbujaBandera.Location = new System.Drawing.Point(330, 97);
            this.BoBurbujaBandera.Name = "BoBurbujaBandera";
            this.BoBurbujaBandera.Size = new System.Drawing.Size(135, 58);
            this.BoBurbujaBandera.TabIndex = 1;
            this.BoBurbujaBandera.Text = "Ordenacion Burbuja Bandera";
            this.BoBurbujaBandera.UseVisualStyleBackColor = true;
            this.BoBurbujaBandera.Click += new System.EventHandler(this.BoBurbujaBandera_Click);
            // 
            // BoOrdenacionSeleccion
            // 
            this.BoOrdenacionSeleccion.Location = new System.Drawing.Point(330, 161);
            this.BoOrdenacionSeleccion.Name = "BoOrdenacionSeleccion";
            this.BoOrdenacionSeleccion.Size = new System.Drawing.Size(135, 58);
            this.BoOrdenacionSeleccion.TabIndex = 2;
            this.BoOrdenacionSeleccion.Text = "Ordenacion Seleccion";
            this.BoOrdenacionSeleccion.UseVisualStyleBackColor = true;
            this.BoOrdenacionSeleccion.Click += new System.EventHandler(this.BoOrdenacionSeleccion_Click);
            // 
            // BoOrdenacionInsercion
            // 
            this.BoOrdenacionInsercion.Location = new System.Drawing.Point(330, 225);
            this.BoOrdenacionInsercion.Name = "BoOrdenacionInsercion";
            this.BoOrdenacionInsercion.Size = new System.Drawing.Size(135, 58);
            this.BoOrdenacionInsercion.TabIndex = 3;
            this.BoOrdenacionInsercion.Text = "Ordenacion Insercion";
            this.BoOrdenacionInsercion.UseVisualStyleBackColor = true;
            this.BoOrdenacionInsercion.Click += new System.EventHandler(this.BoOrdenacionInsercion_Click);
            // 
            // BoOrdenacionShell
            // 
            this.BoOrdenacionShell.Location = new System.Drawing.Point(330, 289);
            this.BoOrdenacionShell.Name = "BoOrdenacionShell";
            this.BoOrdenacionShell.Size = new System.Drawing.Size(135, 58);
            this.BoOrdenacionShell.TabIndex = 4;
            this.BoOrdenacionShell.Text = "Ordenacion Shell";
            this.BoOrdenacionShell.UseVisualStyleBackColor = true;
            this.BoOrdenacionShell.Click += new System.EventHandler(this.BoOrdenacionShell_Click);
            // 
            // BoOrdenacionMerge
            // 
            this.BoOrdenacionMerge.Location = new System.Drawing.Point(330, 353);
            this.BoOrdenacionMerge.Name = "BoOrdenacionMerge";
            this.BoOrdenacionMerge.Size = new System.Drawing.Size(135, 58);
            this.BoOrdenacionMerge.TabIndex = 5;
            this.BoOrdenacionMerge.Text = "Ordenacion Merge";
            this.BoOrdenacionMerge.UseVisualStyleBackColor = true;
            // 
            // BoOrdenacionRadix
            // 
            this.BoOrdenacionRadix.Location = new System.Drawing.Point(471, 195);
            this.BoOrdenacionRadix.Name = "BoOrdenacionRadix";
            this.BoOrdenacionRadix.Size = new System.Drawing.Size(135, 58);
            this.BoOrdenacionRadix.TabIndex = 6;
            this.BoOrdenacionRadix.Text = "Ordenacion Radix";
            this.BoOrdenacionRadix.UseVisualStyleBackColor = true;
            this.BoOrdenacionRadix.Click += new System.EventHandler(this.BoOrdenacionRadix_Click);
            // 
            // BoOrdenacionQuick
            // 
            this.BoOrdenacionQuick.Location = new System.Drawing.Point(189, 195);
            this.BoOrdenacionQuick.Name = "BoOrdenacionQuick";
            this.BoOrdenacionQuick.Size = new System.Drawing.Size(135, 58);
            this.BoOrdenacionQuick.TabIndex = 7;
            this.BoOrdenacionQuick.Text = "Ordenacion Quick";
            this.BoOrdenacionQuick.UseVisualStyleBackColor = true;
            this.BoOrdenacionQuick.Click += new System.EventHandler(this.BoOrdenacionQuick_Click);
            // 
            // FOrdenacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoOrdenacionQuick);
            this.Controls.Add(this.BoOrdenacionRadix);
            this.Controls.Add(this.BoOrdenacionMerge);
            this.Controls.Add(this.BoOrdenacionShell);
            this.Controls.Add(this.BoOrdenacionInsercion);
            this.Controls.Add(this.BoOrdenacionSeleccion);
            this.Controls.Add(this.BoBurbujaBandera);
            this.Controls.Add(this.BoBurbuja);
            this.Name = "FOrdenacion";
            this.Text = "FOrdenacion";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BoBurbuja;
        private Button BoBurbujaBandera;
        private Button BoOrdenacionSeleccion;
        private Button BoOrdenacionInsercion;
        private Button BoOrdenacionShell;
        private Button BoOrdenacionMerge;
        private Button BoOrdenacionRadix;
        private Button BoOrdenacionQuick;
    }
}