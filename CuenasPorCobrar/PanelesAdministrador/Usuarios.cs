using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            dataGridView1.Hide();
            BtnAgregar.Hide();
            llamarForm(new AgregarUsuarios());
        }
    }
}
