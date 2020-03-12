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
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }


        private void TimerAparecer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;

            CircubarBienve.Value += 1;
            CircubarBienve.Text = CircubarBienve.Value.ToString();
            if (CircubarBienve.Value == 100)
            {
                TimerAparecer.Stop();
                TimerDesaparecer.Start();
            }
        }

        private void TimerDesaparecer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                TimerDesaparecer.Stop();
                this.Close();
            }
        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            CircubarBienve.Value = 0;
            CircubarBienve.Minimum = 0;
            CircubarBienve.Maximum = 100;

            TimerAparecer.Start();
        }
    }
}
