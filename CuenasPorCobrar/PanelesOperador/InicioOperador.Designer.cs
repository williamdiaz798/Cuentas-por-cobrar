﻿namespace CuenasPorCobrar.PanelesOperador
{
    partial class InicioOperador
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
            this.LblCVenHoy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblCVenHoy
            // 
            this.LblCVenHoy.AutoSize = true;
            this.LblCVenHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCVenHoy.Location = new System.Drawing.Point(343, 52);
            this.LblCVenHoy.Name = "LblCVenHoy";
            this.LblCVenHoy.Size = new System.Drawing.Size(536, 39);
            this.LblCVenHoy.TabIndex = 0;
            this.LblCVenHoy.Text = "Cuentas que vencen el dia de hoy";
            // 
            // InicioOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1210, 570);
            this.Controls.Add(this.LblCVenHoy);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioOperador";
            this.Text = "InicioOperador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCVenHoy;
    }
}