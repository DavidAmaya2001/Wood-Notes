using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Wood_Notes
{
    public partial class Splash : Form
    {
        // Configuraciones de Drawing para bordes redondos y carga de progressBar

        [DllImport("Gdi32.dll",EntryPoint = "CreateRoundRectRgn")]

        public static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );



        public Splash()
        {
            InitializeComponent();
            // Creacion de Form con bordes redondos
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            // Asignación de valor a 0% de la progressBar
            progressBar.Value = 0;
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        // Timer para cambiar el label de la progress bar y aumentar el % 
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Aumentador de %
            progressBar.Value += 1;
            progressBar.Text = progressBar.Value.ToString() + "%";

            // Comprueba que al llegar al 100 el timer se detenga y de paso al Form de Login
            if(progressBar.Value == 100)
            {
                timer1.Enabled = false;
                
                // Aqui se modificará por el Login Form --------------------------------------
                frmLogin formChange = new frmLogin();
                formChange.Show();
                this.Hide();
            }    
        }
    }
}
