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
        public CuentasPago()
        {
            InitializeComponent();
        }

        private void TimerTipoPago_Tick(object sender, EventArgs e)
        {
            if (isCollapseTP)
            {
                BtnFormaDePago.Image = Resources.ArrowDown16;
                PanelFormaPago.Height -= 10;
                if (PanelFormaPago.Size == PanelFormaPago.MinimumSize)
                {
                    TimerTipoPago.Stop();
                    isCollapseTP = false;
                }
            }
            else
            {
                BtnFormaDePago.Image = Resources.ArrowUp16;
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
    }
}
