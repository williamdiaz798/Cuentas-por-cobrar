using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuenasPorCobrar.PanelesAdministrador
{
    public partial class AgregarUsuarios : Form
    {
        private bool isCollapUT;
        public AgregarUsuarios()
        {
            InitializeComponent();
        }

        private void BtnUTipo_Click(object sender, EventArgs e)
        {
            TimerUTipo.Start();
        }

        private void TimerUTipo_Tick(object sender, EventArgs e)
        {
            if (isCollapUT)
            {
                PanelTipoU.Height -= 10;
                if (PanelTipoU.Size == PanelTipoU.MinimumSize)
                {
                    TimerUTipo.Stop();
                    isCollapUT = false;
                }
            }
            else
            {
                PanelTipoU.Height += 10;
                if (PanelTipoU.Size == PanelTipoU.MaximumSize)
                {
                    TimerUTipo.Stop();
                    isCollapUT = true;
                }
            }
        }
    }
}
