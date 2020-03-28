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
    public partial class ClientesCorriente : Form
    {
        ClientesData clientes;
        public ClientesCorriente()
        {
            InitializeComponent();
        }

        private void ClientesCorriente_Load(object sender, EventArgs e)
        {

            clientes = new ClientesData();
            SqlDataAdapter adap = clientes.ClientesAlCorriente();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            DGVCliAlCorriente.DataSource = dt;
            DGVCliAlCorriente.AutoResizeColumns();
            DGVCliAlCorriente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
