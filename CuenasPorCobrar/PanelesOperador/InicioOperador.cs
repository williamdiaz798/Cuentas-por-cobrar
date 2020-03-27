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

namespace CuenasPorCobrar.PanelesOperador
{
    public partial class InicioOperador : Form
    {
        CuentasData cuentas;

        public InicioOperador()
        {
            InitializeComponent();
        }

        private void InicioOperador_Load(object sender, EventArgs e)
        {
            cuentas = new CuentasData();
            SqlDataAdapter adap = cuentas.CuentasVencenHoy();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            DGVCuVencenHoy.DataSource = dt;
            DGVCuVencenHoy.AutoResizeColumns();
            DGVCuVencenHoy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
