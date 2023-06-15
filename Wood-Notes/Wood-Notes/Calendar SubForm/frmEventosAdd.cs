using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wood_Notes.UserControls;

namespace Wood_Notes.Calendar_SubForm
{
    public partial class frmEventosAdd : Form
    {
        public frmEventosAdd()
        {
            InitializeComponent();
        }

        // Invocador de los UserControls y forms para la transferencia de las variables estaticas
        string day = UserControlDays.static_day;
        int month = frmCalendario.static_month;
        int year = frmCalendario.static_year;

        // Variable de guardado de fecha completa, evento y idUser
        string evento;
        // Variable de Id global a local
        string idUserEvents = Users.IdUserGlobal;

        // Accediendo a la conexion con SQL por medio de la clase ConexionEvents
        ConexionEvents conexion = new ConexionEvents();

        // Variable DateTime
        DateTime fechaConvert;

        private void frmEventosAdd_Load(object sender, EventArgs e)
        {
            dtpDateSelected.Format = DateTimePickerFormat.Custom; // Modificando formato de DateTimePicker
            dtpDateSelected.CustomFormat = "yyyy/MM/dd";

            // Para el precargado del form debemos  pasar las variables estaticas 
            string FechaCalendar = year + "-" + month + "-" + day;

            if(DateTime.TryParse(FechaCalendar, out fechaConvert))
            {
                dtpDateSelected.Value = fechaConvert;
            }
        }

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            evento = txtEventCalendar.Text;
            conexion.AbrirConexion();
            conexion.SaveEvents(evento, fechaConvert, int.Parse(idUserEvents));
            conexion.CerrarConexion();
        }
    }
}
