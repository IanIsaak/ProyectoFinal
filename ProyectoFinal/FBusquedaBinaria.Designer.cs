namespace ProyectoFinal
{
    partial class FBusquedaBinaria
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
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPosicion = new System.Windows.Forms.TextBox();
            this.TxtArregloGen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(590, 121);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(178, 67);
            this.btnBusqueda.TabIndex = 31;
            this.btnBusqueda.Text = "Buscar!";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(292, 141);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(222, 27);
            this.txtResultado.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "La posicion en la que se encuentra es:";
            // 
            // TxtPosicion
            // 
            this.TxtPosicion.Location = new System.Drawing.Point(12, 200);
            this.TxtPosicion.Name = "TxtPosicion";
            this.TxtPosicion.Size = new System.Drawing.Size(230, 27);
            this.TxtPosicion.TabIndex = 29;
            // 
            // TxtArregloGen
            // 
            this.TxtArregloGen.Location = new System.Drawing.Point(12, 75);
            this.TxtArregloGen.Name = "TxtArregloGen";
            this.TxtArregloGen.Size = new System.Drawing.Size(230, 27);
            this.TxtArregloGen.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Introduzca el valor a encontrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "El arreglo generado es:";
            // 
            // FBusquedaBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 269);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPosicion);
            this.Controls.Add(this.TxtArregloGen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FBusquedaBinaria";
            this.Text = "FBusquedaBinaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBusqueda;
        private TextBox txtResultado;
        private Label label4;
        private TextBox TxtPosicion;
        private TextBox TxtArregloGen;
        private Label label3;
        private Label label2;
    }
}