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
        public frmWorkStation()
        {
            InitializeComponent();
        }

        Point ppbInicio;
        Point ppbCuenta;
        Point ppbNotas;
        Point ppbCalendario;
        Point ppbConfig;

        private void frmWorkStation_Load(object sender, EventArgs e)
        {
            // Asignación de diseño del boton y apertura del Menu de Inicio al entrar al sistema
            btnInicio.Size = new System.Drawing.Size(180, 60);

            // Funcion de llamado de SubForms al Form principal por medio de ventanas acopladas (Formularios sobre Panel)
            AbrirForm<frmInicio>();

            // Apertura de Conexion y petición de la imagen por medio del Id con el que ingreso al sistema (Peticion de Imagen a la base de Datos)
            conexion.AbrirConexion();
            ConseguirFoto(int.Parse(lblId.Text));

            // Diseño de boton por defecto (Animación de Secciones)
            SelectedButton(btnInicio, pbMenuIcon);

            ppbInicio = pbMenuIcon.Location;
            ppbCuenta = pbUserIcon.Location;
            ppbNotas = pbNotesIcon.Location;
            ppbCalendario = pbCalendarIcon.Location;
            ppbConfig = pbConfigIcon.Location;

            pbMenuIcon.Location = new Point(47, 111);

        }

        #region Formularios sobre Panel
        // Abrir formularios en el panel
        private void AbrirForm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenido.Controls.OfType<MiForm>().FirstOrDefault(); // Busqueda del formulario
            // si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None; // Eliminar bordes
                formulario.Dock = DockStyle.Fill; // acoplar formulario al panel
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

        #region Petición de Imagen a la Base de Datos
        private void ConseguirFoto(int id)
        {
            // Apertura de la conexión con la base de datos 
            string conexionstring = "server= TUTIOELPOLLO-PC\\SQLSERVER; database= WoodNotesDB; integrated security= true";
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
                    pbProfilePicture.Image = Wood_Notes.Properties.Resources.NoImage;
                    MessageBox.Show("No hay imagen");
                }
            }

            // Si es invitado colocara la imagen por defecto
            else
            {
                pbProfilePicture.Image = Wood_Notes.Properties.Resources.Invitado;
                MessageBox.Show("Invitado");
            }
            conexion.Close();
        }
        #endregion

        #region Animación de Secciones

        // Animacion de botones y colores segun el seleccionado

        private void SelectedButton(Button boton, PictureBox pictureBox)
        {
            Color colorSelect = Color.FromArgb(43, 91, 232);
            Size sizeSelect = new Size(180, 60);

            // Propiedades de diseño del boton (al seleccionar)
            boton.BackColor = colorSelect;
            boton.ForeColor = Color.White;
            boton.Size = sizeSelect;
            // Propiedades extra del diseño 
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.MouseOverBackColor = colorSelect;
            //Propiedades del icono
            pictureBox.BackColor = colorSelect;

        } 

        private void DeselectedButton(Button boton, PictureBox pictureBox)
        {
            Color colorDeselect = Color.FromArgb(13, 60, 182);
            Color colorHover = Color.FromArgb(25, 74, 216);
            Size sizeDeselect = new Size(180, 51);

            // Propiedades de diseño del boton (al deseleccionar)
            boton.BackColor = colorDeselect;
            boton.ForeColor = Color.White;
            boton.Size = sizeDeselect;
            // Propiedades extra del diseño
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.MouseOverBackColor = colorHover;
            // Propiedades del icono
            pictureBox.BackColor= colorDeselect;

        }

        // Propiedades para los Icons pertenecientes a los botones (eventos MouseEnter y MouseLeave)

        private void mouseEnter(PictureBox pictureBox, bool SelectedOption)
        {
            if (!SelectedOption)
            {
                Color colorHover = Color.FromArgb(25, 74, 216);
                pictureBox.BackColor = colorHover;
            }
        }
        private void mouseLeave(PictureBox pictureBox, bool SelectedOption)
        {
            if (!SelectedOption)
            {
                Color colorLeave = Color.FromArgb(13, 60, 182);
                pictureBox.BackColor = colorLeave;
            }
        }
        // btnMenu
        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter(pbMenuIcon, selectedMenu);
        }
        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(pbMenuIcon, selectedMenu);
        }
        //btnCuenta
        private void btnCuenta_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter(pbUserIcon, selectedUser);
        }
        private void btnCuenta_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(pbUserIcon, selectedUser);
        }
        //btnNotas
        private void btnNotas_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter(pbNotesIcon, selectedNotes);
        }
        private void btnNotas_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(pbNotesIcon, selectedNotes);
        }
        //btnCalendario
        private void btnCalendario_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter(pbCalendarIcon, selectedCalendar);
        }
        private void btnCalendario_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(pbCalendarIcon, selectedCalendar);
        }
        //btnConfig
        private void btnConfig_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter(pbConfigIcon, selectedConfig);
        }
        private void btnConfig_MouseLeave(object sender, EventArgs e)
        {
            
            mouseLeave(pbConfigIcon, selectedConfig);
            
        }
        #endregion

        #region Seleccion y multifunción de los botones

        bool selectedMenu = true; // Activado por defecto ya que al cargar el Form principal este viene como pantalla de inicio (despues modificable)
        bool selectedUser = false;
        bool selectedNotes = false;
        bool selectedCalendar = false;
        bool selectedConfig = false;


        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirForm<frmInicio>();

            // Diseño de los botones
            SelectedButton(btnInicio, pbMenuIcon);
            DeselectedButton(btnCuenta, pbUserIcon);
            DeselectedButton(btnNotas, pbNotesIcon);
            DeselectedButton(btnCalendario, pbCalendarIcon);
            DeselectedButton(btnConfig, pbConfigIcon);

            // Diseño del Icon de los botones
            selectedMenu = true;
            selectedUser = false;
            selectedNotes = false;
            selectedCalendar = false;
            selectedConfig = false;

            // Posicion de los botones
            pbMenuIcon.Location = new Point(47, 110);
            pbUserIcon.Location = ppbCuenta;
            pbNotesIcon.Location = ppbNotas;
            pbCalendarIcon.Location = ppbCalendario;
            pbConfigIcon.Location = ppbConfig;

        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            AbrirForm<frmCuenta>();

            // Diseño de los botones
            SelectedButton(btnCuenta, pbUserIcon);
            DeselectedButton(btnInicio, pbMenuIcon);
            DeselectedButton(btnNotas, pbNotesIcon);
            DeselectedButton(btnCalendario, pbCalendarIcon);
            DeselectedButton(btnConfig, pbConfigIcon);

            // Diseño del Icon de los botones
            selectedMenu = false;
            selectedUser = true;
            selectedNotes = false;
            selectedCalendar = false;
            selectedConfig = false;

            // Posicion de los botones
            pbMenuIcon.Location = ppbInicio;
            pbUserIcon.Location = new Point(47, 211); 
            pbNotesIcon.Location = ppbNotas;
            pbCalendarIcon.Location = ppbCalendario;
            pbConfigIcon.Location = ppbConfig;

        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            AbrirForm<frmNotas>();

            // Diseño de los botones
            SelectedButton(btnNotas, pbNotesIcon);
            DeselectedButton(btnInicio, pbMenuIcon);
            DeselectedButton(btnCuenta, pbUserIcon);
            DeselectedButton(btnCalendario, pbCalendarIcon);
            DeselectedButton(btnConfig, pbConfigIcon);

            // Diseño del Icon de los botones
            selectedMenu = false;
            selectedUser = false;
            selectedNotes = true;
            selectedCalendar = false;
            selectedConfig = false;

            // Posicion de los botones
            pbMenuIcon.Location = ppbInicio;
            pbUserIcon.Location = ppbCuenta; 
            pbNotesIcon.Location = new Point(47,311);
            pbCalendarIcon.Location = ppbCalendario;
            pbConfigIcon.Location = ppbConfig;
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            AbrirForm<frmCalendario>();

            // Diseño de los botones
            SelectedButton(btnCalendario, pbCalendarIcon);
            DeselectedButton(btnInicio, pbMenuIcon);
            DeselectedButton(btnCuenta, pbUserIcon);
            DeselectedButton(btnNotas, pbNotesIcon);
            DeselectedButton(btnConfig, pbConfigIcon);

            // Diseño del Icon de los botones
            selectedMenu = false;
            selectedUser = false;
            selectedNotes = false;
            selectedCalendar = true;
            selectedConfig = false;

            // Posicion de los botones
            pbMenuIcon.Location = ppbInicio;
            pbUserIcon.Location = ppbCuenta;
            pbNotesIcon.Location = ppbNotas;
            pbCalendarIcon.Location = new Point(47, 414) ;
            pbConfigIcon.Location = ppbConfig;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            AbrirForm<frmConfig>();

            // Diseño de los botones
            SelectedButton(btnConfig, pbConfigIcon);
            DeselectedButton(btnInicio, pbMenuIcon);
            DeselectedButton(btnCuenta, pbUserIcon);
            DeselectedButton(btnNotas, pbNotesIcon);
            DeselectedButton(btnCalendario, pbCalendarIcon);

            // Diseño del Icon de los botones
            selectedMenu = false;
            selectedUser = false;
            selectedNotes = false;
            selectedCalendar = false;
            selectedConfig = true;

            // Posicion de los botones
            pbMenuIcon.Location = ppbInicio;
            pbUserIcon.Location = ppbCuenta;
            pbNotesIcon.Location = ppbNotas;
            pbCalendarIcon.Location = ppbCalendario;
            pbConfigIcon.Location = new Point(47, 516);
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


    }
}
