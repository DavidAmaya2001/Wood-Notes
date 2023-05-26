using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace Wood_Notes
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        #region Barra de herramientas del formulario
        // Funcion para salir del registro de usuario y regresar al formulario de Login
        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin logueo = new frmLogin();
            logueo.Show();
            this.Close();
        }
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Inserción de nuevo Usuario

        // Validación de Campos llenos y que el usuario sea nuevo e Inserción de los datos a la Base de datos
        // Campos obligatorios:
        // - nombre
        // - país
        // - teléfono
        // - nickname
        // - correo electronico
        // - contraseña
        // - contraseña repetida correctamente

        Users newUser = new Users();
        string imgLocation = "";
        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            // Corrección del DatTimePicker y ajustes de valores predeterminados como el formato, asignación de hora y ser invisible al usuario
            dtpNewUser.Format = DateTimePickerFormat.Custom;
            dtpNewUser.CustomFormat = "yyyy/MM/dd";
            dtpNewUser.Value = DateTime.Now;
            dtpNewUser.Visible = false;

            // Validación de los campos totalmente verificados y llenos
            if (
                nameverified && phoneverified && nicknameverified && emailverified && passverified && repassverified
                )
            {
                // Inserción de datos a la clase con sus respectivas eliminaciones de espacios adelante y atras de los campos de los controladores
                newUser.setNombre(txtName.Text);
                newUser.setApellido(txtLastName.Text);
                newUser.setPais(cmbPais.Text);
                newUser.setCodigo(txtCodigo.Text);
                newUser.setTelefono(txtPhone.Text);
                newUser.setFecha_union(dtpNewUser.Text);
                newUser.setUsuario(txtNickname.Text);
                newUser.setPassword(txtPassword.Text);
                newUser.setEmail(txtEmail.Text);

                DialogResult result = MessageBox.Show("¿Esta seguro/a que desea agregar el siguiente usuario?", "Agregar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // Linea de insersion a la base de datos despues del ok del OpenFileDialog
                if (result == DialogResult.OK)
                {
                    // Funcion de la clase para agregar al nuevo usuario
                    // Se manda el imgLocation aunque no se haya ingresado imagen, en la clase Users se hace la division entre insercion o no de imagen
                    newUser.NewRegister(imgLocation);
                    MessageBox.Show("Registro agregado correctamente","Bienvenido",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    CleanForm();
                }
                else
                {
                    // No hará nada el programa
                    //MessageBox.Show("Registro no agregado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Aun quedan campos obligatorios por validar.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        // Inserción de imagen solo en el PictureBox para luego ser procesada a la base de datos
        // Validación para que todos los controladores dentro del PictureBox funcionen como OpenFileDialog

        // Subregion
        #region FileDialogs
        private void btnImage_Click(object sender, EventArgs e)
        {
            // Apertura del OpenFileDialog
            openFileDialog1.ShowDialog();
        }
        private void pbProfilePicture_Click(object sender, EventArgs e)
        {
            // Apertura del OpenFileDialog
            openFileDialog1.ShowDialog();
        }
        private void lblagregarimg_Click(object sender, EventArgs e)
        {
            // Apertura del OpenFileDialog
            openFileDialog1.ShowDialog();
        }
        private void lblagregarimg2_Click(object sender, EventArgs e)
        {
            // Apertura del OpenFileDialog
            openFileDialog1.ShowDialog();
        }

        // Funcion principal del OpenFileDialog para insertar la imagen al PiictureBox
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Guardado de la imagen en el PictureBox segun lo elegido en el openFileDialog
            pbProfilePicture.Image = Image.FromFile(openFileDialog1.FileName);
            imgLocation = openFileDialog1.FileName.ToString();
            lblagregarimg.Visible = false;
            lblagregarimg2.Visible = false;
        }
        #endregion
        // Fin de Subregion

        // Subregion
        #region Limpieza de datos del Form
        private void CleanForm()
        {
            // Name Default Settings
            txtName.Text = "";
            lblNameVerified.Text = "";
            pbNameVerified.Visible = false;
            nameverified = false;

            txtLastName.Text = "";
            lblLastNameVerified.Text = "";
            pbLastNameVerified.Visible = false;

            // PictureBox Default Settings
            pbProfilePicture.Image = null;

            // Phone & Region Default Settings 
            cmbPais.SelectedIndex = 0;
            pbPais.Visible = false;

            txtPhone.Text = "";
            lblPhoneVerified.Text = "";
            pbPhoneVerified.Visible = false;

            // Nickname Default Settings
            txtNickname.Text = "";
            lblnickname.Text = "";
            pbNicknameverified.Visible = false;
            nicknameverified = false;

            // Email Default Settings
            txtEmail.Text = "";
            lblEmail.Text = "";
            btnEmailVerified.Visible = false;
            emailverified = false;

            // Password & RePassword Default Settings
            txtPassword.Text = "";
            lblPassSecure.Text = "";
            btnSecurePass.Visible = false;
            panelBarPass.BackColor = Color.Transparent;
            passverified = false;

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

            txtRePassword.Text = "";
            lblRePass.Text = "";
            pbRePass.Visible = false;
            repassverified = false;

            if (eyeReUI)
            {
                eyeReUI = false;
                pbEyeRePass.Image = Wood_Notes.Properties.Resources.iconeyeImage;
                txtRePassword.PasswordChar = default;
            }
            else
            {
                eyeReUI = true;
                pbEyeRePass.Image = Wood_Notes.Properties.Resources.iconcloseeyeImage;
                txtRePassword.PasswordChar = Convert.ToChar("*");
            }

        }
        #endregion
        // Fin de Subregion

        #endregion

        #region Variables de validación de campos

        // Variables verificadoras que los campos obligatorios esten llenos correctamente antes de añadir usuarios
        bool nameverified = false;
        bool phoneverified = false;
        bool nicknameverified = false;
        bool emailverified = false;
        bool passverified = false;
        bool repassverified = false;

        #endregion

        #region Validación de Campos del formulario y restricciones de teclas 

        // Subregion
        #region Restricciones de las teclas en los controladores
        // Validación de solo letras, controles y separadores
        public void SoloLetras(KeyPressEventArgs E)
        {
            if (Char.IsLetter(E.KeyChar))
            {
                E.Handled = false;
            }
            else if (Char.IsControl(E.KeyChar))
            {
                E.Handled = false;
            }
            else if (Char.IsSeparator(E.KeyChar))
            {
                E.Handled = false;
            }
            else
            {
                E.Handled = true;
            }
        }
        // Validación de solo letras, numeros, controladores y separadores
        public void SoloLetrasyDigitos(KeyPressEventArgs E)
        {
            SoloLetras(E);
            if (Char.IsDigit(E.KeyChar))
            {
                E.Handled = false;
            }
        }
        // Validación de solo numeros y guion
        public void SoloNumeros(KeyPressEventArgs E)
        {
            if (Char.IsDigit(E.KeyChar))
            {
                E.Handled = false;
            }
            else if (Char.IsControl(E.KeyChar))
            {
                E.Handled = false;
            }
            else
            {
                E.Handled = true;
            }
        }
        #endregion
        // Fin de Subregion


        // Verificadoes del controlador para el campo de Nombre ( Obligatorio )
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                pbNameVerified.Visible = true;
                pbNameVerified.Image = Wood_Notes.Properties.Resources.warning;
                lblNameVerified.Text = "Campo Vacio";
                lblNameVerified.TextAlign = ContentAlignment.MiddleCenter;
                nameverified = false;
            }
            else if (txtName.Text.Length <= 2)
            {
                pbNameVerified.Visible = true;
                pbNameVerified.Image = Wood_Notes.Properties.Resources.warning;
                lblNameVerified.Text = "Nombre demasiado corto";
                nameverified = false;
            }
            else
            {
                pbNameVerified.Visible = true;
                pbNameVerified.Image = Wood_Notes.Properties.Resources.userverified;
                lblNameVerified.Text = "";
                nameverified = true;
            }
        }

        // Verificadores del controlador para el campo Apellido ( No obligatorio )
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text.Length == 0)
            {
                pbLastNameVerified.Visible = false;
                lblLastNameVerified.Text = "";
            }
            else if (txtLastName.Text.Length > 2)
            {
                pbLastNameVerified.Visible = true;
                pbLastNameVerified.Image = Wood_Notes.Properties.Resources.userverified;
                lblLastNameVerified.Text = "";
            }
            else if (txtLastName.Text.Length <= 2)
            {
                pbLastNameVerified.Visible = true;
                pbLastNameVerified.Image = Wood_Notes.Properties.Resources.warning;
                lblLastNameVerified.Text = "Apellido demasiado corto";
            }
        }

        // Verificadores del controlador para el campo de Nickname ( Obligatorio )
        private void txtNickname_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetrasyDigitos(e);
        }
        private void txtNickname_Leave(object sender, EventArgs e)
        {
            Users verUsers = new Users();
            bool result = verUsers.VerificadorDeCuentas(txtNickname.Text);
            // Verificar si el campo no se encuentra vacio y es mayor a 5 caracteres
            if (txtNickname.Text.Length >= 5 && txtNickname.Text.Length >= 1)
            {
                // Si el usuario ya existe entonces lanza una advertencia
                if (result == true)
                {
                    pbNicknameverified.Visible = true;
                    pbNicknameverified.Image = Wood_Notes.Properties.Resources.warning;
                    lblnickname.Text = "El nombre de usuario ya esta ocupado, intente con otro";
                    nicknameverified = false;
                }
                // Si el usuario no existe le dara la aprobación
                else
                {
                    pbNicknameverified.Visible = true;
                    pbNicknameverified.Image = Wood_Notes.Properties.Resources.userverified;
                    lblnickname.Text = "¡El nombre de usuario se encuentra disponible!";
                    nicknameverified = true;
                }
            }
            // Verificar si el campo tiene menos de 5 caracteres y no este vacio
            else if (txtNickname.Text.Length <= 5 && txtNickname.Text.Length >= 1)
            {
                pbNicknameverified.Visible = true;
                pbNicknameverified.Image = Wood_Notes.Properties.Resources.warning;
                lblnickname.Text = "El nombre de usuario no puede ser menor a 5 caracteres";
                nicknameverified = false;
            }
            // Verificar si el campo esta vacio
            else if (txtNickname.Text.Length == 0)
            {
                pbNicknameverified.Visible = false;
                pbNicknameverified.Image = Wood_Notes.Properties.Resources.userverified;
                lblnickname.Text = "";
                nicknameverified = false;
            }
        }
        // Verificadores del controlador para el campo de Email ( Obligatorio )
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sin restricciones
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Users userEmail = new Users();
            // Patrón que debe tener el textbox para ser considerado un correo valido
            string pattern = "^([0-9a-zA-Z]([-\\.\\w])*@([0-9a-z][-\\w]*[0-9a-z]\\.)+[a-z]{2,9})$";
            // Metodo para verificar si ya existe el correo
            bool result = userEmail.VerificadorDeCorreos(txtEmail.Text);

            // Verifica si el campo esta vacio o se ha llenado
            if (txtEmail.Text.Length > 0)
            {
                // Verifica si el campo sigue con el patrón correspondiente al de un correo electronico
                if (Regex.IsMatch(txtEmail.Text, pattern))
                {
                    // Verifica si el correo ya existe en la base dedatos con otro usuario
                    if (result == true)
                    {
                        btnEmailVerified.Visible = true;
                        btnEmailVerified.Image = Wood_Notes.Properties.Resources.warning;
                        lblEmail.Text = "El correo ya esta en uso";
                        emailverified = false;
                    }
                    else
                    {
                        btnEmailVerified.Visible = true;
                        btnEmailVerified.Image = Wood_Notes.Properties.Resources.userverified;
                        lblEmail.Text = "¡Correo verificado exitosamente!";
                        emailverified = true;
                    }
                }
                else
                {
                    btnEmailVerified.Visible = true;
                    btnEmailVerified.Image = Wood_Notes.Properties.Resources.warning;
                    lblEmail.Text = "Debe ingresar el formato correcto de un correo";
                    emailverified = false;
                }
            }
            else
            {
                btnEmailVerified.Visible = false;
                btnEmailVerified.Image = Wood_Notes.Properties.Resources.userverified;
                lblEmail.Text = "";
                emailverified = false;
            }
        }

        // Verificador de los controladores para los campos de Contraseña y Confirmación de Contraseña ( Obligatorios )
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetrasyDigitos(e);
        }

        private void txtRePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetrasyDigitos(e);
        }
        // UI de la barra de progreso de la seguridad de la contraseña y verificador de contraseña
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            int lenght = txtPassword.Text.Length;

            switch (lenght)
            {
                case 0:
                    panelBarPass.BackColor = Color.Transparent;
                    lblPassSecure.Text = "";
                    btnSecurePass.Visible = false;
                    DesabilitadortxtRePassword();
                    break;
                case 1:
                    BarraRoja();
                    btnSecurePass.Visible = true;
                    DesabilitadortxtRePassword();
                    break;
                case 2:
                    BarraRoja();
                    DesabilitadortxtRePassword();
                    break;
                case 3:
                    BarraRoja();
                    DesabilitadortxtRePassword();
                    break;
                case 4:
                    BarraNaranja();
                    DesabilitadortxtRePassword();
                    break;
                case 5:
                    BarraNaranja();
                    DesabilitadortxtRePassword();
                    break;
                case 6:
                    BarraNaranja();
                    btnSecurePass.Visible = true;
                    DesabilitadortxtRePassword();
                    break;
                case 7:

                    lblPassSecure.Text = "¡La contraseña es segura!";
                    panelBarPass.BackColor = Color.Green;
                    panelBarPass.Size = new System.Drawing.Size(184, 3);
                    btnSecurePass.Image = Wood_Notes.Properties.Resources.passwordverified;
                    btnSecurePass.Visible = true;
                    txtRePassword.Enabled = true;
                    passverified = true;
                    break;
            }

            
        } /*--------------------------------------------------------------------------------------------------------------------*/

        public void DesabilitadortxtRePassword()
        {
            lblPassSecure.Text = "La contraseña es demasiado corta";
            btnSecurePass.Image = Wood_Notes.Properties.Resources.warningpass;
            txtRePassword.Text = "";
            lblRePass.Text = "";
            pbRePass.Visible = false;
            txtRePassword.Enabled = false;
            passverified = false;
        }
        public void BarraNaranja()
        {
            panelBarPass.BackColor = Color.Orange;
            panelBarPass.Size = new System.Drawing.Size(124, 3);
        }
        public void BarraRoja()
        {
            panelBarPass.BackColor = Color.Red;
            panelBarPass.Size = new System.Drawing.Size(74, 3);
        }

        // Comprobador de contraseña repetida en ambos campos
        private void txtRePassword_Leave(object sender, EventArgs e)
        {
            if (txtRePassword.Text == txtPassword.Text)
            {
                lblRePass.Text = "¡Las contraseñas coinciden!";
                pbRePass.Image = Wood_Notes.Properties.Resources.passwordverified;
                pbRePass.Visible = true;
                repassverified = true;
            }
            else
            {
                lblRePass.Text = "¡Las contraseñas no coinciden!";
                pbRePass.Image = Wood_Notes.Properties.Resources.warningpass;
                pbRePass.Visible = true;
                repassverified = false;
            }
        }

        // Validaciones del telefono en los campos de cmbPais y txtPhone
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            string phoneNumber = txtPhone.Text;
            if (phoneNumber.Length == 8)
            {
                txtPhone.Text = phoneNumber.Substring(0, 4) + "-" + phoneNumber.Substring(4, 4);
                pbPhoneVerified.Visible = true;
                pbPhoneVerified.Image = Wood_Notes.Properties.Resources.userverified;
                lblPhoneVerified.Text = "";
                phoneverified = true;
            }
            else if (phoneNumber.Length == 0)
            {
                pbPhoneVerified.Image = Wood_Notes.Properties.Resources.warning;
                pbPhoneVerified.Visible = true;
                lblPhoneVerified.Text = "Campo se encuentra vacio";
                phoneverified = false;
                // Caso que no ingrese numero telefonico no se agrega guion 
            }
            else
            {
                pbPhoneVerified.Image = Wood_Notes.Properties.Resources.warning;
                pbPhoneVerified.Visible = true;
                lblPhoneVerified.Text = "¡El campo no contiene el formato correcto!";
                phoneverified = false;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            string phoneNumber = txtPhone.Text;
            if (phoneNumber.Contains("-"))
            {
                txtPhone.Text = phoneNumber.Substring(0, 4) + phoneNumber.Substring(5, 4);
            }
            else if (phoneNumber == null)
            {
                // No hará nada porque estará vacio
            }
        }

        // Seleccion de Pais y estableciendo el prefijo segun pais que corresponda
        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPais.SelectedIndex != 0)
            {
                // Habilitando campo numerico una vez seleccione un pais
                txtPhone.Enabled = true;

                switch (cmbPais.SelectedIndex)
                {
                    case 1:
                        txtCodigo.Text = "(+503)";
                        pbPais.Visible = true;
                        pbPais.Image = Wood_Notes.Properties.Resources.el_salvador;
                        break;
                    case 2:
                        txtCodigo.Text = "(+506)";
                        pbPais.Visible = true;
                        pbPais.Image = Wood_Notes.Properties.Resources.costa_rica;
                        break;
                    case 3:
                        txtCodigo.Text = "(+502)";
                        pbPais.Visible = true;
                        pbPais.Image = Wood_Notes.Properties.Resources.guatemala;
                        break;
                    case 4:
                        txtCodigo.Text = "(+501)";
                        pbPais.Visible = true;
                        pbPais.Image = Wood_Notes.Properties.Resources.belice;
                        break;
                    case 5:
                        txtCodigo.Text = "(+504)";
                        pbPais.Visible = true;
                        pbPais.Image = Wood_Notes.Properties.Resources.honduras;
                        break;
                    case 6:
                        txtCodigo.Text = "(+507)";
                        pbPais.Visible = true;
                        pbPais.Image = Wood_Notes.Properties.Resources.panama;
                        break;
                    case 7:
                        txtCodigo.Text = "(+505)";
                        pbPais.Visible = true;
                        pbPais.Image = Wood_Notes.Properties.Resources.nicaragua;
                        break;
                    default:
                        pbPais.Visible = false;
                        txtCodigo.Text = ""; txtPhone.ReadOnly = true;
                        break;
                }

            }
            else
            {
                pbPais.Visible = false;
                txtCodigo.Text = "";
                txtPhone.Enabled = false;
            }
        }

        #endregion

        #region UI del Form Register
        // UI del boton de visor de contraseña
        bool eyeUI = false;
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

        // UI del boton de visor de confirmación de contraseña
        bool eyeReUI = false;
        private void pbEyeRePass_Click(object sender, EventArgs e)
        {
            if (eyeReUI)
            {
                eyeReUI = false;
                pbEyeRePass.Image = Wood_Notes.Properties.Resources.iconeyeImage;
                txtRePassword.PasswordChar = default;
            }
            else
            {
                eyeReUI = true;
                pbEyeRePass.Image = Wood_Notes.Properties.Resources.iconcloseeyeImage;
                txtRePassword.PasswordChar = Convert.ToChar("*");
            }

        }
        #endregion


    }
}
