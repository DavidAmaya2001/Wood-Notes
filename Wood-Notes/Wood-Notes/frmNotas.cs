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
        public frmNotas()
        {
            
            // Carga de Datos al form de Notas
            InitializeComponent();
            DataTable Tabla = conexion.ConsultaNotas();
            dgvContenedor.DataSource = Tabla;

            //dgvContenedor.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContenedor.Columns[0].Width = 100;
            dgvContenedor.Columns[0].Visible = false;
            //dgvContenedor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContenedor.Columns[1].Width = 400;
            //dgvContenedor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContenedor.Columns[2].Width = 605;
            dgvContenedor.Columns[2].Visible = false;
            //dgvContenedor.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContenedor.Columns[3].Width = 10;
            dgvContenedor.Columns[3].Visible = false;
            //dgvContenedor.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContenedor.Columns[4].Width = 136;
            dgvContenedor.Columns[5].Visible = false;
            dgvContenedor.Columns[6].Visible = false;

            
            // Agregado de columna de edit
            DataGridViewImageColumn columna_edit = new DataGridViewImageColumn();
            columna_edit.Name = "Editar";
            columna_edit.HeaderText = "Editar";
            columna_edit.Width = 80;
            columna_edit.DisplayIndex = 7;
            string ruta = @"D:\Users\Documentos\GitHub TuTioElPollo\Wood-Notes\Wood-Notes\Wood-Notes\Images\editico.png";
            byte[] bufferedit = File.ReadAllBytes(ruta);
            using (MemoryStream ms = new MemoryStream(bufferedit))
            {
                columna_edit.Image = Image.FromStream(ms);
            }

            dgvContenedor.Columns.Add(columna_edit);
            dgvContenedor.Columns["Editar"].DisplayIndex = 7;

            // Agregado de columna de delete
            DataGridViewImageColumn columna_delete = new DataGridViewImageColumn();
            columna_delete.Name = "Eliminar";
            columna_delete.HeaderText = "Eliminar";
            columna_delete.Width = 80;
            columna_delete.DisplayIndex = 8;
            string ruta2 = @"D:\Users\Documentos\GitHub TuTioElPollo\Wood-Notes\Wood-Notes\Wood-Notes\Images\trashico.png";
            byte[] bufferdelete = File.ReadAllBytes(ruta2);
            using(MemoryStream ms = new MemoryStream(bufferdelete))
            {
                columna_delete.Image = Image.FromStream(ms);
            }

            dgvContenedor.Columns.Add(columna_delete);
            dgvContenedor.Columns["Eliminar"].DisplayIndex = 8;

            


            // Diseño por defecto del DataGridView
            DataGridViewCellStyle stylegeneral = new DataGridViewCellStyle();
            stylegeneral.ForeColor = Color.White;
            stylegeneral.BackColor = Color.CornflowerBlue;
            stylegeneral.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvContenedor.Rows[0].DefaultCellStyle = stylegeneral;
            

        }

        Conexion conexion = new Conexion();

        #region Botones de Notas

        // Abriendo formulario para agregar
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form formulario = new frmNotasSubMenu();
            formulario.ShowDialog();
        }

        // Recarga Manual de formulario
        private void btnReload_Click(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.Silver)
            {
                DataTable Tabla = conexion.ConsultaNotas();
                dgvContenedor.DataSource = Tabla;

            }
            else if (txtSearch.ForeColor == Color.Black)
            {
                if (txtSearch.Text == "")
                {
                    DataTable Tabla = conexion.ConsultaNotas();
                    dgvContenedor.DataSource = Tabla;
                }
                else
                {
                    DataTable Tabla = conexion.BusquedaNotas(txtSearch.Text);
                    dgvContenedor.DataSource = Tabla;
                    dgvContenedor.Focus();
                    txtSearch.Text = "Buscar por título";
                    txtSearch.ForeColor = Color.Silver;
                }
            }
        }
        #endregion

        #region Funciones del Buscador

        // Placeholder del buscador
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.Silver)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        // Placeholder del buscador
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.Black)
            {
                txtSearch.Text = "Buscar por título";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        // Impedir el uso del Enter
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                return;
            }
        }

        #endregion

        #region Buscador Automatico y Dinamico
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string Variable = txtSearch.Text;
            WoodNotesDBEntities1 objetoDataBase = new WoodNotesDBEntities1();

            var consulta = (from usernotes in objetoDataBase.UserNotes
                            where usernotes.Titulo.Contains(Variable)
                            select new
                            {
                                usernotes.IdNota,
                                usernotes.Titulo,
                                usernotes.Contenido,
                                usernotes.Modificacion
                            }).ToList();

            dgvContenedor.DataSource = consulta;
        }

        #endregion

        #region Compartido de datos con el formulario de edición y eliminación
        private void dgvContenedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Toma de datos de la celda seleccionada del datagridview y compartiendolas al formulario secundario
               donde se realizarán los cambios */
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
                    LoadData Load = new LoadData();
                    Load.setIdNota(idNota);
                    Load.setTituloNota(Titulo);
                    Load.setContenidoNota(Contenido);
                    Load.setFechaNota(Creacion);
                    Load.setFechaModificacion(Fecha);
                    Load.setCaracteres(Caracteres);

                    frmNotasSubMenu2 formulario = new frmNotasSubMenu2();
                    frmDetalles formulariodetalles = new frmDetalles();

                    // Moviendo a segundo formulario los datos para usarse tanto para modificar, eliminar o ver detalles
                    formulario.txtId.Text = Convert.ToString(Load.getIdNota());
                    formulario.txtCreacion.Text = Load.getFechaNota();
                    formulario.txtMod.Text = Load.getFechaModificacion();
                    formulario.txtTitulo.Text = Load.getTituloNota();
                    formulario.rtxtNota.Text = Load.getContenidoNota();
                    formulario.dtpNewDate.Value = Convert.ToDateTime(Load.getFechaModificacion());
                    formulario.lblcontador.Text = Load.getCaracteres().ToString();
                    formulario.ShowDialog();
            }
            else if (e.RowIndex >= 0 && dgvContenedor.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la siguiente nota?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultado == DialogResult.OK)
                {
                    int idNota = Convert.ToInt32(dgvContenedor.SelectedRows[0].Cells["IdNota"].Value);
                    Conexion conexion = new Conexion();
                    conexion.AbrirConexion();
                    conexion.EliminarDato(idNota);
                    conexion.CerrarConexion();
                }
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
            style.BackColor = Color.RoyalBlue;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;


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
            style2.BackColor = Color.CornflowerBlue;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (e.RowIndex > -1)
            {
                dgvContenedor.Rows[e.RowIndex].DefaultCellStyle = style2;
            }
        }
        #endregion
    }
}
