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

namespace CuenasPorCobrar.PanelesOperador.Clientes
{
    public partial class Clientes : Form
    {
        ClientesData cuentas;
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e) 
        {
            cuentas = new ClientesData();
            SqlDataAdapter adap = cuentas.Clientes();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            DGVClientes.DataSource = dt;
            DGVClientes.AutoResizeColumns();
            DGVClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
