﻿namespace CuenasPorCobrar.PanelesOperador.Clientes
{
    partial class ClientesCorriente
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
            this.LblCCorriente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblCCorriente
            // 
            this.LblCCorriente.AutoSize = true;
            this.LblCCorriente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCCorriente.ForeColor = System.Drawing.Color.White;
            this.LblCCorriente.Location = new System.Drawing.Point(432, 52);
            this.LblCCorriente.Name = "LblCCorriente";
            this.LblCCorriente.Size = new System.Drawing.Size(324, 39);
            this.LblCCorriente.TabIndex = 1;
            this.LblCCorriente.Text = "Clientes al corriente";
            // 
            // ClientesCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1210, 570);
            this.Controls.Add(this.LblCCorriente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientesCorriente";
            this.Text = "ClientesCorriente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCCorriente;
    }
}