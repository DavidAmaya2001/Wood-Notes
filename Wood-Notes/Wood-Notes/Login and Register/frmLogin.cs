using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wood_Notes.Models;

namespace Wood_Notes
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region Ingreso con usuario
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // Conexion a la clase de Users por medio del objeto ingresoUsers
            Users ingresoUsers = new Users();

            ingresoUsers.setUsuario(txtUsuario.Text);
            ingresoUsers.setPassword(txtPassword.Text);

            // Declaración de Point para las posiciones de los mensajes de alerta
            Point credentialsposition = new Point(308,296);
            Point invitadoposition = new Point(244, 296);

            bool result = ingresoUsers.Verificador();
            // Verifica el resultado y da el accaso al programa con el usuario
            if(result == true)
            {   
                // if verificador de que la cuenta ingresada no sea la de invitado
                if (ingresoUsers.getId() != 1)
                {
                    // Mandado de datos al frmWorkStation y dando el pase al usuario
                    frmWorkStation frmMain = new frmWorkStation();
                    frmMain.lblIdUser.Text = ingresoUsers.getUsuario();
                    frmMain.lblId.Text = ingresoUsers.getId().ToString();


                    frmMain.ShowDialog();
                    this.Hide();
                }
                else
                {
                    // Saltará una alerta por ingresar al invitado con credenciales
                    lblCredenciales.Visible = true;
                    lblCredenciales.Location = invitadoposition;
                    lblCredenciales.Text = "No se puede ingresar como 'Invitado' usando credenciales";
                }
            }
            // Verifica y niega el accaso al programa por usuario ingresado incorrectamente
            else
            {
                // Saltará una alerta por ingresar con credenciales incorrectas
                lblCredenciales.Visible = true;
                lblCredenciales.Location = credentialsposition;
                lblCredenciales.Text = "Usuario y/o contraseña incorrecta";
            }
        }
        #endregion

        #region Ingreso como invitado

        // Botones de dan acceso al usuario para ingresar como Invitado en base a una misma función de Invitado()
        private void btnInvitado_Click(object sender, EventArgs e)
        {
            Invitado();

        }
        private void btnInvitado2_Click(object sender, EventArgs e)
        {
            Invitado();
        }

        // Funcion para ingresar como invitado con parametros ya establecidos y solo accesibles desde el boton de Invitado
        private void Invitado()
        {
            // Ingreso de los datos de Invitado a la clase para dar el acceso como usuario Invitado
            Users ingresoInvitado = new Users();

            ingresoInvitado.setUsuario("Invitado");
            ingresoInvitado.setPassword("Invitado");

            bool result = ingresoInvitado.Verificador();
            // Verifica el resultado y da el accaso al programa con el usuario
            if (result == true)
            {
                frmWorkStation frmMain = new frmWorkStation();
                frmMain.lblIdUser.Text = ingresoInvitado.getUsuario();
                frmMain.lblId.Text = ingresoInvitado.getId().ToString();
                frmMain.Show();
                this.Hide();
            }
        }
        #endregion

        #region Creacion de Cuenta en frmRegister

        // Label que linkea al formulario de Registro para poder crear una nueva cuenta
        private void label3_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            this.Hide();
        }
        #endregion

        #region Funciones de la barra de herramientas del form

        // Boton que permite poder salir del programa desde el Login
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Boton para minimizar la ventana del Login
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Funciones UI del Login

        // Bool para comprobar si esta activa la visualización de la clave o no lo esta
        bool eyeUI = true;
        private void pbEyePass_Click(object sender, EventArgs e)
        {
            if (eyeUI)
            {
                eyeUI = false;
                pbEyePass.Image = Wood_Notes.Properties.Resources.iconeyeImage;
                txtPassword.PasswordChar = default;
            }
            else
            {
                eyeUI = true;
                pbEyePass.Image = Wood_Notes.Properties.Resources.iconcloseeyeImage;
                txtPassword.PasswordChar = Convert.ToChar("*");
            }
        }


        #endregion

        #region Movimiento del Form en la pantalla

        // Estableciendo posiciones iniciales en CenterScreen
        int PointY = 0;
        int PointX = 0;
        private void panelSup_MouseMove(object sender, MouseEventArgs e)
        {
            // Mientras el mouse este presionado sobre el panel este le entregará nuevas coordenadas al form para moverse
            if(e.Button != MouseButtons.Left)
            {
                PointX = e.X;
                PointY = e.Y;
            }
            // Cuando se deje de mover el form este conservara su ultima posición
            else
            {
                Left = Left + (e.X - PointX);
                Top = Top + (e.Y - PointY);
            }
        }
        #endregion


    }
}
