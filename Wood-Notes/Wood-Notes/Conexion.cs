using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Wood_Notes
{
    public class Conexion
    {
        static string conexionstring = "server= TUTIOELPOLLO-DE\\SQLEXPRESS; database= WoodNotesDB; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        #region Apertura y cierre de conexion
        public void AbrirConexion()
        {
            conexion.Open();
            //MessageBox.Show("se conecto con " + conexion.Database);
        }
        public void CerrarConexion()
        {
            conexion.Close();
        }
        #endregion

        #region Consultas a SQL
        // Insercion de Notas desde el formulario a SQL Server
        public void InsertarNotas(string Titulo, string Nota, string Fecha, int Caracteres)
        {
            string cadena = "insert into UserNotes([Titulo],[Contenido],[Fecha],[Modificacion],[Caracteres]) values ('" + Titulo + "','" + Nota + "','" + Fecha + "','" + Fecha + "','" + Caracteres + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
        }
        // Peticion de eliminacion de dato hacia SQL Server
        public void EliminarDato(int Id)
        {
            string cadena = "delete from UserNotes where IdNota =" + Id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
        }
        // Peticion de modificacion de dato hacia SQL Server
        public void ModificarDato(int Id, string Titulo, string Nota, string Fecha, int Caracteres)
        {
            string cadena = "update UserNotes set Titulo='" + Titulo + "',Contenido='" + Nota + "',Modificacion='" + Fecha + "',Caracteres='" + Caracteres +"'  where IdNota =" + Id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
        }
        // Consulta de notas de SQL para cargar en el DataGridView
        public DataTable ConsultaNotas()
        {
            string query = "Select * from UserNotes";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter dataInfo = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            dataInfo.Fill(tabla);
            return tabla;
        }
        // Busqueda de notas por medio de el titulo
        public DataTable BusquedaNotas(string Titulo)
        {
            string query = "Select * from UserNotes where Titulo = '" + Titulo + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter dataInfo = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            dataInfo.Fill(tabla);
            return tabla;
        }

        #endregion
    }
}
