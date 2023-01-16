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
            txtId.Visible = false;
            /*txtTitulo.Text = Data.TituloNota;
            rtxtNota.Text = Data.ContenidoNota;
            dtpNewDate.Value = Convert.ToDateTime(Data.FechaNota);*/
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
            dtpNewDate.Value = DateTime.Now;
            conexion.AbrirConexion();
            conexion.ModificarDato(Convert.ToInt32(formulariodetalles.txtId.Text), txtTitulo.Text, rtxtNota.Text, dtpNewDate.Text);
            conexion.CerrarConexion();
        }

        // Boton que ejecuta la funcion de la clase Conexion para poder eliminar los datos de la base de datos
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            conexion.EliminarDato(Convert.ToInt32(formulariodetalles.txtId.Text));
            conexion.CerrarConexion();
        }

        // Boton que abre el formulario de detalles
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            // Paso de datos hacia el formulario detalles
            formulariodetalles.txtId.Text = txtId.Text;

            // Abriendo formulario detalles
            panelMenu.Visible = false;
            formulariodetalles.ShowDialog();
        }
        #endregion


    }
}
