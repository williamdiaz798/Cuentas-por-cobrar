using CuenasPorCobrar.PanelesAdministrador;
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

        private void button1_Click(object sender, EventArgs e)
        {
            llamarForm(new AgregarUsuarios());
            llamarForm(new Usuarios());
        }

        private void llamarForm(object formhijo)
        {

            if (this.PanelContenedorAdmin.Controls.Count > 0)
                this.PanelContenedorAdmin.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorAdmin.Controls.Add(fh);
            this.PanelContenedorAdmin.Tag = fh;
            fh.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            llamarForm(new TasaInteres());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            llamarForm(new Beneficios());
        }
    }
}
