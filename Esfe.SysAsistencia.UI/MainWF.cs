using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // librería para mover ventana 
using Esfe.SysAsistencia.EN.Static;
using Esfe.SysAsistencia.UI.Helpers;


namespace Esfe.SysAsistencia.UI
{
    public partial class MainWF : Form
    {
        public MainWF()
        {

            InitializeComponent();
            //txtUseKey.PasswordChar = '*'; // definir * para ocultar caracteres
            Panels.AgregarPanel(this.panelGeneral, new LoginWF(this.panelGeneral));
        }



        private void CloseWindow_Click(object sender, EventArgs e)
        { // cerrar window
            Application.Exit();
        }


        // - - - - - - - - - - - - - - - - - - - - -  - - -
        // Funcionalidad para asignarle mover window al header 
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
