using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace Modelos
{
    public class Usuarios
    {
        private int id_usuario;
        private string nombre_usuario;
        private string clave_usuario;
        private string correo_usuario;
        private int id_empleado;
        private int id_tipo_us;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string Clave_usuario { get => clave_usuario; set => clave_usuario = value; }
        public string Correo_usuario { get => correo_usuario; set => correo_usuario = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public int Id_tipo_us { get => id_tipo_us; set => id_tipo_us = value; }

        public DataTable Cargar()
        {
            return null;
        }

        public bool Insertar()
        {
            return false;
        }

        public bool Actualizar()
        {
            return false; 
        }

        public bool Eliminar()
        {
            return false;
        }

        public Usuarios IniciarSesion()
        {
            SqlConnection con = Conexion.Conectar();

            string comando = "select * from Usuarios where nombre_usuario = @nombre_usuario and clave_usuario = @clave_usuario;";

            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
            cmd.Parameters.AddWithValue("@clave_usuario", clave_usuario);

            //El Reader ejecuta el comando sql que creamos 

            SqlDataReader rd = cmd.ExecuteReader();

            //Verificacion si hay usuarios con la misma clave

            if (rd.Read())
            {
                Usuarios u = new Usuarios();

                u.Id_usuario = (int)rd[0];  
                u.Nombre_usuario = (string)rd[1];
                u.correo_usuario = (string)rd[3];
                u.id_empleado = (int)rd[4];  
                u.id_tipo_us = (int)rd[5];

                return u;
            }
            else
            {
                return null;
            }
        }
    }

    
}
