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

namespace Wood_Notes
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        #region Salir del registro
        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin logueo = new frmLogin();
            logueo.Show();
            this.Close();
        }
        #endregion

        #region Inserción de nuevo Usuario
        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            Users newUser = new Users();
            newUser.setNombre(txtName.Text);
            newUser.setApellido(txtLastName.Text);
            newUser.setPais(cmbPais.Text);
            newUser.setTelefono(txtPhone.Text); // Agregarle el prefijo al numero despues
            newUser.setFecha_union(DateTime.Now.ToString());
            // Agregar la imagen a la base de datos despues
            newUser.setUsuario(txtNickname.Text);
            newUser.setPassword(txtPassword.Text);
            newUser.setEmail(txtEmail.Text);
        }

        // Inserción de imagen solo en el programa
        private void btnImage_Click(object sender, EventArgs e)
        {
            // Abriendo OpenFileDialog para la selección de la imagen en los formatos establecidos
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos |*.jpeg;*jpg;*png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Ruta almacenada en textbox
                txtPictureSource.Text = @"" + ofd.FileName;

                // Creando buffer donde se almacenaran los bytes de la imagen para ser leidos
                byte[] buffer = File.ReadAllBytes(ofd.FileName);

                // Cargado de imagen en el PictureBox
                using (MemoryStream ms = new MemoryStream(buffer))
                {
                    pbProfilePicture.Image = Image.FromStream(ms);
                    pbProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
        #endregion

        #region Validación de campos 
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
        public void SoloNumerosGuion(KeyPressEventArgs E)
        {
            SoloLetrasyDigitos(E);
            if (E.KeyChar.ToString() == "-")
            {
                E.Handled = false;
            }
        }
        // Habilitador de campo telefonico

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtNickname_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetrasyDigitos(e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sin restricciones
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetrasyDigitos(e);
        }

        private void txtRePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetrasyDigitos(e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosGuion(e);
        }

        // Seleccion de Pais y estableciendo el prefijo segun pais que corresponda
        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPais.SelectedIndex != 0)
            {
                // Habilitando campo numerico una vez seleccione un pais
                txtPhone.ReadOnly = false;

                switch (cmbPais.SelectedIndex)
                {
                    case 1:
                        txtCodigo.Text = "(+503)";
                        break;
                    case 2:
                        txtCodigo.Text = "(+506)";
                        break;
                    case 3:
                        txtCodigo.Text = "(+502)";
                        break;
                    case 4:
                        txtCodigo.Text = "(+501)";
                        break;
                    case 5:
                        txtCodigo.Text = "(+504)";
                        break;
                    case 6:
                        txtCodigo.Text = "(+507)";
                        break;
                    case 7:
                        txtCodigo.Text = "(+505)";
                        break;
                    default:
                        txtCodigo.Text = ""; txtPhone.ReadOnly = true;
                        break;
                }

            }
            else
            {
                txtCodigo.Text = "";
                txtPhone.ReadOnly = true;
            }
        }


        #endregion


    }
}
