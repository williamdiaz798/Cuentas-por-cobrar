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

namespace CuenasPorCobrar.PanelesOperador.Clientes
{
    public partial class ClientesAgregar : Form
    {
        ClientesData cliente;
        private int numCliente;
        public ClientesAgregar()
        {
            InitializeComponent();
        }

        private void BtnCAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del cliente");
            }
            else if (TxtCApellido.Text == "")
            {
                MessageBox.Show("Ingrese el apellido del cliente");
            }
            else if (TxtCDireccion.Text == "")
            {
                MessageBox.Show("Ingrese la direccion del cliente");
            }
            else if (TxtCTelefono.Text == "")
            {
                MessageBox.Show("Ingrese el telefono del cliente");
            }
            else if (TxtCCorreo.Text == "")
            {
                MessageBox.Show("Ingrese el correo del cliente");
            }
            else 
            {
                if (MessageBox.Show("Desea crear la cuenta?", "Cerrar sin Guardar?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    cliente = new ClientesData();

                    numCliente = cliente.ClientesUltimo() + 1;
                    //MessageBox.Show(numCliente + " " +TxtCNombre.Text + " " + TxtCApellido.Text + " " + TxtCDireccion.Text + " " + TxtCTelefono.Text + " " + TxtCCorreo.Text);
                    cliente.ClientesAgregar(numCliente, TxtCNombre.Text, TxtCApellido.Text, TxtCDireccion.Text, TxtCTelefono.Text, TxtCCorreo.Text);
                    MessageBox.Show("Datos ingresados correctamente");
                }
            }

        }

        private void ClientesAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
