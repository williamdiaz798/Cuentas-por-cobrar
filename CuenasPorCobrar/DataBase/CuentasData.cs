using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CuenasPorCobrar.DataBase
{
    class CuentasData
    {
        conexionDB con = new conexionDB();
        private int ultimaCuenta;
        public SqlDataAdapter Cuentas()
        {
            SqlCommand cmd = new SqlCommand("exec Cuentas", con.conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            con.cerrar();
        }

        public SqlDataAdapter CuentasVencenHoy()
        {
            SqlCommand cmd = new SqlCommand("exec CuentasVenceHoy", con.conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            con.cerrar();   
        }

        public SqlDataAdapter CuentasPorVencer()
        {
            SqlCommand cmd = new SqlCommand("exec cuentasPorVencer", con.conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            con.cerrar();
        }

        public SqlDataAdapter CuentasVencidas()
        {
            SqlCommand cmd = new SqlCommand("exec CuentasVencidas", con.conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            con.cerrar();
        }

        public SqlDataAdapter CuentasAlCorriente()
        {
            SqlCommand cmd = new SqlCommand("exec CuentasAlCorriente", con.conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            con.cerrar();
        }

        public void CuentaAgregar(int IdCuenta, DateTime fechaEmision, string monto, string fiador, string cliente, DateTime fechaVencimiento, int Periodo)
        {
            SqlCommand cmd = new SqlCommand("exec AgregarCuenta @IdCuenta = "+ IdCuenta + ", @FechaEmision = N'" + fechaEmision + "', @Monto = "+ monto + ", @Fiador = '"+ fiador + "', @Cliente = "+ cliente + ", @FechaVencimiento = N'"+ fechaVencimiento + "', @IdPeriodo = "+ Periodo +"", con.conecion());
            SqlDataReader reader = cmd.ExecuteReader();
        }
        public int CuentaUltima()
        {
            SqlCommand cmd = new SqlCommand("exec UltimaCuenta", con.conecion());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                ultimaCuenta = int.Parse(reader["IdCuenta"].ToString());
            }
            con.cerrar();
            return ultimaCuenta;
        }

    }
}
