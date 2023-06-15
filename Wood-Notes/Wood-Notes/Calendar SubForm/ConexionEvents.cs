using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wood_Notes.Calendar_SubForm
{
    public class ConexionEvents
    {

        // Cadena de conexión que vincula a SQL Server
        static string conexionstring = "server= TUTIOELPOLLO-PC\\SQLSERVER; database= WoodNotesDB; integrated security= true";
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

        public void SaveEvents(string evento, DateTime fecha, int idUsers)
        {
            string cadena = "Insert into UserEvents([eventName],[eventDay],[idUsers]) values('" + evento + "','" + fecha + "','" + idUsers +"')";
            SqlCommand cmd =new SqlCommand(cadena, conexion);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Evento guardado con exito");
        }

    }
}
