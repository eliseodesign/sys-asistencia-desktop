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
{/// <summary>
/// Clase que representa el formulario de inicio de sesión de la interfaz de usuario de Esfe.SysAsistencia.
/// </summary>
public partial class LoginWF : Form
{
    /// <summary>
    /// Panel general utilizado para la gestión de los paneles en la interfaz de usuario.
    /// </summary>
    public Panel _panelGeneral;

    /// <summary>
    /// Constructor de la clase LoginWF que recibe un panel como parámetro.
    /// </summary>
    /// <param name="panelGeneral">Panel general utilizado para la gestión de los paneles en la interfaz de usuario.</param>
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
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtUseKey.Clear(); txtUserName.Clear();
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
                MessageBox.Show("No se pudo iniciar como Docente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
