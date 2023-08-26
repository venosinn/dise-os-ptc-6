using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelos
{
    public class Conexion
    {
        private static string servidor = "VENOSINPC";
        private static string basedeDatos = "expo_3";

        public static SqlConnection Conectar()
        {
            string cadena =
                $"Data Source = {servidor}; " +
                $"Initial Catalog = {basedeDatos}; " +
                $"Integrated Security= true;";

            SqlConnection con = new SqlConnection(cadena);

            con.Open();

            return con;
        }

       
    }
}
