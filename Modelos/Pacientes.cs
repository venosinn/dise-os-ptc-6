using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Modelos
{

        public class Pacientes
        {
            private int id_paciente;
            private string nombre_paciente;
            private string apellido_paciente;
            private DateTime fecha_nacimiento;
            private char sexo_paciente;
            private decimal peso_paciente;
            private decimal altura_paciente;
            private string alergias_paciente;
            private string responsable_paciente;

            public int Id_paciente { get => id_paciente; set => id_paciente = value; }
            public string Nombre_paciente { get => nombre_paciente; set => nombre_paciente = value; }
            public string Apellido_paciente { get => apellido_paciente; set => apellido_paciente = value; }
            public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
            public char Sexo_paciente { get => sexo_paciente; set => sexo_paciente = value; }
            public decimal Peso_paciente { get => peso_paciente; set => peso_paciente = value; }
            public decimal Altura_paciente { get => altura_paciente; set => altura_paciente = value; }
            public string Alergias_paciente { get => alergias_paciente; set => alergias_paciente = value; }
            public string Responsable_paciente { get => responsable_paciente; set => responsable_paciente = value; }

            public static DataTable CargarPacientes()
            {
                SqlConnection con = Conexion.Conectar();

                string comando = "select id_paciente as 'N°', nombre_paciente as 'Nombre', apellido_paciente as 'Apellido' , fecha_nacimiento as 'Fecha Nac.', sexo_paciente as 'Sexo'," +
                "tipo_sangre_paciente as 'Tipo de Sangre', peso_paciente as 'Peso', altura_paciente as 'Altura', alergias_paciente as 'Alergias', responsable_paciente 'Responsable' from Pacientes;";

                SqlDataAdapter ad = new SqlDataAdapter(comando, con);

                DataTable dt = new DataTable();

                ad.Fill(dt);
                return dt;
            }

    }

        
}

