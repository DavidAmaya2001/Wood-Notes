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

        frmNotas frmNotasOb = new frmNotas();

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
                // Cambia el target de los textbox al menu para que evalue si estan llenos o vacios
                panelMenu.Focus();
                txtTitulo.Text = "Título";
                txtTitulo.ForeColor = Color.Silver;
            }
            if (rtxtNota.Text == "")
            {
                // Cambia el target de los textbox al menu para que evalue si estan llenos o vacios
                panelMenu.Focus();
                rtxtNota.Text = "Escribe una nota";
                rtxtNota.ForeColor = Color.Silver;
            }
        }

        // Agregado de nota

        public bool updateIcon = false;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmación
            DialogResult result = MessageBox.Show( "¿Desea guardar la siguiente nota?", "Agregar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // Verificacion de campos vacios de una nueva nota
                if (tituloVerified && notaVerified)
                {
                    // Limpieza de texto en blanco delante y detras de los titulos y la nota
                    string TituloTrim = txtTitulo.Text.Trim();
                    string NotaTrim = rtxtNota.Text.Trim();

                    // Inserción de los datos si todo esta correctamente validado
                    conexion.InsertarNotas(TituloTrim, NotaTrim, dtpNewDate.Text,Convert.ToInt32(lblcontador.Text),/*peso,*/int.Parse(idUserNotes));

                    // Reinicio de los campos y de las variables booleanas
                    txtTitulo.Text = "";
                    rtxtNota.Text = "";
                    dtpNewDate.Value = DateTime.Now;
                    panelMenu.Visible = false;
                    tituloVerified = false;
                    notaVerified = false;

                    errorTitulo.Clear();
                    errorNota.Clear();

                    // Actualizacion del icono de recarga
                    updateIcon = true;

                    // Mensaje de exito
                    MessageBox.Show("La nota se agrego correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!tituloVerified) // Si antes de guardar no hay un titulo no puede crear la nota y genera el error siguiente:
                    {
                        errorTitulo.SetError(txtTitulo, "El campo no puede estar vacío");
                        errorNota.Clear();
                    }
                    else if (!notaVerified) // Si antes de guardar no hay contenido en la nota no puede crear la nota y genera el error siguiente:
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
            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea crear un archivo de texto para esta nota?", "Crear archivo de texto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(result == DialogResult.OK)
            {
                // Verificacion de campos vacios para la creacion del archivo de texto
                if (tituloVerified && notaVerified)
                {
                    // Se obtienen los valores de loscontroladores y los almacena en variables
                    string TituloTrim = txtTitulo.Text.Trim();
                    string NotaTrim = rtxtNota.Text.Trim();

                    // Ruta y nombre del archivo de destino (adaptarlo luego para que sea modificable en las configuraciones)
                    string direccionOrigen = "M:\\Usuarios\\OneDrive\\Escritorio\\" + TituloTrim + ".txt";

                    // Escritura en el (.txt) 
                    using (StreamWriter writer = new StreamWriter(direccionOrigen))
                    {
                        writer.WriteLine("Titulo: " + TituloTrim);
                        writer.WriteLine("Contenido: " + NotaTrim);
                    }

                    errorTitulo.Clear();
                    errorNota.Clear();

                    MessageBox.Show("Archivo creado y guardado correctamente", "¡Archivo de texto generado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!tituloVerified) // Si antes de crear el archivo de texto no hay titulo entonces no se podrá crear el archivo de texto y genera el error siguiente
                    {
                        errorTitulo.SetError(txtTitulo, "El campo no puede estar vacío");
                        errorNota.Clear();
                    }
                    else if (!notaVerified) // Si antes de crear el archivo de texto no hay contenido entonces no se podrá crear el archivo de texto y genera el error siguiente
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
            else
            {

            }

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
            // Hover del textbox
            if (txtTitulo.Text == "")
            {
                tituloVerified = false;
                txtTitulo.Text = "Título";
                txtTitulo.ForeColor = Color.Silver;
            }
            // Validacion de titulo con contenido
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
            // Hover del textbox
            if (rtxtNota.Text == "")
            {
                notaVerified = false;
                rtxtNota.Text = "Escribe una nota";
                rtxtNota.ForeColor = Color.Silver;
            }
            // Validacion de titulo con contenido
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
