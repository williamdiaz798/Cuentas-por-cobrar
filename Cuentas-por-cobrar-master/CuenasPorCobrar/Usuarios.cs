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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void beneficiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form beneficios = new beneficios();

            beneficios.Visible = true;

            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form agregar = new agregar_usuarios();

            agregar.Visible = true;

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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Form agregar = new agregar_usuarios();

            agregar.Visible = true;

            Visible = false;
        }
    }
}
