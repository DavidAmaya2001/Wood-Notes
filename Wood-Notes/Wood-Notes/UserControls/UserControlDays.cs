using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wood_Notes.Calendar_SubForm;

namespace Wood_Notes.UserControls
{
    public partial class UserControlDays : UserControl
    {

        // Inicializador de variables estaticas para guardado de los eventos
        public static string static_day;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void Days(int numday)
        {
            lblDay.Text = numday.ToString();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lblDay.Text;
            OpenEventMenu();
            
        }

        // Llamado al formulario de eventos
        private frmEventosAdd frmEventos;
        private void OpenEventMenu()
        {
            if (frmEventos == null || frmEventos.IsDisposed)
            {
                frmEventos = new frmEventosAdd();
                frmEventos.FormClosed += frmEventos_FormClosed;
                frmEventos.Show();
            }
            else
            {
                frmEventos.Focus();
            }
        
        }

        // Accion que se ejecutara si el form frmNEventosAdd es cerrado
        private void frmEventos_FormClosed(object sender, FormClosedEventArgs e)
        {
            // condicion que verifica si se agrego o no una nota antes de cerrar el formulario ( aqui ira elevento del btnRefresh)

        }
    }
}
