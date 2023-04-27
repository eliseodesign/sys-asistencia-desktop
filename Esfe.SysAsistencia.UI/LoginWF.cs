using DataEdit;
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
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            var cordinador = UsuariosDefecto.Cordinador;

            if (
                txtUserName.Text == cordinador.Usuario &&
                txtUseKey.Text == cordinador.Contrasenia
                )
            {
                State.TotalAccess = true;
                Panels.SustituirPanel(_panelGeneral, new AplicationWF(_panelGeneral));
            }
            else
            {
                MsgBox msg = new MsgBox("onlyerror", "Usuario y/o contraseña incorrectos");
                msg.ShowDialog();
                txtUseKey.Clear(); txtUserName.Clear();
            }
               
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
                MsgBox msg = new MsgBox("filled", "Se ha iniciado sesión como Docente");
                msg.ShowDialog();
                Panels.SustituirPanel(_panelGeneral, new AplicationWF(_panelGeneral)); 
            }
            else
            {
                MsgBox msg = new MsgBox("onlyerror", "No se pudo iniciar como Docente");
                msg.ShowDialog();


            }
        }
    }
}
