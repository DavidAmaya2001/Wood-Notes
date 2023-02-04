using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wood_Notes
{
    public partial class frmNotasSubMenu2 : Form
    {
        public frmNotasSubMenu2()
        {
            InitializeComponent();
            LoadData Data = new LoadData();
            txtId.Visible = false;
            dtpNewDate.Format = DateTimePickerFormat.Custom; // Modificando formato de DateTimePicker
            dtpNewDate.CustomFormat = "yyyy/MM/dd";

        }

        frmDetalles formulariodetalles = new frmDetalles();
        Conexion conexion = new Conexion();

        #region Botones de cierre
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Placeholders de Textbox

        // Placeholder de Textbox Titulo
        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                txtTitulo.Text = "Título";
                txtTitulo.ForeColor = Color.Silver;
            }
        }

        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            // Hover de textbox
            if (txtTitulo.Text == "Título")
            {
                txtTitulo.Text = "";
                txtTitulo.ForeColor = Color.Black;
            }
            // Ocultando menu
            if (panelMenu.Visible == true)
            {
                panelMenu.Visible = false;
            }
        }

        // Placeholder de Textbox Nota
        private void rtxtNota_Leave(object sender, EventArgs e)
        {
            if (rtxtNota.Text == "")
            {
                rtxtNota.Text = "Escribe una nota";
                rtxtNota.ForeColor = Color.Silver;
            }
        }

        private void rtxtNota_Enter(object sender, EventArgs e)
        {
            // Hover de textbox
            if (rtxtNota.Text == "Escribe una nota")
            {
                rtxtNota.Text = "";
                rtxtNota.ForeColor = Color.Black;
            }
            // Ocultando menu
            if (panelMenu.Visible == true)
            {
                panelMenu.Visible = false;
            }
        }

        #endregion

        #region Menu desplegable
        // Acciones del menu desplegable
        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Accion de abrir y cerrar panel menu
            if (panelMenu.Visible == false)
            {
                panelMenu.Visible = true;
            }
            else
            {
                panelMenu.Visible = false;
            }

            // Regresando Placeholder al acceder al menu
            if (txtTitulo.Text == "")
            {
                txtTitulo.Text = "Título";
                txtTitulo.ForeColor = Color.Silver;
            }
            if (rtxtNota.Text == "")
            {
                rtxtNota.Text = "Escribe una nota";
                rtxtNota.ForeColor = Color.Silver;
            }
        }

        // Boton que ejecuta la funcion de la clase Conexion para poder modificar los datos en la base de datos
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea modificar la siguiente nota?", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if(result == DialogResult.OK)
            {
                dtpNewDate.Value = DateTime.Now;
                // Verificación de campos vacios en los textbox
                if (txtTitulo.ForeColor != Color.Silver && rtxtNota.ForeColor != Color.Silver)
                {
                    conexion.AbrirConexion();
                    // Modificar para agregar el campo de ultimo cambio aparte del cambo de fecha de creación
                    conexion.ModificarDato(Convert.ToInt32(txtId.Text), txtTitulo.Text, rtxtNota.Text, dtpNewDate.Text, Convert.ToInt32(lblcontador.Text));
                    conexion.CerrarConexion();
                    panelMenu.Visible = false;
                    MessageBox.Show("El cambio se realizó correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtTitulo.ForeColor == Color.Silver)
                    {
                        errorTitulo.SetError(txtTitulo, "El campo no puede estar vacío");
                        errorNota.Clear();
                    }
                    else if (rtxtNota.ForeColor == Color.Silver)
                    {
                        errorNota.SetError(rtxtNota, "El campo no puede estar vacío");
                        errorTitulo.Clear();
                    }
                    else
                    {
                        errorTitulo.Clear();
                        errorNota.Clear();
                    }
                }
            }
            
            conexion.AbrirConexion();
            
            conexion.CerrarConexion();
        }

        // Boton que ejecuta la funcion de la clase Conexion para poder eliminar los datos de la base de datos
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            

            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la siguiente nota?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                // Verificación de campos vacios en los textbox
                if (txtTitulo.ForeColor != Color.Silver && rtxtNota.ForeColor != Color.Silver)
                {
                    frmNotas formularionotas = new frmNotas();
                    formularionotas.btnReload.Size = new Size(43, 43);
                    string Location = @"D:\Users\Documentos\GitHub TuTioElPollo\Wood-Notes\Wood-Notes\Wood-Notes\Images\ReloadNew.png";
                    byte[] bufferdefaultreload = File.ReadAllBytes(Location);
                    using (MemoryStream ms = new MemoryStream(bufferdefaultreload))
                    {
                        formularionotas.btnReload.Image = Image.FromStream(ms);
                    }


                    conexion.AbrirConexion();
                    conexion.EliminarDato(Convert.ToInt32(txtId.Text));
                    txtTitulo.Text = "";
                    rtxtNota.Text = "";
                    dtpNewDate.Value = DateTime.Now;
                    conexion.CerrarConexion();
                    MessageBox.Show("La nota se ha eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                    
                }
                else
                {
                    if (txtTitulo.ForeColor == Color.Silver)
                    {
                        errorTitulo.SetError(txtTitulo, "El campo no puede estar vacío");
                        errorNota.Clear();
                    }
                    else if (rtxtNota.ForeColor == Color.Silver)
                    {
                        errorNota.SetError(rtxtNota, "El campo no puede estar vacío");
                        errorTitulo.Clear();
                    }
                    else
                    {
                        errorTitulo.Clear();
                        errorNota.Clear();
                    }
                }
            }

        }

        // Boton que abre el formulario de detalles
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            // Paso de datos hacia el formulario detalles
            formulariodetalles.txtId.Text = txtId.Text;
            if(txtCreacion.Text.Length == 19)
            {
                formulariodetalles.txtCreacion.Text = txtCreacion.Text.Substring(0, 11);
            }
            else if(txtCreacion.Text.Length == 18)
            {
                formulariodetalles.txtCreacion.Text = txtCreacion.Text.Substring(0, 10);
            }
            else
            {
                formulariodetalles.txtCreacion.Text = txtCreacion.Text.Substring(0, 9);
            }

            if(txtMod.Text.Length == 19)
            {
                formulariodetalles.txtModificacion.Text = txtMod.Text.Substring(0,11);
            }
            else if(txtMod.Text.Length == 18)
            {
                formulariodetalles.txtModificacion.Text = txtMod.Text.Substring(0, 10);
            }
            else
            {
                formulariodetalles.txtModificacion.Text = txtMod.Text.Substring(0, 9);
            }
            
            
            formulariodetalles.txtCaracteres.Text = lblcontador.Text;

            // Abriendo formulario detalles
            panelMenu.Visible = false;
            formulariodetalles.ShowDialog();
        }

        #endregion

        #region Contador de caracteres y Peso
        private void rtxtNota_TextChanged(object sender, EventArgs e)
        {
            lblcontador.Text = rtxtNota.TextLength.ToString();
        }
        #endregion
    }
}
