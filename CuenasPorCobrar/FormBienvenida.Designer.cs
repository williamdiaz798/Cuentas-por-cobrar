namespace CuenasPorCobrar
{
    partial class FormBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBienvenida));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblUsuarioN = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimerAparecer = new System.Windows.Forms.Timer(this.components);
            this.TimerDesaparecer = new System.Windows.Forms.Timer(this.components);
            this.CircubarBienve = new CircularProgressBar.CircularProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CuenasPorCobrar.Properties.Resources.money64;
            this.pictureBox2.Location = new System.Drawing.Point(24, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblTitulo.Location = new System.Drawing.Point(121, 31);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(252, 31);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Cuentas por Cobrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(587, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "BIENVENIDO";
            // 
            // LblUsuarioN
            // 
            this.LblUsuarioN.AutoSize = true;
            this.LblUsuarioN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LblUsuarioN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblUsuarioN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioN.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblUsuarioN.Location = new System.Drawing.Point(666, 205);
            this.LblUsuarioN.Name = "LblUsuarioN";
            this.LblUsuarioN.Size = new System.Drawing.Size(155, 33);
            this.LblUsuarioN.TabIndex = 4;
            this.LblUsuarioN.Text = "UserName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CuenasPorCobrar.Properties.Resources.cuentas_por_paga_750_500;
            this.pictureBox1.Image = global::CuenasPorCobrar.Properties.Resources.cuentas_por_paga_750_500;
            this.pictureBox1.Location = new System.Drawing.Point(0, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TimerAparecer
            // 
            this.TimerAparecer.Interval = 15;
            this.TimerAparecer.Tick += new System.EventHandler(this.TimerAparecer_Tick);
            // 
            // TimerDesaparecer
            // 
            this.TimerDesaparecer.Interval = 15;
            this.TimerDesaparecer.Tick += new System.EventHandler(this.TimerDesaparecer_Tick);
            // 
            // CircubarBienve
            // 
            this.CircubarBienve.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CircubarBienve.AnimationSpeed = 500;
            this.CircubarBienve.BackColor = System.Drawing.Color.Transparent;
            this.CircubarBienve.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold);
            this.CircubarBienve.ForeColor = System.Drawing.Color.White;
            this.CircubarBienve.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CircubarBienve.InnerMargin = 2;
            this.CircubarBienve.InnerWidth = -1;
            this.CircubarBienve.Location = new System.Drawing.Point(652, 369);
            this.CircubarBienve.MarqueeAnimationSpeed = 2000;
            this.CircubarBienve.Name = "CircubarBienve";
            this.CircubarBienve.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CircubarBienve.OuterMargin = -25;
            this.CircubarBienve.OuterWidth = 26;
            this.CircubarBienve.ProgressColor = System.Drawing.Color.CornflowerBlue;
            this.CircubarBienve.ProgressWidth = 25;
            this.CircubarBienve.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CircubarBienve.Size = new System.Drawing.Size(200, 200);
            this.CircubarBienve.StartAngle = 270;
            this.CircubarBienve.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.CircubarBienve.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircubarBienve.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CircubarBienve.SubscriptText = "";
            this.CircubarBienve.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircubarBienve.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CircubarBienve.SuperscriptText = "%";
            this.CircubarBienve.TabIndex = 5;
            this.CircubarBienve.Text = "0";
            this.CircubarBienve.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CircubarBienve.Value = 68;
            // 
            // FormBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.CircubarBienve);
            this.Controls.Add(this.LblUsuarioN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBienvenida";
            this.Load += new System.EventHandler(this.FormBienvenida_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblUsuarioN;
        private System.Windows.Forms.Timer TimerAparecer;
        private System.Windows.Forms.Timer TimerDesaparecer;
        private CircularProgressBar.CircularProgressBar CircubarBienve;
    }
}