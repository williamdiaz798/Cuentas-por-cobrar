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
    public partial class ReporteCuentas : Form
    {
        private bool isColladCuEstado;
        private int Estado;
        CuentasData cuentas;
        public ReporteCuentas()
        {
            InitializeComponent();
        }

        private void TimerCuEstado_Tick(object sender, EventArgs e)
        {
            if (isColladCuEstado)
            {
                PanelCuEstado.Height -= 10;
                if (PanelCuEstado.Size == PanelCuEstado.MinimumSize)
                {
                    TimerCuEstado.Stop();
                    isColladCuEstado = false;
                }
            }
            else
            {
                PanelCuEstado.Height += 10;
                if (PanelCuEstado.Size == PanelCuEstado.MaximumSize)
                {
                    TimerCuEstado.Stop();
                    isColladCuEstado = true;
                }
            }
        }

        private void BtnCuEstado_Click(object sender, EventArgs e)
        {
            TimerCuEstado.Start();
            Estado = 1;

            cuentas = new CuentasData();
            SqlDataAdapter adap = cuentas.Cuentas();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            DGVCuentasRepo.DataSource = dt;
            DGVCuentasRepo.AutoResizeColumns();
            DGVCuentasRepo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnCuCorriente_Click(object sender, EventArgs e)
        {
            cuentas = new CuentasData();
            SqlDataAdapter adap = cuentas.CuentasAlCorriente();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            DGVCuentasRepo.DataSource = dt;
            DGVCuentasRepo.AutoResizeColumns();
            DGVCuentasRepo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReporteCuentas_Load(object sender, EventArgs e)
        {
            cuentas = new CuentasData();
            SqlDataAdapter adap = cuentas.Cuentas();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            DGVCuentasRepo.DataSource = dt;
            DGVCuentasRepo.AutoResizeColumns();
            DGVCuentasRepo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnPVencer_Click(object sender, EventArgs e)
        {
            cuentas = new CuentasData();
            SqlDataAdapter adap = cuentas.CuentasPorVencer();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            DGVCuentasRepo.DataSource = dt;
            DGVCuentasRepo.AutoResizeColumns();
            DGVCuentasRepo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnVencidas_Click(object sender, EventArgs e)
        {
            cuentas = new CuentasData();
            SqlDataAdapter adap = cuentas.Cuentas();

            DataTable dt = new DataTable();
            adap.Fill(dt);
            DGVCuentasRepo.DataSource = dt;
            DGVCuentasRepo.AutoResizeColumns();
            DGVCuentasRepo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
