using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wood_Notes.UserControls;

namespace Wood_Notes
{
    public partial class frmCalendario : Form
    {

        // Inicializador de variables recopilatorias de mes y año
        int month, year;

        // Inicializador de variables estaticas para guardado de los eventos
        public static int  static_month, static_year;

        // Variables booleanas de clics en Previous y Next
        bool changeMonth;

        public frmCalendario()
        {
            InitializeComponent();
        }

        // Inicializador del formulario frmCalendario
        private void frmCalendario_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        #region Display de mes actual
        private void displayDays()
        {
            // Obtención de la fecha actual
            DateTime CurrentTime = DateTime.Now;
            month = CurrentTime.Month;
            year = CurrentTime.Year;

            // Guardado de mes y año en las variables estaticas para la funcion de Eventos
            static_month = month;
            static_year = year;

            // Obtencion del Mes y Año para el label
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthAndYear.Text = monthName.ToUpper() + " " + year;

            // Obtención del primer día del mes
            DateTime StartMonth = new DateTime(year, month, 1);

            // Obtener la cantidad de días que dispone el mes
            int days = DateTime.DaysInMonth(year, month);

            // Convierte el StartMonth a entero
            int daysOfTheWeek = Convert.ToInt32(StartMonth.DayOfWeek.ToString("d")) + 1;

            // Creacion del UserControl con CalendarDayPanel (funcion que permite añadir al panel los días del mes pasado para que concuerde el inicio del mes con su día)
            for(int i = 1; i < daysOfTheWeek; i++)
            {
                CalendarDayPanel CalendarDP = new CalendarDayPanel();
                flpCalendar.Controls.Add(CalendarDP);
            }

            // Creación del UserControl para los dias (funcion que permite añadir los dias del mes actual en el que se encuentra el usuario)
            for (int i = 1; i <= days; i++)
            {
                UserControlDays DaysUC = new UserControlDays();
                DaysUC.Days(i);
                flpCalendar.Controls.Add(DaysUC);
            }
        }
        #endregion

        #region Display del Siguiente o Anterior Mes

        // Funcion que actualiza el mes segun el boton de previous o next seleccionado
        private void ChangeMonthButton()
        {
            // Limpieza del contenedor flpCalendar
            flpCalendar.Controls.Clear();

            // Variable de incremento o decremento para el cambio de mes y año
            if (changeMonth)
            {
                // Si el mes del display es 12 y se cambia al siguiente este cambiara al siguiente año y empezando en Enero
                if(month == 12)
                {
                    year++;
                    month = 1;
                }
                // Si no el aumento de mes se hará normalmente
                else
                {
                    month++;
                }
            }
            else if(!changeMonth)
            {
                // Si el mes del display es 1 y se cambia al mes anterior este cambiara al año pasado y empezara con Diciembre
                if(month == 1)
                {
                    year--;
                    month = 12;
                }
                // Si no la reducción de mes se hará normalmente
                else
                {
                    month--;
                }
            }

            // Guardado de mes y año en las variables estaticas para la funcion de Eventos
            static_month = month;
            static_year = year;

            // Obtencion del Mes y Año para el label
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthAndYear.Text = monthName.ToUpper() + " " + year;

            // Obtención del primer día del mes
            DateTime StartMonth = new DateTime(year, month, 1);

            // Obtener la cantidad de días que dispone el mes
            int days = DateTime.DaysInMonth(year, month);

            // Convierte el StartMonth a entero
            int daysOfTheWeek = Convert.ToInt32(StartMonth.DayOfWeek.ToString("d")) + 1;

            // Creacion del UserControl con CalendarDayPanel (funcion que permite añadir al panel los días del mes pasado para que concuerde el inicio del mes con su día)
            for (int i = 1; i < daysOfTheWeek; i++)
            {
                CalendarDayPanel CalendarDP = new CalendarDayPanel();
                flpCalendar.Controls.Add(CalendarDP);
            }

            // Creación del UserControl para los dias (funcion que permite añadir los dias del mes actual en el que se encuentra el usuario)
            for (int i = 1; i <= days; i++)
            {
                UserControlDays DaysUC = new UserControlDays();
                DaysUC.Days(i);
                flpCalendar.Controls.Add(DaysUC);
            }
        }

        // Boton para regresar al mes anterior
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            changeMonth = false;
            ChangeMonthButton();
        }

        // Boton para avanzar al mes siguiente
        private void btnNext_Click(object sender, EventArgs e)
        {
            changeMonth = true;
            ChangeMonthButton();
        }
        #endregion
    }
}
