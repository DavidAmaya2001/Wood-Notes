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

namespace Wood_Notes
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
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
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form formulario = new frmNotasSubMenu();
            formulario.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.Silver)
            {
                DataTable Tabla = conexion.ConsultaNotas();
                dgvContenedor.DataSource = Tabla;

            }
            else
            {
                DataTable Tabla = conexion.BusquedaNotas(txtSearch.Text);
                dgvContenedor.DataSource = Tabla;
            }
        }
        #endregion

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Buscar por título")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Buscar por título";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                DataTable Tabla = conexion.BusquedaNotas(txtSearch.Text);
                dgvContenedor.DataSource = Tabla;
                txtSearch.Text = "Buscar por título";
                txtSearch.ForeColor = Color.Silver;
            }
        }
    }
}
