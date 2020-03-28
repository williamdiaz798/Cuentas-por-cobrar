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
    public partial class CuentasPVencer : Form
    {
        CuentasData cuentasPvencer;
        public CuentasPVencer()
        {
            InitializeComponent();
        }

        private void CuentasPVencer_Load(object sender, EventArgs e)
        {
            cuentasPvencer = new CuentasData();
            SqlDataAdapter adap = cuentasPvencer.CuentasPorVencer();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            DGVCuPorVencer.DataSource = dt;
            DGVCuPorVencer.AutoResizeColumns();
            DGVCuPorVencer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
