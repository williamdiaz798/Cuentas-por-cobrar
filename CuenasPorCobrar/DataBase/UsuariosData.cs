using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuenasPorCobrar.DataBase
{
    class UsuariosData : conexionDB
    {
        //conexionDB con = new conexionDB();

        public int Login(string usuario, string pass)
        {
            int tipo = 0; 
            

            SqlCommand cmd = new SqlCommand("exec UsuariosLogin @Usuario = '"+ usuario +"', @Pass = '"+ pass +"'", conecion());

            
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                tipo = int.Parse(reader["IdTipo"].ToString());
            }

            cerrar();
            return tipo;
        }

        public SqlDataAdapter Usuarios()
        {
            SqlCommand cmd = new SqlCommand("exec Usuarios", conecion());
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            return Adapter;
            cerrar();
        }
    }
}
