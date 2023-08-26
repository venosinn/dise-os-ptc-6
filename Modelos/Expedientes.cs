using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Modelos
{
    public class Expedientes
    {
        private int id_expediente;
        private int id_paciente;
        private DateTime ultima_visita;
        

        public int Id_expediente { get => id_expediente; set => id_expediente = value; }
        public int Id_paciente { get => id_paciente; set => id_paciente = value; }
        public DateTime Ultima_visita { get => ultima_visita; set => ultima_visita = value; }

        public static DataTable CargarExpedientes()
        {
            SqlConnection con = Conexion.Conectar();

            string comando = " select id_expediente as 'N°', id_paciente as 'Paciente', ultima_visita as 'Ultima Visita' from Expedientes;";

            SqlDataAdapter ad = new SqlDataAdapter(comando, con);

            DataTable dt = new DataTable();

            ad.Fill(dt);

            return dt;
        }
    }
}
