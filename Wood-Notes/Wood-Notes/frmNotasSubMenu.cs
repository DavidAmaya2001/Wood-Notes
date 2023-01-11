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
    public partial class frmNotasSubMenu : Form
    {

        // Estableciendo conexion y ajustando parametros de los controladores
        Conexion conexion = new Conexion();
        public frmNotasSubMenu()
        {
            InitializeComponent();
            conexion.AbrirConexion();
            dtpNewDate.Format = DateTimePickerFormat.Custom; // Modificando formato de DateTimePicker
            dtpNewDate.CustomFormat = "yyyy/MM/dd";
        }

        #region Agregar Nota

        // Agregado de nota
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verificacion de campos vacios de una nueva nota
            if(txtTitulo.ForeColor!=Color.Silver && rtxtNota.ForeColor != Color.Silver)
            {
                conexion.InsertarNotas(txtTitulo.Text, rtxtNota.Text, dtpNewDate.Text);
                txtTitulo.Text = "";
                rtxtNota.Text = "";
                dtpNewDate.Value = DateTime.Now;
            }
            else
            {
                if (txtTitulo.ForeColor == Color.Silver)
                {
                    errorTitulo.SetError(txtTitulo, "El campo no puede estar vacío");
                    errorNota.Clear();
                }
                else if(rtxtNota.ForeColor == Color.Silver)
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
        #endregion

        #region Cierre de Ventana
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region PlaceHolders de los textbox

        // PlaceHolder de textbox Titulo
        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "Título")
            {
                txtTitulo.Text = "";
                txtTitulo.ForeColor = Color.Black;
            }
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                txtTitulo.Text = "Título";
                txtTitulo.ForeColor = Color.Silver;
            }
        }

        // PlaceHolder de textbox Nota
        private void rtxtNota_Enter(object sender, EventArgs e)
        {
            if (rtxtNota.Text == "Escribe una nota")
            {
                rtxtNota.Text = "";
                rtxtNota.ForeColor = Color.Black;
            }
        }

        private void rtxtNota_Leave(object sender, EventArgs e)
        {
            if (rtxtNota.Text == "")
            {
                rtxtNota.Text = "Escribe una nota";
                rtxtNota.ForeColor = Color.Silver;
            }
        }
        #endregion


    }
}
