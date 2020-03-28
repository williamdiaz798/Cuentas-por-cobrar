using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuenasPorCobrar.DataBase
{
    class ClientesData
    {
        conexionDB con = new conexionDB();
        private int ultimoCliente;
        public SqlDataAdapter ClientesAlCorriente()
        {
            SqlCommand cmd = new SqlCommand("exec ClientesAlCorriente", con.conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            con.cerrar();
        }
        public SqlDataAdapter Clientes()
        {
            SqlCommand cmd = new SqlCommand("exec Clientes", con.conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            con.cerrar();
        }
        
        public SqlDataAdapter ClientesMora()
        {
            SqlCommand cmd = new SqlCommand("exec ClientesMora", con.conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            con.cerrar();
        }
        public int ClientesUltimo()
        {
            SqlCommand cmd = new SqlCommand("exec UltimoCliente", con.conecion());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                ultimoCliente = int.Parse(reader["Id_Cliente"].ToString());
            }
            con.cerrar();
            return ultimoCliente;
        }
        public void ClientesAgregar(int IdCliente, string nombre, string apellido, string dirreccion, string telefono, string correo)
        {
            SqlCommand cmd = new SqlCommand("exec AgregarCliente @IdCliente = '"+ IdCliente + "', @Nombre = '"+ nombre +"', @Apellido = '"+ apellido +"', @Dirrecion = '"+ dirreccion +"', @Telefono = '"+ telefono +"', @Correo = '"+ correo +"'", con.conecion());
            SqlDataReader reader = cmd.ExecuteReader();
        }
    }
}
