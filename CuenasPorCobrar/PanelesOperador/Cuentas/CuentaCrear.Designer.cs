﻿namespace CuenasPorCobrar.PanelesOperador.Cuentas
{
    partial class CuentaCrear
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
            this.LblCuCrear = new System.Windows.Forms.Label();
            this.LblFechaEmision = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClndFechaEmision = new System.Windows.Forms.MonthCalendar();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.TxtCuMonto = new System.Windows.Forms.TextBox();
            this.TxtCuFiador = new System.Windows.Forms.TextBox();
            this.BtnCAgregar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // LblCuCrear
            // 
            this.LblCuCrear.AutoSize = true;
            this.LblCuCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCuCrear.Location = new System.Drawing.Point(480, 27);
            this.LblCuCrear.Name = "LblCuCrear";
            this.LblCuCrear.Size = new System.Drawing.Size(260, 39);
            this.LblCuCrear.TabIndex = 4;
            this.LblCuCrear.Text = "Agregar Cuenta";
            // 
            // LblFechaEmision
            // 
            this.LblFechaEmision.AutoSize = true;
            this.LblFechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaEmision.Location = new System.Drawing.Point(183, 92);
            this.LblFechaEmision.Name = "LblFechaEmision";
            this.LblFechaEmision.Size = new System.Drawing.Size(213, 29);
            this.LblFechaEmision.TabIndex = 5;
            this.LblFechaEmision.Text = "Fecha de Emision:";
            this.LblFechaEmision.Click += new System.EventHandler(this.LblFechaEmision_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fiador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Periodo:";
            // 
            // ClndFechaEmision
            // 
            this.ClndFechaEmision.Location = new System.Drawing.Point(405, 92);
            this.ClndFechaEmision.Name = "ClndFechaEmision";
            this.ClndFechaEmision.TabIndex = 9;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 297;
            this.lineShape1.X2 = 470;
            this.lineShape1.Y1 = 317;
            this.lineShape1.Y2 = 317;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1200, 570);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // TxtCuMonto
            // 
            this.TxtCuMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtCuMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCuMonto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtCuMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuMonto.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCuMonto.Location = new System.Drawing.Point(297, 284);
            this.TxtCuMonto.Name = "TxtCuMonto";
            this.TxtCuMonto.Size = new System.Drawing.Size(173, 28);
            this.TxtCuMonto.TabIndex = 12;
            this.TxtCuMonto.TextChanged += new System.EventHandler(this.TxtCNombre_TextChanged);
            // 
            // TxtCuFiador
            // 
            this.TxtCuFiador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TxtCuFiador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCuFiador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtCuFiador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuFiador.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCuFiador.Location = new System.Drawing.Point(293, 394);
            this.TxtCuFiador.Name = "TxtCuFiador";
            this.TxtCuFiador.Size = new System.Drawing.Size(180, 28);
            this.TxtCuFiador.TabIndex = 13;
            // 
            // BtnCAgregar
            // 
            this.BtnCAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnCAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCAgregar.FlatAppearance.BorderSize = 0;
            this.BtnCAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BtnCAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnCAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnCAgregar.Location = new System.Drawing.Point(191, 482);
            this.BtnCAgregar.Name = "BtnCAgregar";
            this.BtnCAgregar.Size = new System.Drawing.Size(150, 40);
            this.BtnCAgregar.TabIndex = 17;
            this.BtnCAgregar.Text = "Agregar";
            this.BtnCAgregar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(652, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 28);
            this.textBox1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cliente:";
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 297;
            this.lineShape2.X2 = 470;
            this.lineShape2.Y1 = 424;
            this.lineShape2.Y2 = 424;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.White;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 657;
            this.lineShape3.X2 = 830;
            this.lineShape3.Y1 = 320;
            this.lineShape3.Y2 = 320;
            // 
            // CuentaCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1200, 570);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCAgregar);
            this.Controls.Add(this.TxtCuFiador);
            this.Controls.Add(this.TxtCuMonto);
            this.Controls.Add(this.ClndFechaEmision);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblFechaEmision);
            this.Controls.Add(this.LblCuCrear);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CuentaCrear";
            this.Text = "CuentaCrear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCuCrear;
        private System.Windows.Forms.Label LblFechaEmision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar ClndFechaEmision;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox TxtCuMonto;
        private System.Windows.Forms.TextBox TxtCuFiador;
        private System.Windows.Forms.Button BtnCAgregar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
    }
}