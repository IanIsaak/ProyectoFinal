namespace ProyectoFinal
{
    partial class FBusquedaLineal
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
            this.TxtPosicion = new System.Windows.Forms.TextBox();
            this.TxtArregloGen = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPosicion
            // 
            this.TxtPosicion.Location = new System.Drawing.Point(12, 181);
            this.TxtPosicion.Name = "TxtPosicion";
            this.TxtPosicion.Size = new System.Drawing.Size(230, 27);
            this.TxtPosicion.TabIndex = 22;
            // 
            // TxtArregloGen
            // 
            this.TxtArregloGen.Location = new System.Drawing.Point(12, 56);
            this.TxtArregloGen.Name = "TxtArregloGen";
            this.TxtArregloGen.Size = new System.Drawing.Size(230, 27);
            this.TxtArregloGen.TabIndex = 21;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(590, 102);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(178, 67);
            this.BtnBuscar.TabIndex = 20;
            this.BtnBuscar.Text = "Buscar!";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Introduzca el valor a encontrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "El arreglo generado es:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "La posicion en la que se encuentra es:";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(273, 125);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 20);
            this.LblResultado.TabIndex = 24;
            // 
            // FBusquedaLineal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 260);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPosicion);
            this.Controls.Add(this.TxtArregloGen);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FBusquedaLineal";
            this.Text = "FBusquedaLineal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtPosicion;
        private TextBox TxtArregloGen;
        private Button BtnBuscar;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label LblResultado;
    }
}