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
    public partial class CuentasVencidas : Form
    {
        CuentasData cuentasVencidas;
        public CuentasVencidas()
        {
            InitializeComponent();
        }

        private void CuentasVencidas_Load(object sender, EventArgs e)
        {
            cuentasVencidas = new CuentasData();
            SqlDataAdapter adap = cuentasVencidas.CuentasVencidas();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            DGVCuVencidas.DataSource = dt;
            DGVCuVencidas.AutoResizeColumns();
            DGVCuVencidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
