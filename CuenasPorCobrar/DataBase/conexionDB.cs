using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CuenasPorCobrar.DataBase
{
    class conexionDB
    {
        //public string cadena = "Data Source = DESKTOP-MU1NNVV\SQLEXPRESS; Initial Catalog = CuentasPCobrar; Integrated Security = true";
        public SqlConnection conec = new SqlConnection("server = DESKTOP-MU1NNVV\\SQLEXPRESS; database = CuentasPCobrar; integrated Security = true");

        public conexionDB() 
        {
            //conec.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {  
                Console.WriteLine("Conexion establecida");
                conec.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }

        public SqlConnection conecion()
        {
            conec.Open();
            return conec;
        }


        public void cerrar()
        {
            conec.Close();
        }
    }
}
