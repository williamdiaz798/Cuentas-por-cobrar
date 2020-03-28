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

namespace CuenasPorCobrar.PanelesOperador.Reportes
{
    public partial class ReporteDeudores : Form
    {
        ReportesData rdeudores;
        public ReporteDeudores()
        {
            InitializeComponent();
        }

        private void ReporteDeudores_Load(object sender, EventArgs e)
        {
            rdeudores = new ReportesData();
            SqlDataAdapter adap = rdeudores.Deudores();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            DGVCuVencenHoy.DataSource = dt;
            DGVCuVencenHoy.AutoResizeColumns();
            DGVCuVencenHoy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
