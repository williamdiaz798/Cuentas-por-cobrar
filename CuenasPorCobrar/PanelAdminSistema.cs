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

namespace CuenasPorCobrar
{
    public partial class PanelAdminSistema : Form
    {
        // C = cliente, CPV = Cuentas Por Vencer
        private bool isCollapseC, isCollapseCPV, isCollapseH;
        public PanelAdminSistema()
        {
            InitializeComponent();
        }

        public Image Resource { get; private set; }


        private void TimerClien_Tick(object sender, EventArgs e)
        {
            if (isCollapseC)
            {
                BtnClien.Image = Resources.ArrowDown16;
                PanelClien.Height -= 10;
                if (PanelClien.Size == PanelClien.MinimumSize)
                {
                    TimerClien.Stop();
                    isCollapseC = false;
                }
            }
            else 
            {
                BtnClien.Image = Resources.ArrowUp16;
                PanelClien.Height += 10;
                if (PanelClien.Size == PanelClien.MaximumSize)
                {
                    TimerClien.Stop();
                    isCollapseC = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimerClien.Start();
        }

        private void BtnCPV_Click(object sender, EventArgs e)
        {
            TimerCPV.Start();
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            TimerHistorial.Start();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimerHistorial_Tick(object sender, EventArgs e)
        {
            if (isCollapseH)
            {
                BtnHistorial.Image = Resources.ArrowDown16;
                PanelHClien.Height -= 10;
                if (PanelHClien.Size == PanelHClien.MinimumSize)
                {
                    TimerHistorial.Stop();
                    isCollapseH = false;
                }
            }
            else
            {
                BtnHistorial.Image = Resources.ArrowUp16;
                PanelHClien.Height += 10;
                if (PanelHClien.Size == PanelHClien.MaximumSize)
                {
                    TimerHistorial.Stop();
                    isCollapseH = true;
                }
            }
        }

        private void TimerCPV_Tick(object sender, EventArgs e)
        {
            if (isCollapseCPV)
            {
                BtnCPV.Image = Resources.ArrowDown16;
                PanelCPV.Height -= 10;
                if (PanelCPV.Size == PanelCPV.MinimumSize)
                {
                    TimerCPV.Stop();
                    isCollapseCPV = false;
                }
            }
            else
            {
                BtnCPV.Image = Resources.ArrowUp16;
                PanelCPV.Height += 10;
                if (PanelCPV.Size == PanelCPV.MaximumSize)
                {
                    TimerCPV.Stop();
                    isCollapseCPV = true;
                }
            }
        }
    }
}
