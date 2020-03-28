using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuenasPorCobrar.DataBase
{
    class ReportesData
    {
        conexionDB con = new conexionDB();

        public SqlDataAdapter Deudores()
        {
            SqlCommand cmd = new SqlCommand("exec CuentasVencidas", con.conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            con.cerrar();
        }
    }
}
