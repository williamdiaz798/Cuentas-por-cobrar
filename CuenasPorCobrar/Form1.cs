using CuenasPorCobrar.Cache;
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
    public partial class Form1 : Form
    {
        PanelAdminSistema panelAdmin = new PanelAdminSistema();
        PanelSuperAdmin panelSAdmin = new PanelSuperAdmin();
        FormBienvenida bienvenida = new FormBienvenida();
        private int tipoUsuario = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese el Usuario");

            }
            else if (TxtContra.Text == "")
            {
                MessageBox.Show("Ingrese la contraseña");
            }
            else 
            {
                if (TxtUsuario.Text == "Will Diaz" && TxtContra.Text == "Asdf1234")
                {
                    tipoUsuario = 2;
                } else if (TxtUsuario.Text == "Emerson" && TxtContra.Text == "Asdf1234") 
                {
                    tipoUsuario = 1;
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }

                this.Hide();
                DatosUsuario.NombreUsuario = TxtUsuario.Text;
                bienvenida.ShowDialog();

                if (tipoUsuario == 2)
                {
                    panelAdmin.Show();
                }
                else if(tipoUsuario == 1)
                {
                    panelSAdmin.Show();
                }
            }
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
