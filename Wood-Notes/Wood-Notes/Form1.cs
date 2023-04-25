using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Wood_Notes
{
    public partial class frmWorkStation : Form
    {
        Conexion conexion = new Conexion();
        Users objUsers = new Users();
        public frmWorkStation()
        {
            InitializeComponent();
        }

        private void ConseguirFoto(int id)
        {
            // Apertura de la conexión con la base de datos 
            string conexionstring = "server= TUTIOELPOLLO-DE\\SQLEXPRESS; database= WoodNotesDB; integrated security= true";
            SqlConnection conexion = new SqlConnection(conexionstring);

            // Apertura de la conexión y ejecución de la linea SQL para extraer imagen del usuario ( en el caso tenga )
            conexion.Open();
            //string sql = "select Users.foto from Users JOIN UserCredentials ON Users.idUsers = UserCredentials.idCredencial where nickname = '" + nick.ToString() + "'";
            string sql = "select Users.foto from Users JOIN UserCredentials ON Users.idUsers = UserCredentials.idCredencial where idCredencial = " + id + "";
            SqlCommand cmd = new SqlCommand(sql, conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            
            // Filtro para saber si se ha ingresado con Usuario o Invitado y para saber si el campo de SQLDataReader tiene campos
            if (reader.HasRows && id != 1)
            {
                // Filtro para saber si el usuario posee una imagen o por el contrario colocar una por default
                if (reader[0].ToString() != "")
                {
                    byte[] img = (byte[])(reader[0]);

                    // Conversión de byte a dato tipo imagen para colocar en el ProfilePictureBox
                    if (img != null)
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pbProfilePicture.Image = Image.FromStream(ms);
                    }
                }
                // Imagen por default para usuario sin imagen 
                else
                {
                    pbProfilePicture.Image = Wood_Notes.Properties.Resources.guatemala;
                    MessageBox.Show("No hay imagen");
                }
            }

            // Si es invitado colocara la imagen por defecto
            else
            {
                pbProfilePicture.Image = Wood_Notes.Properties.Resources.guatemala;
                MessageBox.Show("Invitado");
            }
            conexion.Close();
        }
        



        private void frmWorkStation_Load(object sender, EventArgs e)
        {

            btnInicio.Size = new System.Drawing.Size(180, 55);
            AbrirForm<frmInicio>();
            ConseguirFoto(int.Parse(lblId.Text));
            conexion.AbrirConexion();
        }
        #region Animación de Secciones
        private void SelectedButton(Button boton)
        {
            boton.BackColor = Color.RoyalBlue;
            boton.ForeColor = Color.White;
            boton.FlatAppearance.BorderColor = Color.RoyalBlue;
            boton.FlatAppearance.BorderSize = 3;
            boton.Size = new System.Drawing.Size(180, 55);
        } 

        private void DeselectedButton(Button boton)
        {
            boton.BackColor = Color.WhiteSmoke;
            boton.ForeColor = Color.Black;
            boton.FlatAppearance.BorderColor = Color.WhiteSmoke;
            boton.FlatAppearance.BorderSize = 3;
            boton.Size = new System.Drawing.Size(154, 45);
        }
        #endregion
        #region Botones de cierre
        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            conexion.CerrarConexion();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Formularios sobre Panel
        // Abrir formularios en el panel
        private void AbrirForm <MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario=panelContenido.Controls.OfType<MiForm>().FirstOrDefault(); // Busqueda del formulario
            // si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario=new MiForm();
                formulario.TopLevel=false;
                formulario.FormBorderStyle = FormBorderStyle.None; // Eliminar bordes
                formulario.Dock= DockStyle.Fill; // acoplar formulario al panel
                panelContenido.Controls.Add(formulario);
                panelContenido.Tag = formulario;
                formulario.Show();
                formulario.BringToFront(); 
            }
            // si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        #endregion

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirForm<frmInicio>();
            SelectedButton(btnInicio);
            DeselectedButton(btnCuenta);
            DeselectedButton(btnNotas);
            DeselectedButton(btnCalendario);
            DeselectedButton(btnConfig);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            AbrirForm<frmCuenta>();
            SelectedButton(btnCuenta);
            DeselectedButton(btnInicio);
            DeselectedButton(btnNotas);
            DeselectedButton(btnCalendario);
            DeselectedButton(btnConfig);

        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            AbrirForm<frmNotas>();
            SelectedButton(btnNotas);
            DeselectedButton(btnInicio);
            DeselectedButton(btnCuenta);
            DeselectedButton(btnCalendario);
            DeselectedButton(btnConfig);
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            AbrirForm<frmCalendario>();
            SelectedButton(btnCalendario);
            DeselectedButton(btnInicio);
            DeselectedButton(btnCuenta);
            DeselectedButton(btnNotas);
            DeselectedButton(btnConfig);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            AbrirForm<frmConfig>();
            SelectedButton(btnConfig);
            DeselectedButton(btnInicio);
            DeselectedButton(btnCuenta);
            DeselectedButton(btnNotas);
            DeselectedButton(btnCalendario);
        }
    }
}
