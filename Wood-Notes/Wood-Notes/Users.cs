using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wood_Notes
{
    public class Users:Conexion
    {
        // Apertura de conexion 
        static string conexionstring = "server= DESKTOP-DGI3QEQ\\SQLEXPRESS; database= WoodNotesDB; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        // Clase de guardado de datos de usuario y contraseña
        private int id { get; set; }
        private string usuario { get; set; }
        private string password { get; set; }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getUsuario()
        {
            return usuario;
        }
        public void setUsuario(string usuario)
        {
            usuario = usuario.Trim();
            this.usuario = usuario;
        }
        public string getPassword()
        {
            return password;
        }
        public void setPassword(string password)
        {
            password = password.Trim();
            this.password = password;
        }

        #region Verificacion de Usuarios
        public bool Verificador()
        {
            // Apertura de la conexion
            conexion.Open();
            bool result = false;

            //Lectura de cadena SQL donde con ayuda del SQLDataReader verifica si existe usuario
            string cadena = "select idCredencial from UserCredentials where nickname = '" + getUsuario() + "' and pPassword = '" + getPassword() + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader reader = null;
            reader = comando.ExecuteReader();

            // Usuario verificado == true
            if (reader.Read())
            {
                string credential = reader["idCredencial"].ToString();
                setId(int.Parse(credential));
                //setId(int.Parse(cadena));
                result = true;

            }
            // Usuario no encontrado == false
            else
            {
                result = false;

            }
            conexion.Close();
            return result;

        }
        #endregion
    }
}
