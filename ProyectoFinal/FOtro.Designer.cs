﻿namespace ProyectoFinal
{
    partial class FOtro
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
            this.BoOtros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoOtros
            // 
            this.BoOtros.Location = new System.Drawing.Point(331, 151);
            this.BoOtros.Name = "BoOtros";
            this.BoOtros.Size = new System.Drawing.Size(123, 80);
            this.BoOtros.TabIndex = 0;
            this.BoOtros.Text = "Algoritmo Otros";
            this.BoOtros.UseVisualStyleBackColor = true;
            // 
            // FOtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoOtros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FOtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otro";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BoOtros;
    }
}