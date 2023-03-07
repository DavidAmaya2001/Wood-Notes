﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        Users newUser = new Users();
        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            // Falta verificar y establecer restricciones a los datos 
            dtpNewUser.Format = DateTimePickerFormat.Custom;
            dtpNewUser.CustomFormat = "yyyy/MM/dd";
            dtpNewUser.Value = DateTime.Now;
            dtpNewUser.Visible = false;


            newUser.setNombre(txtName.Text);
            newUser.setApellido(txtLastName.Text);
            newUser.setPais(cmbPais.Text);
            newUser.setTelefono(txtCodigo.Text + "" + txtPhone.Text);
            newUser.setFecha_union(dtpNewUser.Text);
            newUser.setUsuario(txtNickname.Text);
            newUser.setPassword(txtPassword.Text);
            newUser.setEmail(txtEmail.Text);

            // Linea de insersion
            if (newUser.NewRegister(this.pbProfilePicture))
            {
                MessageBox.Show("Registro agregad correctamente");
            }
            else
            {
                MessageBox.Show("Registro no agregado");
            }
            
        }

        // Inserción de imagen solo en el programa
        private void btnImage_Click(object sender, EventArgs e)
        {
            // Apertura del OpenFileDialog
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Guardado de la imagen en el PictureBox segun lo elegido en el openFileDialog
            pbProfilePicture.Image = Image.FromFile(openFileDialog1.FileName);
            lblagregarimg.Visible = false;
            lblagregarimg2.Visible = false;
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
        // Habilitador de campo telefonico

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        // Validaciones del Nickname
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
                }
                // Si el usuario no existe le dara la aprobación
                else
                {
                    pbNicknameverified.Visible = true;
                    pbNicknameverified.Image = Wood_Notes.Properties.Resources.userverified;
                    lblnickname.Text = "¡El nombre de usuario se encuentra disponible!";
                }
            }
            // Verificar si el campo tiene menos de 5 caracteres y no este vacio
            else if (txtNickname.Text.Length <= 5 && txtNickname.Text.Length >= 1)
            {
                pbNicknameverified.Visible = true;
                pbNicknameverified.Image = Wood_Notes.Properties.Resources.warning;
                lblnickname.Text = "El nombre de usuario no puede ser menor a 5 caracteres";
            }
            // Verificar si el campo esta vacio
            else if (txtNickname.Text.Length == 0)
            {
                pbNicknameverified.Visible = false;
                pbNicknameverified.Image = Wood_Notes.Properties.Resources.userverified;
                lblnickname.Text = "";
            }
        }
        // Validación del Email
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sin restricciones
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Users userEmail = new Users();
            // Patrón que debe tener el textbox para ser considerado un correo valido
            string pattern = "^([0-9a-zA-Z]([-\\.\\w])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
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
                        lblEmail2.Text = "";
                    }
                    else
                    {
                        btnEmailVerified.Visible = true;
                        btnEmailVerified.Image = Wood_Notes.Properties.Resources.userverified;
                        lblEmail.Text = "¡Correo verificado exitosamente!";
                        lblEmail2.Text = "";
                    }
                }
                else
                {
                    btnEmailVerified.Visible = true;
                    btnEmailVerified.Image = Wood_Notes.Properties.Resources.warning;
                    lblEmail.Text = "Debe ingresar el formato correcto de un correo";
                    lblEmail2.Text = "Ejemplo: example@gmail.com";
                }
            }
            else
            {
                btnEmailVerified.Visible = false;
                btnEmailVerified.Image = Wood_Notes.Properties.Resources.userverified;
                lblEmail.Text = "";
                lblEmail2.Text = "";
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetrasyDigitos(e);
        }

        private void txtRePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetrasyDigitos(e);
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
                errorPhone.Clear();
            }
            else if (phoneNumber == null)
            {
                errorPhone.Clear();
                // Caso que no ingrese numero telefonico no se agrega guion 
            }
            else
            {
                errorPhone.SetError(txtPhone, "El campo no contiene el formato adecuado");
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


    }
}
