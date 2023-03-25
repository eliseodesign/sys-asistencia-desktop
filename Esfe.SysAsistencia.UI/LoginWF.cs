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
using Esfe.SysAsistencia.EN.Static;

namespace Esfe.SysAsistencia.UI
{
    public partial class LoginWF : Form
    {
        public LoginWF()
        {
            InitializeComponent();
            //txtUseKey.UseSystemPasswordChar = true; // volverlo tipo Passwod
            txtUseKey.PasswordChar = '*';
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        { // cerrar window
            Application.Exit();
        }

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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            var cordinador = UsuariosDefecto.Cordinador;



            if (txtUserName.Text == cordinador.Usuario && txtUseKey.Text == cordinador.Contrasenia)
            {

                AgregarPanel(new EstudianteWF());
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUseKey.Text = ""; txtUserName.Text = "";
            }

        }

        private void AgregarPanel(Object formHijo)
        {
            if (this.panelGeneral.Controls.Count > 0)
            {
                MessageBox.Show("si");
                this.panelGeneral.Controls.Clear();
                Form fH = formHijo as Form;
                fH.TopLevel = false;
                fH.Dock = DockStyle.Fill;
                this.panelGeneral.Controls.Add(fH);
                this.panelGeneral.Tag = fH;
                fH.Show();
            }

        }

    }
}
