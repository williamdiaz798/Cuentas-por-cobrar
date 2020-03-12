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
                    this.Hide();
                    FormBienvenida bienvenida = new FormBienvenida();
                    bienvenida.ShowDialog();
                    panelAdmin.Show();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
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
