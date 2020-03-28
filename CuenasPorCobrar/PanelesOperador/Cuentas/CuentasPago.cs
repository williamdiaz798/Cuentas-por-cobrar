using CuenasPorCobrar.Properties;
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
    public partial class CuentasPago : Form
    {
        // TP = tipo pago
        private bool isCollapseTP;
        private int tipoPago;
        public CuentasPago()
        {
            InitializeComponent();
        }

        private void TimerTipoPago_Tick(object sender, EventArgs e)
        {
            if (isCollapseTP)
            {
                PanelFormaPago.Height -= 10;
                if (PanelFormaPago.Size == PanelFormaPago.MinimumSize)
                {
                    TimerTipoPago.Stop();
                    isCollapseTP = false;
                }
            }
            else
            {
                PanelFormaPago.Height += 10;
                if (PanelFormaPago.Size == PanelFormaPago.MaximumSize)
                {
                    TimerTipoPago.Stop();
                    isCollapseTP = true;
                }
            }
        }

        private void BtnFormaDePago_Click(object sender, EventArgs e)
        {
            TimerTipoPago.Start();
        }

        private void BtnContado_Click(object sender, EventArgs e)
        {
            tipoPago = 1;
            button4.Text = "Contado";
            TimerTipoPago.Start();
        }

        private void BtnCredito_Click(object sender, EventArgs e)
        {
            tipoPago = 2;
            button4.Text = "Credito";
            TimerTipoPago.Start();
        }

        private void BtnCheque_Click(object sender, EventArgs e)
        {
            tipoPago = 3;
            button4.Text = "Cheque";
            TimerTipoPago.Start();
        }

        private void BtnCuAgregarPago_Click(object sender, EventArgs e)
        {
            if (TxtCuCliente.Text == "")
            {
                MessageBox.Show("Ingrese el numero de cliente");
            }
            else if (TxtCuenta.Text == "")
            {
                MessageBox.Show("Ingrese el numero de cuenta");
            }
            else if (TxtCuTotalPago.Text == "")
            {
                MessageBox.Show("Ingrese el total a pagar");
            }
            else if (tipoPago == 0)
            {
                MessageBox.Show("Selecione el tipo de pago");
            }
            else
            {
                if (MessageBox.Show("Desea guardar el pago?", "Cerrar sin Guardar?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    
                    MessageBox.Show("Datos ingresados correctamente");
                }
            }
           
        }
    }
}
