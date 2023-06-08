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

        // Variable id Global a Local
        string idUserNotes = Users.IdUserGlobal;

        bool tituloVerified = false;
        bool notaVerified = false;

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
                tituloVerified = false;
                txtTitulo.Text = "Título";
                txtTitulo.ForeColor = Color.Silver;
            }
            else
            {
                tituloVerified = true;
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
                notaVerified = false;
                rtxtNota.Text = "Escribe una nota";
                rtxtNota.ForeColor = Color.Silver;
            }
            else
            {
                notaVerified = true;
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
                if (tituloVerified && notaVerified)
                {
                    conexion.AbrirConexion();
                    // Modificar para agregar el campo de ultimo cambio aparte del cambo de fecha de creación
                    conexion.ModificarDato(Convert.ToInt32(txtId.Text), txtTitulo.Text, rtxtNota.Text, dtpNewDate.Text, Convert.ToInt32(lblcontador.Text), int.Parse(idUserNotes));
                    conexion.CerrarConexion();
                    tituloVerified = false;
                    notaVerified = false;
                    panelMenu.Visible = false;
                    MessageBox.Show("El cambio se realizó correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            conexion.AbrirConexion();
            
            conexion.CerrarConexion();
        }

        // Boton que ejecuta la funcion de la clase Conexion para poder eliminar los datos de la base de datos
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if(txtTitulo.Text.Length != 0 && rtxtNota.Text.Length != 0)
            {
                tituloVerified = true;
                notaVerified = true;
            }

            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la siguiente nota?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                // Verificación de campos vacios en los textbox
                if (tituloVerified && notaVerified)
                {
                    frmNotas formularionotas = new frmNotas();
                    formularionotas.btnReload.Size = new Size(43, 43);
                    /*string Location = @"D:\Users\Documentos\GitHub TuTioElPollo\Wood-Notes\Wood-Notes\Wood-Notes\Images\ReloadNew.png";
                    byte[] buffereload = File.ReadAllBytes(Location);
                    using (MemoryStream ms = new MemoryStream(buffereload))
                    {
                        formularionotas.btnReload.Image = Image.FromStream(ms);
                    }
                    */
                    formularionotas.btnReload.Image = Wood_Notes.Properties.Resources.updateNotesIcon;


                    conexion.AbrirConexion();
                    conexion.EliminarDato(Convert.ToInt32(txtId.Text), int.Parse(idUserNotes));
                    txtTitulo.Text = "";
                    rtxtNota.Text = "";
                    tituloVerified = false;
                    notaVerified = false;
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

        // Creador de archivos Txt
        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTitulo.ForeColor != Color.Silver && rtxtNota.ForeColor != Color.Silver)
                {

                    // FileName y Filter colocan parametros por defecto a la hora de crear el archivo
                    saveFileDialog1.FileName = "Nueva Nota";
                    saveFileDialog1.Filter = "Archivos | *.txt";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)       // Verificacion de guardado
                    {
                        panelMenu.Visible = false; // Ocultando el panel despues de crear txt

                        if (File.Exists(saveFileDialog1.FileName))             // Verifica si existe para sobreescribirlo
                        {

                            string txtsave = saveFileDialog1.FileName;

                            StreamWriter txtsaving = File.CreateText(txtsave);
                            txtsaving.WriteLine(txtTitulo.Text);
                            txtsaving.WriteLine("----------------------------------------");
                            txtsaving.WriteLine(rtxtNota.Text);
                            txtsaving.Flush();
                            txtsaving.Close();

                            MessageBox.Show("El archivo de texto se ha creado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else                                                    // En caso de no existir este se creara de igual manera 
                        {
                            string txtsave = saveFileDialog1.FileName;

                            StreamWriter txtsaving = File.CreateText(txtsave);
                            txtsaving.WriteLine(txtTitulo.Text);
                            txtsaving.WriteLine("----------------------------------------");
                            txtsaving.WriteLine(rtxtNota.Text);
                            txtsaving.Flush();
                            txtsaving.Close();

                            MessageBox.Show("El archivo de texto se ha creado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    if (txtTitulo.ForeColor == Color.Silver)                                    // Verificacion de campos vacios
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
            catch (Exception)          // En caso de algun error
            {
                MessageBox.Show("Ocurrio un error al guardar");
            }

            
        }

        // Boton que abre el formulario de detalles
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            // Traspaso de información de la nota (en base de datos) al form Detalles
            int IdNota = int.Parse(txtId.Text);
            int idUsers = int.Parse(idUserNotes);

            // Apertura de la conexión, Consulta de los detalles de la nota a la base de datos y cierre de conexión
            conexion.AbrirConexion();
            conexion.ConsultaDetalles(IdNota, idUsers);
            conexion.CerrarConexion();

            // Traspaso de todos los datos a los componentes del form frmDetalles

            // Variables globales de notas a Local
            int idNota = Conexion.idNota;
            string tituloNota = Conexion.tituloNota;
            string fechaNota = Conexion.fecha;
            string modificacionNota = Conexion.modificacion;
            string caracteresNota = Conexion.caracteres;
            string pesoNota = Conexion.peso;

            // moviendo datos a controladores label
            formulariodetalles.txtId.Text = idNota.ToString();
            formulariodetalles.txtTitulo.Text = tituloNota;
            formulariodetalles.txtCreacion.Text = fechaNota;
            formulariodetalles.txtModificacion.Text = modificacionNota;
            formulariodetalles.txtCaracteres.Text = caracteresNota;
            formulariodetalles.txtPeso.Text = pesoNota;



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
