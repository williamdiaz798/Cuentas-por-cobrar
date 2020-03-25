using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }
    }
}
