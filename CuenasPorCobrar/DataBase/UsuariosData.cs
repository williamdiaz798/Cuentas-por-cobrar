using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuenasPorCobrar.DataBase
{
    class UsuariosData
    {
        conexionDB con = new conexionDB();

        public int Login(string usuario, string pass)
        {
            int tipo = 0; 
            

            SqlCommand cmd = new SqlCommand("exec UsuariosLogin @Usuario = '"+ usuario +"', @Pass = '"+ pass +"'", con.conecion());

            
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                tipo = int.Parse(reader["IdTipo"].ToString());
            }

            con.cerrar();
            return tipo;
        }
    }
}
