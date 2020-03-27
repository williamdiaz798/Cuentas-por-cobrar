using CuenasPorCobrar.Cache;
using CuenasPorCobrar.DataBase;
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
        PanelAdminSistema panelAdmin;
        PanelSuperAdmin panelSAdmin;
        FormBienvenida bienvenida;
        UsuariosData login;
        private int tipoUsuario = 0;

        private string Usuario;
        private string Pass;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            login = new UsuariosData();

            Usuario = TxtUsuario.Text;
            Pass = TxtContra.Text;

            if (Usuario == "")
            {
                MessageBox.Show("Ingrese el Usuario");

            }
            else if (Pass == "")
            {
                MessageBox.Show("Ingrese la contraseña");
            }
            else 
            {

                tipoUsuario = login.Login(Usuario, Pass);

                if (tipoUsuario != 0)
                {
                    this.Hide();
                    bienvenida = new FormBienvenida();
                    DatosUsuario.NombreUsuario = TxtUsuario.Text;
                    bienvenida.ShowDialog();

                    if (tipoUsuario == 2)
                    {
                        panelAdmin = new PanelAdminSistema();
                        panelAdmin.Show();
                    }
                    else if (tipoUsuario == 1)
                    {
                        panelSAdmin = new PanelSuperAdmin();
                        panelSAdmin.Show();
                    }
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
