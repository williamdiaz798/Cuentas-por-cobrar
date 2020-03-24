namespace CuenasPorCobrar
{
    partial class PanelSuperAdmin
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnMinimisar = new System.Windows.Forms.Button();
            this.PanelOperador = new System.Windows.Forms.Panel();
            this.PanelOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSalir.Image = global::CuenasPorCobrar.Properties.Resources.close16;
            this.BtnSalir.Location = new System.Drawing.Point(1165, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(35, 30);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnMinimisar
            // 
            this.BtnMinimisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnMinimisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimisar.FlatAppearance.BorderSize = 0;
            this.BtnMinimisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnMinimisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnMinimisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimisar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnMinimisar.Image = global::CuenasPorCobrar.Properties.Resources.less16;
            this.BtnMinimisar.Location = new System.Drawing.Point(1133, 0);
            this.BtnMinimisar.Name = "BtnMinimisar";
            this.BtnMinimisar.Size = new System.Drawing.Size(35, 30);
            this.BtnMinimisar.TabIndex = 14;
            this.BtnMinimisar.UseVisualStyleBackColor = false;
            this.BtnMinimisar.Click += new System.EventHandler(this.BtnMinimisar_Click);
            // 
            // PanelOperador
            // 
            this.PanelOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelOperador.Controls.Add(this.BtnMinimisar);
            this.PanelOperador.Location = new System.Drawing.Point(0, 0);
            this.PanelOperador.Name = "PanelOperador";
            this.PanelOperador.Size = new System.Drawing.Size(1200, 30);
            this.PanelOperador.TabIndex = 12;
            // 
            // PanelSuperAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.PanelOperador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelSuperAdmin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelSuperAdmin";
            this.Load += new System.EventHandler(this.PanelSuperAdmin_Load);
            this.PanelOperador.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnMinimisar;
        private System.Windows.Forms.Panel PanelOperador;
    }
}