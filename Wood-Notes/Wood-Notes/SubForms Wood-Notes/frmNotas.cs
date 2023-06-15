using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using Wood_Notes.Models;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Versioning;
using System.Globalization;

namespace Wood_Notes
{
    public partial class frmNotas : Form
    {
        // Variable de Id global a local
        string idUserNotes = Users.IdUserGlobal;

        public Timer _timer;

        public frmNotas()
        {
            // Funcion de cargado del formulario frmNotas
            InitializeComponent();


            #region Llenado de Datos del DataGridView

            // Asignacion de un objeto tipo DataTable para la extracción de los datos que se hace por la clase de Conexion
            DataTable Tabla = conexion.ConsultaNotas(int.Parse(idUserNotes));
            dgvContenedor.DataSource = Tabla;

            //Generador del diseño y visibilidad de las columnas en el DataGridView

              //dgvContenedor.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Columna idNota
            dgvContenedor.Columns[0].Width = 100;
            dgvContenedor.Columns[0].Visible = false;

            // Columna Titulo
            dgvContenedor.Columns[1].Width = 650;
            dgvContenedor.Columns[1].Visible = true;

            // Columna contenido
            dgvContenedor.Columns[2].Width = 600;
            dgvContenedor.Columns[2].Visible = false;

            // Columna fecha
            dgvContenedor.Columns[3].Width = 10;
            dgvContenedor.Columns[3].Visible = false;

            // Columna modificacion
            dgvContenedor.Columns[4].Width = 195;
            dgvContenedor.Columns[4].Visible = true;

            // Columna caracteres
            dgvContenedor.Columns[5].Visible = false;

            // Columna peso
            dgvContenedor.Columns[6].Visible = false;

            // Columna idUsers
            dgvContenedor.Columns[7].Visible = false;

            #endregion

            #region Agregado de columnas Edit y Delete
            // Agregado de columna de EDIT a cada Nota
            DataGridViewImageColumn columna_edit = new DataGridViewImageColumn();
            columna_edit.Name = "Editar";
            columna_edit.HeaderText = "Editar";
            columna_edit.Width = 102;
            columna_edit.DisplayIndex = 7;
            columna_edit.Image = Wood_Notes.Properties.Resources.editIcon;

            dgvContenedor.Columns.Add(columna_edit);
            dgvContenedor.Columns["Editar"].DisplayIndex = 7;

            //Codigo de importación de imagen inservible

            /*string ruta = @"D:\Users\Documentos\GitHub TuTioElPollo\Wood-Notes\Wood-Notes\Wood-Notes\Images\editico.png";
            byte[] bufferedit = File.ReadAllBytes(ruta);
            using (MemoryStream ms = new MemoryStream(bufferedit))
            {
                columna_edit.Image = Image.FromStream(ms);
            }*/


            // Agregado de columna de DELETE a cada Nota
            DataGridViewImageColumn columna_delete = new DataGridViewImageColumn();
            columna_delete.Name = "Eliminar";
            columna_delete.HeaderText = "Eliminar";
            columna_delete.Width = 102;
            columna_delete.DisplayIndex = 8;
            columna_delete.Image = Wood_Notes.Properties.Resources.trashIcon;

            dgvContenedor.Columns.Add(columna_delete);
            dgvContenedor.Columns["Eliminar"].DisplayIndex = 8;


            // Codigo de importación de imagen inservible

            /*string ruta2 = @"D:\Users\Documentos\GitHub TuTioElPollo\Wood-Notes\Wood-Notes\Wood-Notes\Images\trashico.png";
            byte[] bufferdelete = File.ReadAllBytes(ruta2);
            using(MemoryStream ms = new MemoryStream(bufferdelete))
            {
                columna_delete.Image = Image.FromStream(ms);
            }*/
            #endregion
        }

        // Objeto con referencia a la clase Conexion que contiene todo el funcionamiento y llamados a SQLServer
        Conexion conexion = new Conexion();

        #region Actualizador default Reload 
        // Actualizador de imagen de Reload ante cambios en frmNotasSubMenu y frmNotasSubMenu2
        public void UpdateReloadButton(Image updatebutton)
        {
            btnReload.Size = new Size(43, 43);
            btnReload.Image = updatebutton;
        }
        #endregion

        #region Botones de Notas
        // Apertura del formulario frmNotasSubMenu
        private frmNotasSubMenu formulario;
        private void OpenSubMenu()
        {
            if(formulario == null || formulario.IsDisposed)
            {
                formulario = new frmNotasSubMenu();
                formulario.FormClosed += formulario_FormClosed;
                formulario.Show();
            }
        }
        // Accion que se ejecutara si el form frmNotasSubMenu es cerrado
        private void formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            // condicion que verifica si se agrego o no una nota antes de cerrar el formulario
            if (formulario.updateIcon)
            {
                btnReload.Image = Wood_Notes.Properties.Resources.updateNotesIcon;
                formulario.updateIcon = false;
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            OpenSubMenu();
        }

        // Funcion de recarga manual del DataGridView teniendo en cuenta si este contiene nuevos datos o algo en la barra de busqueda de notas
        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        public void Reload()
        {
            if (txtSearch.ForeColor == Color.Silver)         // Si no hay busqueda en el controlador de texto entonces solo hará una consulta de todos los datos segun id
            {
                int idUsers = int.Parse(idUserNotes);
                DataTable Tabla = conexion.ConsultaNotas(idUsers);
                dgvContenedor.DataSource = Tabla;

            }
            else if (txtSearch.ForeColor == Color.Black)     // si el controlador posee texto entonces se realizará una consulta de coincidencia de los datos segun id
            {
                if (txtSearch.Text == "")                    // Si el campo esta con contenido pero vacio se le asigna el placeholder y carga los datos
                {
                    txtSearch.Text = "Buscar por título";
                    txtSearch.ForeColor = Color.Silver;
                    int idUsers = int.Parse(idUserNotes);
                    DataTable Tabla = conexion.ConsultaNotas(idUsers);
                    dgvContenedor.DataSource = Tabla;
                    dgvContenedor.Focus();

                }
                else                                         // Si no esta vacio se busca los datos y luego se filtra segun lo que contenga el textbox
                {
                    /*DataTable Tabla = conexion.BusquedaNotas(txtSearch.Text);
                    dgvContenedor.DataSource = Tabla;*/
                    int idUsers = int.Parse(idUserNotes);
                    DataTable Tabla = conexion.ConsultaNotas(idUsers);
                    dgvContenedor.DataSource = Tabla;         // Carga los datos con nuevas actualizaciones si es que las hay
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvContenedor.DataSource;
                    bs.Filter = "Titulo Like '%" + txtSearch.Text + "%'";    // Filtra el dato segun lo que este en el buscador
                    dgvContenedor.DataSource = bs;
                }
            }
            // Reconfigurando tamaño e imagen por defecto del boton reload en caso de cambio

            /*string Location = @"D:\Users\Documentos\GitHub TuTioElPollo\Wood-Notes\Wood-Notes\Wood-Notes\Images\Reload.png";
            byte[] bufferdefaultreload = File.ReadAllBytes(Location);
            using (MemoryStream ms = new MemoryStream(bufferdefaultreload))
            {
                btnReload.Image = Image.FromStream(ms);
            }*/

            btnReload.Image = Wood_Notes.Properties.Resources.refreshNotesIcon;
            btnReload.Size = new Size(39, 39);
        }
        #endregion

        #region UI y funciones extras del buscador

        // Asignacion del placeholder del buscador (Momento de entrar al controlador)
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.Silver) // Si el contenido del controlador esta con el placeholder activo, este desaparecerá para que el usuario escriba
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        // Asignacion del placeholder del buscador (Momento de salir del controlador)
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.Black && txtSearch.Text == "") // Si el contenido del controlador se encuentra vacio entonces se le asigna el placeholder
            {
                txtSearch.Text = "Buscar por título";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        // Impedir el uso del Enter
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) // Funcion que deshabilita el uso del enter en el controlador de busqueda
            {
                e.Handled = true;
                return;
            }
        }

        // Footer button
        private bool openFooter = false;
        private void btnFooterShow_Click(object sender, EventArgs e)
        {
            // Condicion que verifica si se encuentra abierto o cerrado el footer
            if (!openFooter)
            {
                openFooter = true;
                btnFooterShow.Text = "˅";
                btnFooterShow.Location = new Point(499, 547);
                panelFooter.Size = new Size(1058, 32);
            }
            else
            {
                openFooter = false;
                btnFooterShow.Text = "^";
                btnFooterShow.Location = new Point(499, 569);
                panelFooter.Size = new Size(1058, 10);
            }

        }

        #endregion

        #region Buscador Automatico y Dinamico
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            /*string Variable = txtSearch.Text;
            WoodNotesDBEntities1 objetoDataBase = new WoodNotesDBEntities1();

            var consulta = (from usernotes in objetoDataBase.UserNotes
                            where usernotes.Titulo.Contains(Variable)
                            select new
                            {
                                usernotes.Titulo,
                                usernotes.Modificacion,

                            }).ToList();

            dgvContenedor.DataSource = consulta;
            dgvContenedor.Columns["Titulo"].DisplayIndex = 0;
            dgvContenedor.Columns["Modificacion"].DisplayIndex = 1;
            */

            BindingSource bs = new BindingSource();
            bs.DataSource = dgvContenedor.DataSource;
            bs.Filter = "Titulo Like '%" + txtSearch.Text + "%'";  // Encapsulamiento del DataSource para el filtrado de los datos
            dgvContenedor.DataSource = bs;                         // Reasignación de los datos filtrados que se mostraran en el datagridview

        }

        #endregion

        #region Compartido de datos con el formulario de edición y eliminación

        private frmNotasSubMenu2 formulario2;

        LoadData Load = new LoadData();

        private void dgvContenedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Toma de datos de la celda seleccionada del datagridview y compartiendolas al formulario frmNotasSubMenu2 donde se realizarán los cambios */

            // Seleccion de la celda de edición para el traspaso de los datos de la nota segun idNota
            if (e.RowIndex >= 0 && dgvContenedor.Columns[e.ColumnIndex].Name=="Editar")
            {
                // Guardado de datos en variables para almacenarlos en la clase Load
                    int idNota = Convert.ToInt32(dgvContenedor.SelectedRows[0].Cells["IdNota"].Value);
                    string Titulo = dgvContenedor.SelectedRows[0].Cells["Titulo"].Value.ToString();
                    string Contenido = dgvContenedor.SelectedRows[0].Cells["Contenido"].Value.ToString();
                    string Creacion = dgvContenedor.SelectedRows[0].Cells["Fecha"].Value.ToString();
                    string Fecha = dgvContenedor.SelectedRows[0].Cells["Modificacion"].Value.ToString();
                    int Caracteres = Convert.ToInt32(dgvContenedor.SelectedRows[0].Cells["Caracteres"].Value);



                    //MessageBox.Show(idNota + " " + Titulo + " " + Contenido + "" + Fecha);

                    // Guardado de datos en la clase Load

                    Load.setIdNota(idNota);
                    Load.setTituloNota(Titulo);
                    Load.setContenidoNota(Contenido);
                    Load.setFechaNota(Creacion);
                    Load.setFechaModificacion(Fecha);
                    Load.setCaracteres(Caracteres);

                // Abriendo el form frmSubMenu2
                OpenSubMenu2();


            }

            // Selección de la celda de eliminacion para eliminar los datos de la nota segun idNota de la base de datos
            else if (e.RowIndex >= 0 && dgvContenedor.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                // Cuadro de confirmación
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la siguiente nota?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                // Caso que se desea eliminar:
                if (resultado == DialogResult.OK)
                {
                    // Obtención del idNota
                    int idNota = Convert.ToInt32(dgvContenedor.SelectedRows[0].Cells["IdNota"].Value);

                    // Apertura de la conexión con SQLServer
                    conexion.AbrirConexion();

                    // Funcion de la clase Conexion para la eliminación de la nota segun idNota
                    conexion.EliminarDato(idNota, int.Parse(idUserNotes));

                    // Cierre de la conexión con SqlServer
                    conexion.CerrarConexion();
                    MessageBox.Show("La nota se ha eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Redimensionando Reload por cambio realizado
                    UpdateReloadButton(Wood_Notes.Properties.Resources.updateNotesIcon);
                    /*string Location = @"D:\Users\Documentos\GitHub TuTioElPollo\Wood-Notes\Wood-Notes\Wood-Notes\Images\ReloadNew.png";
                    byte[] bufferdefaultreload = File.ReadAllBytes(Location);
                    using (MemoryStream ms = new MemoryStream(bufferdefaultreload))
                    {
                        btnReload.Image = Image.FromStream(ms);
                    }*/

                }
            }
            dgvContenedor.Visible = true;
        }

        private void OpenSubMenu2()
        {
            if (formulario2 == null || formulario2.IsDisposed)
            {
                formulario2 = new frmNotasSubMenu2();

                // Moviendo a segundo formulario los datos para usarse tanto para modificar, eliminar o ver detalles
                formulario2.txtId.Text = Convert.ToString(Load.getIdNota());
                formulario2.txtCreacion.Text = Load.getFechaNota();
                formulario2.txtMod.Text = Load.getFechaModificacion();
                formulario2.txtTitulo.Text = Load.getTituloNota();
                formulario2.rtxtNota.Text = Load.getContenidoNota();
                formulario2.dtpNewDate.Value = Convert.ToDateTime(Load.getFechaModificacion());
                formulario2.lblcontador.Text = Load.getCaracteres().ToString();

                formulario2.FormClosed += formulario_FormClosed2;
                formulario2.Show();
            }
            else
            {
                // Agregar MessageBox avisando que hay otro form abierto
                formulario2.Focus();
            }
        }
        // Accion que se ejecutara si el form frmNotasSubMenu es cerrado
        private void formulario_FormClosed2(object sender, FormClosedEventArgs e)
        {
            // condicion que verifica si se agrego o no una nota antes de cerrar el formulario
            if (formulario2.updateIcon)
            {
                btnReload.Image = Wood_Notes.Properties.Resources.updateNotesIcon;
                formulario2.updateIcon = false;
            }
        }

        #endregion

        #region Apariencia y diseño del DataGridView

        //Limitador de emergencia al click del Header de las columnas
        private void dgvContenedor_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            return;
        }

        // Hover de las filas al sobrepasar el mouse sobre las celdas
        private void dgvContenedor_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.ForeColor = Color.White;
            style.BackColor = Color.FromArgb(50, 95, 255);
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cambios unicamente aplicables si son los Row que contiene los datos y no los Headers
            if (e.RowIndex > -1)
            {
                dgvContenedor.Rows[e.RowIndex].DefaultCellStyle = style;
            }
        }

        // Regreso al color por defecto luego de ejecutar el evento del MouseMove (Hover)
        private void dgvContenedor_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            style2.ForeColor = Color.White;
            style2.BackColor = Color.RoyalBlue;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cambios unicamente aplicables si son los Row que contiene los datos y no los Headers
            if (e.RowIndex > -1)
            {
                dgvContenedor.Rows[e.RowIndex].DefaultCellStyle = style2;
            }
        }
        #endregion


    }
}
