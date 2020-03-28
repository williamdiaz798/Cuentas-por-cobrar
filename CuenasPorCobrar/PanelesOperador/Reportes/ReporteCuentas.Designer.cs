namespace CuenasPorCobrar.PanelesOperador.Reportes
{
    partial class ReporteCuentas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDeuHasta = new System.Windows.Forms.TextBox();
            this.TxtDeuDesde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCuVencidas = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.PanelCuEstado = new System.Windows.Forms.Panel();
            this.BtnVencidas = new System.Windows.Forms.Button();
            this.BtnPVencer = new System.Windows.Forms.Button();
            this.BtnCuCorriente = new System.Windows.Forms.Button();
            this.BtnCuEstado = new System.Windows.Forms.Button();
            this.TimerCuEstado = new System.Windows.Forms.Timer(this.components);
            this.DGVCuentasRepo = new System.Windows.Forms.DataGridView();
            this.PanelCuEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCuentasRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(822, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Estado:";
            // 
            // TxtDeuHasta
            // 
            this.TxtDeuHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtDeuHasta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDeuHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtDeuHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDeuHasta.ForeColor = System.Drawing.Color.DimGray;
            this.TxtDeuHasta.Location = new System.Drawing.Point(171, 171);
            this.TxtDeuHasta.Name = "TxtDeuHasta";
            this.TxtDeuHasta.Size = new System.Drawing.Size(209, 28);
            this.TxtDeuHasta.TabIndex = 21;
            // 
            // TxtDeuDesde
            // 
            this.TxtDeuDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtDeuDesde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDeuDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtDeuDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDeuDesde.ForeColor = System.Drawing.Color.DimGray;
            this.TxtDeuDesde.Location = new System.Drawing.Point(171, 123);
            this.TxtDeuDesde.Name = "TxtDeuDesde";
            this.TxtDeuDesde.Size = new System.Drawing.Size(209, 28);
            this.TxtDeuDesde.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "De:";
            // 
            // LblCuVencidas
            // 
            this.LblCuVencidas.AutoSize = true;
            this.LblCuVencidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCuVencidas.Location = new System.Drawing.Point(518, 38);
            this.LblCuVencidas.Name = "LblCuVencidas";
            this.LblCuVencidas.Size = new System.Drawing.Size(146, 39);
            this.LblCuVencidas.TabIndex = 23;
            this.LblCuVencidas.Text = "Cuentas";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 171;
            this.lineShape1.X2 = 379;
            this.lineShape1.Y1 = 153;
            this.lineShape1.Y2 = 153;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 170;
            this.lineShape2.X2 = 378;
            this.lineShape2.Y1 = 201;
            this.lineShape2.Y2 = 201;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1200, 570);
            this.shapeContainer1.TabIndex = 24;
            this.shapeContainer1.TabStop = false;
            // 
            // PanelCuEstado
            // 
            this.PanelCuEstado.Controls.Add(this.BtnVencidas);
            this.PanelCuEstado.Controls.Add(this.BtnPVencer);
            this.PanelCuEstado.Controls.Add(this.BtnCuCorriente);
            this.PanelCuEstado.Controls.Add(this.BtnCuEstado);
            this.PanelCuEstado.Location = new System.Drawing.Point(922, 125);
            this.PanelCuEstado.MaximumSize = new System.Drawing.Size(120, 120);
            this.PanelCuEstado.MinimumSize = new System.Drawing.Size(120, 30);
            this.PanelCuEstado.Name = "PanelCuEstado";
            this.PanelCuEstado.Size = new System.Drawing.Size(120, 30);
            this.PanelCuEstado.TabIndex = 25;
            // 
            // BtnVencidas
            // 
            this.BtnVencidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnVencidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVencidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVencidas.FlatAppearance.BorderSize = 0;
            this.BtnVencidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnVencidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnVencidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVencidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVencidas.ForeColor = System.Drawing.Color.White;
            this.BtnVencidas.Location = new System.Drawing.Point(0, 90);
            this.BtnVencidas.Name = "BtnVencidas";
            this.BtnVencidas.Size = new System.Drawing.Size(120, 30);
            this.BtnVencidas.TabIndex = 35;
            this.BtnVencidas.Text = "Vencidas";
            this.BtnVencidas.UseVisualStyleBackColor = false;
            this.BtnVencidas.Click += new System.EventHandler(this.BtnVencidas_Click);
            // 
            // BtnPVencer
            // 
            this.BtnPVencer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnPVencer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPVencer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPVencer.FlatAppearance.BorderSize = 0;
            this.BtnPVencer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnPVencer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPVencer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPVencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPVencer.ForeColor = System.Drawing.Color.White;
            this.BtnPVencer.Location = new System.Drawing.Point(0, 60);
            this.BtnPVencer.Name = "BtnPVencer";
            this.BtnPVencer.Size = new System.Drawing.Size(120, 30);
            this.BtnPVencer.TabIndex = 34;
            this.BtnPVencer.Text = "Por Vencer";
            this.BtnPVencer.UseVisualStyleBackColor = false;
            this.BtnPVencer.Click += new System.EventHandler(this.BtnPVencer_Click);
            // 
            // BtnCuCorriente
            // 
            this.BtnCuCorriente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnCuCorriente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCuCorriente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCuCorriente.FlatAppearance.BorderSize = 0;
            this.BtnCuCorriente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnCuCorriente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnCuCorriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCuCorriente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuCorriente.ForeColor = System.Drawing.Color.White;
            this.BtnCuCorriente.Location = new System.Drawing.Point(0, 30);
            this.BtnCuCorriente.Name = "BtnCuCorriente";
            this.BtnCuCorriente.Size = new System.Drawing.Size(120, 30);
            this.BtnCuCorriente.TabIndex = 33;
            this.BtnCuCorriente.Text = "Al Corriente";
            this.BtnCuCorriente.UseVisualStyleBackColor = false;
            this.BtnCuCorriente.Click += new System.EventHandler(this.BtnCuCorriente_Click);
            // 
            // BtnCuEstado
            // 
            this.BtnCuEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnCuEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCuEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCuEstado.FlatAppearance.BorderSize = 0;
            this.BtnCuEstado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BtnCuEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnCuEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCuEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuEstado.ForeColor = System.Drawing.Color.White;
            this.BtnCuEstado.Location = new System.Drawing.Point(0, 0);
            this.BtnCuEstado.Name = "BtnCuEstado";
            this.BtnCuEstado.Size = new System.Drawing.Size(120, 30);
            this.BtnCuEstado.TabIndex = 32;
            this.BtnCuEstado.Text = "Todas";
            this.BtnCuEstado.UseVisualStyleBackColor = false;
            this.BtnCuEstado.Click += new System.EventHandler(this.BtnCuEstado_Click);
            // 
            // TimerCuEstado
            // 
            this.TimerCuEstado.Interval = 30;
            this.TimerCuEstado.Tick += new System.EventHandler(this.TimerCuEstado_Tick);
            // 
            // DGVCuentasRepo
            // 
            this.DGVCuentasRepo.AllowUserToAddRows = false;
            this.DGVCuentasRepo.AllowUserToDeleteRows = false;
            this.DGVCuentasRepo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DGVCuentasRepo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVCuentasRepo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVCuentasRepo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCuentasRepo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.DGVCuentasRepo.ColumnHeadersHeight = 30;
            this.DGVCuentasRepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCuentasRepo.DefaultCellStyle = dataGridViewCellStyle22;
            this.DGVCuentasRepo.Location = new System.Drawing.Point(171, 277);
            this.DGVCuentasRepo.Name = "DGVCuentasRepo";
            this.DGVCuentasRepo.ReadOnly = true;
            this.DGVCuentasRepo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCuentasRepo.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.DGVCuentasRepo.RowHeadersVisible = false;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCuentasRepo.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.DGVCuentasRepo.Size = new System.Drawing.Size(849, 246);
            this.DGVCuentasRepo.TabIndex = 27;
            // 
            // ReporteCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1200, 570);
            this.Controls.Add(this.DGVCuentasRepo);
            this.Controls.Add(this.PanelCuEstado);
            this.Controls.Add(this.LblCuVencidas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDeuHasta);
            this.Controls.Add(this.TxtDeuDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteCuentas";
            this.Text = "ReporteCuentas";
            this.Load += new System.EventHandler(this.ReporteCuentas_Load);
            this.PanelCuEstado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCuentasRepo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDeuHasta;
        private System.Windows.Forms.TextBox TxtDeuDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCuVencidas;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel PanelCuEstado;
        private System.Windows.Forms.Button BtnCuEstado;
        private System.Windows.Forms.Button BtnCuCorriente;
        private System.Windows.Forms.Button BtnVencidas;
        private System.Windows.Forms.Button BtnPVencer;
        private System.Windows.Forms.Timer TimerCuEstado;
        private System.Windows.Forms.DataGridView DGVCuentasRepo;
    }
}