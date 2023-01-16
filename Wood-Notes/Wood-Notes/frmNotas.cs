using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using Wood_Notes.Models;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dgvContenedor.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContenedor.Columns[0].FillWeight = 30;
            dgvContenedor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContenedor.Columns[1].FillWeight = 80;
            dgvContenedor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContenedor.Columns[2].FillWeight = 150;
            dgvContenedor.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvContenedor.Columns[3].FillWeight = 50;

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
                                usernotes.Fecha
                            }).ToList();

            dgvContenedor.DataSource = consulta;
        }

        #endregion

        #region Compartido de datos con el formulario de edición y eliminación
        private void dgvContenedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Toma de datos de la celda seleccionada del datagridview y compartiendolas al formulario secundario
               donde se realizarán los cambios */ 
            int idNota = Convert.ToInt32(dgvContenedor.SelectedRows[0].Cells[0].Value);
            string Titulo = dgvContenedor.SelectedRows[0].Cells[1].Value.ToString();
            string Contenido = dgvContenedor.SelectedRows[0].Cells[2].Value.ToString();
            string Fecha = dgvContenedor.SelectedRows[0].Cells[3].Value.ToString();

            //MessageBox.Show(idNota + " " + Titulo + " " + Contenido + "" + Fecha);

            LoadData Load = new LoadData();
            Load.setIdNota(idNota);
            Load.setTituloNota(Titulo);
            Load.setContenidoNota(Contenido);
            Load.setFechaNota(Fecha);

            frmNotasSubMenu2 formulario = new frmNotasSubMenu2();
            frmDetalles formulariodetalles = new frmDetalles();
            //MessageBox.Show(" " + Load.IdNota + " " + Load.TituloNota + " " + Load.ContenidoNota);
            //formulario.txtbaboso.Text = dgvContenedor.CurrentRow.Cells[1].Value.ToString();
            formulario.txtId.Text = Convert.ToString(Load.getIdNota());
            formulario.txtTitulo.Text = Load.getTituloNota();
            formulario.rtxtNota.Text = Load.getContenidoNota();
            formulario.dtpNewDate.Value = Convert.ToDateTime(Load.getFechaNota());
            formulario.ShowDialog();
        }
        #endregion
    }
}
