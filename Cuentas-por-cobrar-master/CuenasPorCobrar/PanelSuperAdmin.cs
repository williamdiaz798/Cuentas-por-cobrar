﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuenasPorCobrar
{
    public partial class PanelSuperAdmin : Form
    {
        public PanelSuperAdmin()
        {
            InitializeComponent();
        }

        private void PanelSuperAdmin_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimisar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PanelOperador_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form tasa = new Tasa_Interes();
            
            tasa.Visible = true;
            
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form beneficios = new beneficios();

            beneficios.Visible = true;

            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form usuarios = new Usuarios();

            usuarios.Visible = true;

            Visible = false;
        }
    }
}