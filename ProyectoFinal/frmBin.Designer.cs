namespace ProyectoFinal
{
    partial class frmBin
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
            this.dgvPrimario = new System.Windows.Forms.DataGridView();
            this.dgvGenerado = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrimario
            // 
            this.dgvPrimario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimario.Location = new System.Drawing.Point(120, 264);
            this.dgvPrimario.Name = "dgvPrimario";
            this.dgvPrimario.RowHeadersWidth = 51;
            this.dgvPrimario.RowTemplate.Height = 29;
            this.dgvPrimario.Size = new System.Drawing.Size(300, 188);
            this.dgvPrimario.TabIndex = 0;
            // 
            // dgvGenerado
            // 
            this.dgvGenerado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenerado.Location = new System.Drawing.Point(543, 264);
            this.dgvGenerado.Name = "dgvGenerado";
            this.dgvGenerado.RowHeadersWidth = 51;
            this.dgvGenerado.RowTemplate.Height = 29;
            this.dgvGenerado.Size = new System.Drawing.Size(300, 188);
            this.dgvGenerado.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(421, 146);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(94, 29);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el valor tope";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(408, 96);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(125, 27);
            this.txtValor.TabIndex = 4;
            // 
            // frmBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 526);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvGenerado);
            this.Controls.Add(this.dgvPrimario);
            this.Name = "frmBin";
            this.Text = "frmBin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvPrimario;
        private DataGridView dgvGenerado;
        private Button btnGenerar;
        private Label label1;
        private TextBox txtValor;
    }
}