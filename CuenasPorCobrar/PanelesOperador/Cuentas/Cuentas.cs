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

namespace CuenasPorCobrar.PanelesOperador.Cuentas
{
    public partial class Cuentas : Form
    {
        CuentasData cuentas;

        public Cuentas()
        {
            InitializeComponent();
        }

        private void Cuentas_Load(object sender, EventArgs e)
        {
            cuentas = new CuentasData();
            SqlDataAdapter adap = cuentas.CuentasVencenHoy();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            DGVCuentas.DataSource = dt;
            DGVCuentas.AutoResizeColumns();
            DGVCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
