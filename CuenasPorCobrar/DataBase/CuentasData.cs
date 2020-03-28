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
    }
}
