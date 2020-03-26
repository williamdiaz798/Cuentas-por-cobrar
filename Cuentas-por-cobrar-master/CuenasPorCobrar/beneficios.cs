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
    public partial class beneficios : Form
    {
        public beneficios()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form admin = new PanelSuperAdmin();

            admin.Visible = true;

            Visible = false;
        }

        private void tasaDeInteresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tasa = new Tasa_Interes();

            tasa.Visible = true;

            Visible = false;

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form usuarios = new Usuarios();

            usuarios.Visible = true;

            Visible = false;
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
