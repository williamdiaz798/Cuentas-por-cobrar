using CuenasPorCobrar.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuenasPorCobrar.PanelesOperador.Cuentas
{
    public partial class CuentaCrear : Form
    {
        private bool isCollapseTiempos;
        private int año = 0;
        private int ultimaCuenta;
        private string fechaEmi, fechaVenci;
        private int year, mes, dia;
        CuentasData cuentas;
        public CuentaCrear()
        {
            InitializeComponent();
        }

        private void LblFechaEmision_Click(object sender, EventArgs e)
        {

        }

        private void TxtCNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPeriodos_Click(object sender, EventArgs e)
        {
            TimerPeriodos.Start();
        }

        private void TimerPeriodos_Tick(object sender, EventArgs e)
        {
            if (isCollapseTiempos)
            {
                PanelPeriodo.Height -= 10;
                if (PanelPeriodo.Size == PanelPeriodo.MinimumSize)
                {
                    TimerPeriodos.Stop();
                    isCollapseTiempos = false;
                }
            }
            else
            {
                PanelPeriodo.Height += 10;
                if (PanelPeriodo.Size == PanelPeriodo.MaximumSize)
                {
                    TimerPeriodos.Stop();
                    isCollapseTiempos = true;
                }
            }
        }

        private void Btn12meses_Click(object sender, EventArgs e)
        {
            BtnPeriodos.Text = "12 Meses";
            año = 1;
            TimerPeriodos.Start();
        }

        private void Btn24Meses_Click(object sender, EventArgs e)
        {
            BtnPeriodos.Text = "24 Meses";
            año = 2;
            TimerPeriodos.Start();
        }

        private void Btn48Meses_Click(object sender, EventArgs e)
        {
            BtnPeriodos.Text = "36 Meses";
            año = 3;
            TimerPeriodos.Start();
        }

        private void BtnCAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCuMonto.Text == "")
            {
                MessageBox.Show("Ingrese el monto");
            }
            else if (TxtCuFiador.Text == "")
            {
                MessageBox.Show("Ingrese el Fiador");
            }
            else if (TxtCuCliente.Text == "")
            {
                MessageBox.Show("Ingrese el Numero de cliente");
            }
            else if (año == 0)
            {
                MessageBox.Show("Seleccione el periodo");
            }
            else 
            {
                if (MessageBox.Show("Desea crear la cuenta?", "Cerrar sin Guardar?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    cuentas = new CuentasData();
                    ultimaCuenta = cuentas.CuentaUltima() + 1;

                    year = ClndFechaEmision.SelectionRange.Start.Year;
                    mes = ClndFechaEmision.SelectionRange.Start.Month;
                    dia = ClndFechaEmision.SelectionRange.Start.Day;

                    DateTime fechaEmi = Convert.ToDateTime(""+ year +"/"+ mes + "/" + dia +"");
                    DateTime fechaVenci = Convert.ToDateTime("" + (year + año) + "/" + mes + "/" + dia + "");

                    cuentas.CuentaAgregar(ultimaCuenta, fechaEmi, TxtCuMonto.Text, TxtCuFiador.Text, TxtCuCliente.Text, fechaVenci, año);
                    
                    MessageBox.Show("Datos guardados con exito");
                }
                
                
            }

            
        }
    }
}
