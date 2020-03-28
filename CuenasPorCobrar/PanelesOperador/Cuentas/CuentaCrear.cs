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
        private int meses = 0;

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
            meses = 12;
            TimerPeriodos.Start();
        }

        private void Btn24Meses_Click(object sender, EventArgs e)
        {
            BtnPeriodos.Text = "24 Meses";
            meses = 24;
            TimerPeriodos.Start();
        }

        private void Btn48Meses_Click(object sender, EventArgs e)
        {
            BtnPeriodos.Text = "48 Meses";
            meses = 48;
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
            else if (meses == 0)
            {
                MessageBox.Show("Seleccione el periodo");
            }
            else 
            {
                if (MessageBox.Show("Desea crear la cuenta?", "Cerrar sin Guardar?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    
                }
                
                
            }

            
        }
    }
}
