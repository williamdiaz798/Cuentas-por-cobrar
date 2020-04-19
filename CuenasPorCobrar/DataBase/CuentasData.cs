using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CuenasPorCobrar.DataBase
{
    class CuentasData : conexionDB
    {
        //conexionDB con = new conexionDB();
        private int ultimaCuenta;
        public SqlDataAdapter Cuentas()
        {
            SqlCommand cmd = new SqlCommand("exec Cuentas", conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            cerrar();
        }

        public SqlDataAdapter CuentasVencenHoy()
        {
            SqlCommand cmd = new SqlCommand("exec CuentasVenceHoy", conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            cerrar();   
        }

        public SqlDataAdapter CuentasPorVencer()
        {
            SqlCommand cmd = new SqlCommand("exec cuentasPorVencer", conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            cerrar();
        }

        public SqlDataAdapter CuentasVencidas()
        {
            SqlCommand cmd = new SqlCommand("exec CuentasVencidas", conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            cerrar();
        }

        public SqlDataAdapter CuentasAlCorriente()
        {
            SqlCommand cmd = new SqlCommand("exec CuentasAlCorriente", conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            cerrar();
        }

        public void CuentaAgregar(int IdCuenta, DateTime fechaEmision, string monto, string fiador, string cliente, DateTime fechaVencimiento, int Periodo)
        {
            SqlCommand cmd = new SqlCommand("exec AgregarCuenta @IdCuenta = "+ IdCuenta + ", @FechaEmision = N'" + fechaEmision + "', @Monto = "+ monto + ", @Fiador = '"+ fiador + "', @Cliente = "+ cliente + ", @FechaVencimiento = N'"+ fechaVencimiento + "', @IdPeriodo = "+ Periodo +"", conecion());
            SqlDataReader reader = cmd.ExecuteReader();
        }
        public int CuentaUltima()
        {
            SqlCommand cmd = new SqlCommand("exec UltimaCuenta", conecion());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                ultimaCuenta = int.Parse(reader["IdCuenta"].ToString());
            }
            cerrar();
            return ultimaCuenta;
        }

    }
}
