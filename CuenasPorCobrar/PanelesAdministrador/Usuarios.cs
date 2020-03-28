using CuenasPorCobrar.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuenasPorCobrar.PanelesAdministrador
{
    public partial class Usuarios : Form
    {
        //PanelSuperAdmin panelSuper = new PanelSuperAdmin();

        AgregarUsuarios Agregar = new AgregarUsuarios();

        UsuariosData usuarios;

        public Usuarios()
        {
            InitializeComponent();
        }


        private void Usuarios_Load(object sender, EventArgs e)
        {
            
        }

 

        private void llamarForm(object formhijo)
        {

            if (this.PanelContenedorUser.Controls.Count > 0)
                this.PanelContenedorUser.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorUser.Controls.Add(fh);
            this.PanelContenedorUser.Tag = fh;
            fh.Show();

        }

        
        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            label1.Hide();
            DGVUsuarios.Hide();
            BtnAgregar.Hide();
            llamarForm(new AgregarUsuarios());
        }

        private void PanelContenedorUser_Paint(object sender, PaintEventArgs e)
        {
            usuarios = new UsuariosData();
            SqlDataAdapter adap = usuarios.Usuarios();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            DGVUsuarios.DataSource = dt;
            DGVUsuarios.AutoResizeColumns();
            DGVUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
