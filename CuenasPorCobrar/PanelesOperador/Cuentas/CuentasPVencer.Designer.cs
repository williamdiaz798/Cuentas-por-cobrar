namespace CuenasPorCobrar.PanelesOperador.Cuentas
{
    partial class CuentasPVencer
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
            this.LblCuPVencer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblCuPVencer
            // 
            this.LblCuPVencer.AutoSize = true;
            this.LblCuPVencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCuPVencer.Location = new System.Drawing.Point(447, 51);
            this.LblCuPVencer.Name = "LblCuPVencer";
            this.LblCuPVencer.Size = new System.Drawing.Size(319, 39);
            this.LblCuPVencer.TabIndex = 1;
            this.LblCuPVencer.Text = "Cuentas por vencer";
            // 
            // CuentasPVencer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1200, 570);
            this.Controls.Add(this.LblCuPVencer);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CuentasPVencer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuentasPVencer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCuPVencer;
    }
}