using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace Wood_Notes
{
    public partial class frmNotasSubMenu : Form
    {
        // Variable id Global a Local
        string idUserNotes = Users.IdUserGlobal;

        bool tituloVerified = false;
        bool notaVerified = false;

        // Estableciendo conexion y ajustando parametros de los controladores
        Conexion conexion = new Conexion();
        public frmNotasSubMenu()
        {
            InitializeComponent();
            conexion.AbrirConexion();
            dtpNewDate.Format = DateTimePickerFormat.Custom; // Modificando formato de DateTimePicker
            dtpNewDate.CustomFormat = "yyyy/MM/dd";
        }

        #region Menu desplegable (Agregar, Copiar, Crear txt)
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

        // Agregado de nota
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmación
            DialogResult result = MessageBox.Show( "¿Desea guardar la siguiente nota?", "Agregar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // Verificacion de campos vacios de una nueva nota
                if ( tituloVerified && notaVerified)
                {
                    // Inserción de los datos si todo esta correctamente validado
                    conexion.InsertarNotas(txtTitulo.Text, rtxtNota.Text, dtpNewDate.Text,Convert.ToInt32(lblcontador.Text),/*peso,*/int.Parse(idUserNotes));
                    txtTitulo.Text = "";
                    rtxtNota.Text = "";
                    dtpNewDate.Value = DateTime.Now;
                    panelMenu.Visible = false;
                    tituloVerified = false;
                    notaVerified = false;
                    MessageBox.Show("La nota se agrego correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!tituloVerified)
                    {
                        errorTitulo.SetError(txtTitulo, "El campo no puede estar vacío");
                        errorNota.Clear();
                    }
                    else if (!notaVerified)
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
        // Copiar al portapapeles
        private void btnPortapapeles_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Titulo: " + txtTitulo.Text + " ,Contenido: " + rtxtNota.Text);
        }
        // Creación de archivo .txt
        private void btnFile_Click(object sender, EventArgs e)
        {
            /*string RutaOrigen = @"D:\Users\Documentos";

            List<string> CreadorArchivo = new List<string>();
            CreadorArchivo.Add("Titulo: " + txtTitulo.Text);
            CreadorArchivo.Add("\n");
            CreadorArchivo.Add("Contenido: " + rtxtNota.Text);
            CreadorArchivo.Add("\n");
            CreadorArchivo.Add("Ultima fecha de modificación: " + dtpNewDate.Text);

            File.AppendAllLines(RutaOrigen, CreadorArchivo);
            */

            /*
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string RutaOrigen = fbd.SelectedPath;
                File.Create(RutaOrigen);
                List<string> CreadorArchivo = new List<string>();
                CreadorArchivo.Add("Titulo: " + txtTitulo.Text);
                CreadorArchivo.Add("\n");
                CreadorArchivo.Add("Contenido: " + rtxtNota.Text);
                CreadorArchivo.Add("\n");
                CreadorArchivo.Add("Ultima fecha de modificación: " + dtpNewDate.Text);

                File.AppendAllLines(RutaOrigen, CreadorArchivo);
            
            }
            */
            
        }

        #endregion

        #region Cierre de Ventana

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region PlaceHolders de los textbox

        // PlaceHolder de textbox Titulo
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

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                tituloVerified = false;
                txtTitulo.Text = "Título";
                txtTitulo.ForeColor = Color.Silver;
            }
            else
            {
                tituloVerified=true;
            }
        }

        // PlaceHolder de textbox Nota
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

        private void rtxtNota_Leave(object sender, EventArgs e)
        {
            if (rtxtNota.Text == "")
            {
                notaVerified = false;
                rtxtNota.Text = "Escribe una nota";
                rtxtNota.ForeColor = Color.Silver;
            }
            else
            {
                notaVerified = true;
            }
        }



        #endregion

        #region Contador de caracteres
        private void rtxtNota_TextChanged(object sender, EventArgs e)
        {
            lblcontador.Text = rtxtNota.TextLength.ToString();
        }
        #endregion
    }
}
