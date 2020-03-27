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

        public SqlDataAdapter CuentasVencenHoy()
        {
            int tipo = 0;
            SqlCommand cmd = new SqlCommand("exec CuentasVenceHoy", con.conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            con.cerrar();   
        }
    }
}
