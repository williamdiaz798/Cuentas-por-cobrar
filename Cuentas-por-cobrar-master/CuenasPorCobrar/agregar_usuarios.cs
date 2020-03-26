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
    public partial class agregar_usuarios : Form
    {
        public agregar_usuarios()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form inicio = new PanelSuperAdmin();

            inicio.Visible = true;

            Visible = false;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form usuarios = new Usuarios();

            usuarios.Visible = true;

            Visible = false;
        }

        private void tasaInteresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tasa = new Tasa_Interes();

            tasa.Visible = true;

            Visible = false;
        }

        private void beneficiosAClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form beneficio = new beneficios();

            beneficio.Visible = true;

            Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimisar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
