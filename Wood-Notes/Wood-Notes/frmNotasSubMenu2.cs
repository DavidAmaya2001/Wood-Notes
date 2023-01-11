using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            /*txtTitulo.Text = Data.TituloNota;
            rtxtNota.Text = Data.ContenidoNota;
            dtpNewDate.Value = Convert.ToDateTime(Data.FechaNota);*/
        }

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
            if (txtTitulo.Text == "Título")
            {
                txtTitulo.Text = "";
                txtTitulo.ForeColor = Color.Black;
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
            if (rtxtNota.Text == "Escribe una nota")
            {
                rtxtNota.Text = "";
                rtxtNota.ForeColor = Color.Black;
            }
        }

        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            conexion.EliminarDato(Convert.ToInt32(txtId.Text));
            conexion.CerrarConexion();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dtpNewDate.Value = DateTime.Now;
            conexion.AbrirConexion();
            conexion.ModificarDato(Convert.ToInt32(txtId.Text), txtTitulo.Text, rtxtNota.Text, dtpNewDate.Text);
            conexion.CerrarConexion();
        }
    }
}
