namespace ProyectoFinal
{
    partial class frmGrises
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
            this.gbxMain = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgdR = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdG = new System.Windows.Forms.DataGridView();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdB = new System.Windows.Forms.DataGridView();
            this.g = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdGris = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdGris)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMain
            // 
            this.gbxMain.Controls.Add(this.label1);
            this.gbxMain.Controls.Add(this.btnGenerar);
            this.gbxMain.Location = new System.Drawing.Point(208, 28);
            this.gbxMain.Name = "gbxMain";
            this.gbxMain.Size = new System.Drawing.Size(808, 125);
            this.gbxMain.TabIndex = 0;
            this.gbxMain.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese los valores a trabajar, o solo use los predeterminados";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(351, 86);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(136, 33);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgdR
            // 
            this.dgdR.AllowUserToAddRows = false;
            this.dgdR.AllowUserToDeleteRows = false;
            this.dgdR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.b,
            this.c});
            this.dgdR.Location = new System.Drawing.Point(85, 183);
            this.dgdR.Name = "dgdR";
            this.dgdR.RowHeadersWidth = 51;
            this.dgdR.RowTemplate.Height = 29;
            this.dgdR.Size = new System.Drawing.Size(348, 261);
            this.dgdR.TabIndex = 1;
            // 
            // a
            // 
            this.a.HeaderText = "a";
            this.a.MinimumWidth = 6;
            this.a.Name = "a";
            this.a.Width = 80;
            // 
            // b
            // 
            this.b.HeaderText = "b";
            this.b.MinimumWidth = 6;
            this.b.Name = "b";
            this.b.Width = 80;
            // 
            // c
            // 
            this.c.HeaderText = "c";
            this.c.MinimumWidth = 6;
            this.c.Name = "c";
            this.c.Width = 80;
            // 
            // dgdG
            // 
            this.dgdG.AllowUserToAddRows = false;
            this.dgdG.AllowUserToDeleteRows = false;
            this.dgdG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.d,
            this.e,
            this.f});
            this.dgdG.Location = new System.Drawing.Point(467, 183);
            this.dgdG.Name = "dgdG";
            this.dgdG.RowHeadersWidth = 51;
            this.dgdG.RowTemplate.Height = 29;
            this.dgdG.Size = new System.Drawing.Size(348, 261);
            this.dgdG.TabIndex = 2;
            // 
            // d
            // 
            this.d.HeaderText = "d";
            this.d.MinimumWidth = 6;
            this.d.Name = "d";
            this.d.Width = 80;
            // 
            // e
            // 
            this.e.HeaderText = "e";
            this.e.MinimumWidth = 6;
            this.e.Name = "e";
            this.e.Width = 80;
            // 
            // f
            // 
            this.f.HeaderText = "f";
            this.f.MinimumWidth = 6;
            this.f.Name = "f";
            this.f.Width = 80;
            // 
            // dgdB
            // 
            this.dgdB.AllowUserToAddRows = false;
            this.dgdB.AllowUserToDeleteRows = false;
            this.dgdB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.g,
            this.h,
            this.i});
            this.dgdB.Location = new System.Drawing.Point(847, 183);
            this.dgdB.Name = "dgdB";
            this.dgdB.RowHeadersWidth = 51;
            this.dgdB.RowTemplate.Height = 29;
            this.dgdB.Size = new System.Drawing.Size(348, 261);
            this.dgdB.TabIndex = 3;
            // 
            // g
            // 
            this.g.HeaderText = "g";
            this.g.MinimumWidth = 6;
            this.g.Name = "g";
            this.g.Width = 80;
            // 
            // h
            // 
            this.h.HeaderText = "h";
            this.h.MinimumWidth = 6;
            this.h.Name = "h";
            this.h.Width = 80;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.MinimumWidth = 6;
            this.i.Name = "i";
            this.i.Width = 80;
            // 
            // dgdGris
            // 
            this.dgdGris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdGris.Location = new System.Drawing.Point(259, 16);
            this.dgdGris.Name = "dgdGris";
            this.dgdGris.RowHeadersWidth = 51;
            this.dgdGris.RowTemplate.Height = 29;
            this.dgdGris.Size = new System.Drawing.Size(348, 261);
            this.dgdGris.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgdGris);
            this.groupBox2.Location = new System.Drawing.Point(208, 472);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 283);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Matriz generada:";
            // 
            // frmGrises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 780);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgdB);
            this.Controls.Add(this.dgdG);
            this.Controls.Add(this.dgdR);
            this.Controls.Add(this.gbxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGrises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escala de grises";
            this.gbxMain.ResumeLayout(false);
            this.gbxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdGris)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbxMain;
        private DataGridView dgdR;
        private DataGridView dgdG;
        private DataGridView dgdB;
        private Button btnGenerar;
        private DataGridView dgdGris;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn a;
        private DataGridViewTextBoxColumn b;
        private DataGridViewTextBoxColumn c;
        private DataGridViewTextBoxColumn d;
        private DataGridViewTextBoxColumn e;
        private DataGridViewTextBoxColumn f;
        private DataGridViewTextBoxColumn g;
        private DataGridViewTextBoxColumn h;
        private DataGridViewTextBoxColumn i;
    }
}