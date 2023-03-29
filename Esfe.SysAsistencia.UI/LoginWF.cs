using Esfe.SysAsistencia.EN.Static;
using Esfe.SysAsistencia.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esfe.SysAsistencia.UI
{
    public partial class LoginWF : Form
    {
        public Panel _panelGeneral;


        public LoginWF(Panel panelGeneral)
        {
            _panelGeneral = panelGeneral;
            InitializeComponent();
            txtUseKey.Text = "coordinador";
            txtUserName.Text = "coordinador";
            //txtUseKey.PasswordChar = '*'; // definir * para ocultar caracteres
        }


        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            var cordinador = UsuariosDefecto.Cordinador;

            if (
                txtUserName.Text == cordinador.Usuario &&
                txtUseKey.Text == cordinador.Contrasenia
                )
            {
                State.TotalAccess = false;
                Panels.SustituirPanel(_panelGeneral, new AplicationWF(_panelGeneral));
            }
            else
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtUseKey.Clear(); txtUserName.Clear();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void lblLoginDocente_Click(object sender, EventArgs e)
        {
            var verify = new VerificarWF(this);
            verify.ShowDialog();

            
        }

        //Codigo para la verificacion
        public void LoginDocente(bool res)
        {
            if (res)
            {
                MessageBox.Show("Se ha iniciado sesión como Docente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Panels.SustituirPanel(_panelGeneral, new AplicationWF(_panelGeneral));
            }
            else
            {
                MessageBox.Show("Nmms usted no es docente mi loco", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
