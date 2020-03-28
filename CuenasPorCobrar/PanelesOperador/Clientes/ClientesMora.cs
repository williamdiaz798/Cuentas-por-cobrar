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
    public partial class ClientesMora : Form
    {
        ClientesData clientes;
        public ClientesMora()
        {
            InitializeComponent();
        }

        private void ClientesMora_Load(object sender, EventArgs e)
        {
            clientes = new ClientesData();
            SqlDataAdapter adap = clientes.ClientesMora();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            DGVCliMora.DataSource = dt;
            DGVCliMora.AutoResizeColumns();
            DGVCliMora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
