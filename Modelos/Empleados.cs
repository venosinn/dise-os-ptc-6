using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modelos
{
    public class Empleados
    {

        private int id_empleado;
        private string nombre_empleado;
        private string apellido_empleado;
        private string dui_empleado;
        private int id_especialidad;

        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Nombre_empleado { get => nombre_empleado; set => nombre_empleado = value; }
        public string Apellido_empleado { get => apellido_empleado; set => apellido_empleado = value; }
        public string Dui_empleado { get => dui_empleado; set => dui_empleado = value; }
        public int Id_especialidad { get => id_especialidad; set => id_especialidad = value; }

        public static DataTable CargarEmpleados()
        {
            SqlConnection con = Conexion.Conectar();

            string comando = " select id_empleado as 'N°', nombre_empleado as 'Nombre', apellido_empleado as 'Apellido', dui_empleado as 'Dui', id_especialidad 'Especialidad' from Empleados;";

            SqlDataAdapter ad = new SqlDataAdapter(comando, con);

            DataTable dt = new DataTable();

            ad.Fill(dt);

            return dt;
        }
    }
}
