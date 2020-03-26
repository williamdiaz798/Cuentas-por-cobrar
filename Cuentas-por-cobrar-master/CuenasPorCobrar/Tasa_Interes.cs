using System;
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
    public partial class Tasa_Interes : Form
    {
        public Tasa_Interes()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form admin = new PanelSuperAdmin();
            
            admin.Visible = true;
            
            Visible = false;
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form super = new PanelSuperAdmin();

            super.Visible = true;

            Visible = false;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form usuarios = new Usuarios();

            usuarios.Visible = true;

            Visible = false;
        }

        private void beneficiosAClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form beneficios = new beneficios();

            beneficios.Visible = true;

            Visible = false;
        }

        private void Tasa_Interes_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }

        private void BtnMinimisar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
