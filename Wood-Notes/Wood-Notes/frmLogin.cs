using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Conexion conexion = new Conexion();
        #region Ingreso con usuario
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // Conexion a la clase de Users por medio del objeto ingresoUsers
            Users ingresoUsers = new Users();

            ingresoUsers.setUsuario(txtUsuario.Text);
            ingresoUsers.setPassword(txtPassword.Text);

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
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Para ingresar como invitado debe acceder en el boton de ''Invitado''", "Error de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Verifica y niega el accaso al programa por usuario ingresado incorrectamente
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Ingreso como invitado
        private void btnInvitado_Click(object sender, EventArgs e)
        {
            Invitado();

        }

        private void btnInvitado2_Click(object sender, EventArgs e)
        {
            Invitado();
        }

        private void Invitado()
        {
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
        private void label3_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            this.Hide();
        }
        #endregion

        #region Salir del rpograma
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


    }
}
