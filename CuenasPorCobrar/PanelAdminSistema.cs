using CuenasPorCobrar.PanelesOperador;
using CuenasPorCobrar.PanelesOperador.Clientes;
using CuenasPorCobrar.PanelesOperador.Cuentas;
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
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimisar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PanelAdminSistema_Load(object sender, EventArgs e)
        {
            AbrirFormInicio(new InicioOperador());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            TimerHistorial.Start();
        }

        private void BtnIndex_Click(object sender, EventArgs e)
        {
            AbrirFormInicio(new InicioOperador());
        }

        private void TimerHistorial_Tick(object sender, EventArgs e)
        {
            if (isCollapseH)
            {
                BtnReporte.Image = Resources.ArrowDown16;
                PanelReportes.Height -= 10;
                if (PanelReportes.Size == PanelReportes.MinimumSize)
                {
                    TimerHistorial.Stop();
                    isCollapseH = false;
                }
            }
            else
            {
                BtnReporte.Image = Resources.ArrowUp16;
                PanelReportes.Height += 10;
                if (PanelReportes.Size == PanelReportes.MaximumSize)
                {
                    TimerHistorial.Stop();
                    isCollapseH = true;
                }
            }
        }

        private void BtnCACorriente_Click(object sender, EventArgs e)
        {
            AbrirFormInicio(new ClientesCorriente());
        }

        private void BtnCMora_Click(object sender, EventArgs e)
        {
            AbrirFormInicio(new ClientesMora());
        }

        private void BtnCTodos_Click(object sender, EventArgs e)
        {
            AbrirFormInicio(new Clientes());
        }

        private void BtnCCrear_Click(object sender, EventArgs e)
        {
            AbrirFormInicio(new ClientesAgregar());
        }

        private void BtnCuVence_Click(object sender, EventArgs e)
        {
            AbrirFormInicio(new CuentasPVencer());
        }

        private void BtnCuVencidas_Click(object sender, EventArgs e)
        {
            AbrirFormInicio(new CuentasVencidas());
        }

        private void BtnCuCrear_Click(object sender, EventArgs e)
        {
            AbrirFormInicio(new CuentaCrear());
        }

        private void BtnCuPago_Click(object sender, EventArgs e)
        {
            AbrirFormInicio(new CuentasPago());
        }

        private void BtnCuentasT_Click(object sender, EventArgs e)
        {
            AbrirFormInicio(new Cuentas());
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

        //--------------------------------------------------------------------------------------------------------------
        //Abrir paneles

        private void AbrirFormInicio(object formInicio)
        {
            //TimerHistorial.Start();
            //TimerCPV.Start();
            //TimerClien.Start();

            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form FInicio = formInicio as Form;
            FInicio.TopLevel = false;
            FInicio.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(FInicio);
            this.PanelContenedor.Tag = FInicio;
            FInicio.Show();
        }

        //private void AbrirFormClienteACorriente(object formClienteCorriente)
        //{
        //    if (this.PanelContenedor.Controls.Count > 0)
        //        this.PanelContenedor.Controls.RemoveAt(0);

        //    Form FInicio = formClien as Form;
        //    FInicio.TopLevel = false;
        //    FInicio.Dock = DockStyle.Fill;
        //    this.PanelContenedor.Controls.Add(FInicio);
        //    this.PanelContenedor.Tag = FInicio;
        //    FInicio.Show();
        //}
    }

}
