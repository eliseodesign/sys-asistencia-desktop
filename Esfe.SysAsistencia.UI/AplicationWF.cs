using Esfe.SysAsistencia.UI.Components;
using Esfe.SysAsistencia.UI.Helpers;
using Microsoft.VisualBasic.Logging;
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
    /// <summary>
    /// Propósito:
    ///    Esta clase representa la interfaz principal de la aplicación de asistencia.Proporciona funcionalidades para manejar los botones de menú, controlar el inicio y cierre de sesión de usuario, y administrar los paneles de la interfaz de usuario.

    ///   Funcionalidades:
    /// Administrar los botones de menú para las diferentes opciones de la aplicación (asistencia, alumnos, docentes, grupos).
    /// Controlar el inicio y cierre de sesión de usuario.
    /// Administrar los paneles de la interfaz de usuario para mostrar diferentes vistas de la aplicación.

    ///  Componentes:
    /// Panel _panelGeneral: Representa el panel principal de la interfaz de usuario.
    /// Button[] buttons_list: Arreglo de botones que almacena los botones de menú para saber cuál ha sido presionado.
    /// BarWF: Control personalizado de barra superior de la aplicación.
    /// HomeWF: Clase de vista para la pantalla de inicio de la aplicación.
    //  DocentesWF: Clase de vista para la pantalla de gestión de docentes.
    /// AlumnosWF: Clase de vista para la pantalla de gestión de alumnos.
    /// AsistenciaWF: Clase de vista para la pantalla de registro de asistencia.
    /// GruposWF: Clase de vista para la pantalla de gestión de grupos.
    /// LoginWF: Clase de vista para la pantalla de inicio de sesión de usuario.


    ///   Métodos:
    /// AplicationWF(Panel panel): Constructor de la clase que recibe un panel como parámetro y lo asigna a la propiedad _panelGeneral.También inicializa los botones de menú y asigna eventos a los mismos.
    /// btnCerrarSesion_Click(object sender, EventArgs e): Manejador del evento de clic en el botón de cerrar sesión.Cierra la sesión del usuario y muestra la pantalla de inicio de sesión.
    /// SetButtonsColors(Button b): Método privado que establece los colores de los botones de menú según cuál esté seleccionado.
    /// UserLoged(): Método privado que configura los privilegios del usuario según si tiene acceso total o no.
    /// btnDocentes_Click(object sender, EventArgs e): Manejador del evento de clic en el botón de docentes. Muestra la vista de gestión de docentes y establece el color del botón correspondiente.
    /// btnAlumnos_Click(object sender, EventArgs e): Manejador del evento de clic en el botón de alumnos. Muestra la vista de gestión de alumnos y establece el color del botón correspondiente.
    /// btnAsistencia_Click(object sender, EventArgs e): Manejador del evento de clic en el botón de asistencia. Muestra la vista de registro de asistencia y establece el color del botón correspondiente.
    /// btnGrupos_Click(object sender, EventArgs e): Manejador del evento de clic en el botón de grupos. Muestra la vista de gestión de grupos y establece el color del botón correspondiente.
    /// lblAsitencia_Click(object sender, EventArgs e): Manejador del evento de clic en el label de asistencia. Muestra la vista de inicio de la aplicación y restablece los colores de los botones de menú.

    /// </summary>

    public partial class AplicationWF : Form
    {
        public Panel _panelGeneral;
        Button[] buttons_list = new Button[4]; //Esta lista almacena los botones de Menu, para saber cual se ha presionado 
        public AplicationWF(Panel panel)
        {
            _panelGeneral = panel;
            InitializeComponent();
            // bar superior 
            Panels.AgregarPanel(panelBar, new BarWF());
            UserLoged();

            buttons_list[0] = btnAsistencia;
            buttons_list[1] = btnAlumnos;
            buttons_list[2] = btnDocentes;
            buttons_list[3] = btnGrupos;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (!MySingleton.Instance.IsAsistenciaFinished)
            {
                MessageBox.Show("La asistencia aún está activa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            State.TotalAccess = false;
            if (MySingleton.Instance.AsistenciasVerifyOBJ != null)
            {
                MySingleton.Instance.AsistenciasVerifyOBJ.StopLector();
            }
            Panels.SustituirPanel(_panelGeneral, new LoginWF(_panelGeneral));
        }


        //Botones del menu
        void SetButtonsColors(Button b)
        {
            var pressed_color = Color.FromArgb(60, 152, 222);
            var flat_color = Color.FromArgb(0, 40, 100);
            foreach (Button i in buttons_list)
            {
                i.BackColor = flat_color;
            }
            b.BackColor = pressed_color;
        }

        //Loged
        private void UserLoged() //En esta parte se le darán los privilegios al usuario
        {
            Panels.AgregarPanel(PanelApp, new HomeWF());
            if (!State.TotalAccess)
            {
                btnAlumnos.Enabled = false;
                btnDocentes.Enabled = false;
                btnGrupos.Enabled = false;
            }
            else
            {
                btnAsistencia.Enabled = false;
                //Nothing to do
            }
        }
        private void btnDocentes_Click(object sender, EventArgs e)
        {

            if (!MySingleton.Instance.IsAsistenciaFinished)
            {
                MessageBox.Show("La asistencia aún está activa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Panels.AgregarPanel(PanelApp, new DocentesWF(PanelApp));
            SetButtonsColors(btnDocentes);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {

            if (!MySingleton.Instance.IsAsistenciaFinished)
            {
                MessageBox.Show("La asistencia aún está activa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Panels.AgregarPanel(PanelApp, new AlumnosWF(PanelApp));
            SetButtonsColors(btnAlumnos);
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {

            if (!MySingleton.Instance.IsAsistenciaFinished)
            {
                MessageBox.Show("La asistencia aún está activa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Panels.AgregarPanel(PanelApp, new AsistenciaWF());
            SetButtonsColors(btnAsistencia);
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {

            if (!MySingleton.Instance.IsAsistenciaFinished)
            {
                MessageBox.Show("La asistencia aún está activa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Panels.AgregarPanel(PanelApp, new GruposWF(this));
            SetButtonsColors(btnGrupos);
        }

        private void lblAsitencia_Click(object sender, EventArgs e)
        {

            if (!MySingleton.Instance.IsAsistenciaFinished)
            {
                MessageBox.Show("La asistencia aún está activa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Panels.SustituirPanel(PanelApp, new HomeWF());
            foreach (Button i in buttons_list)
            {
                i.BackColor = Color.FromArgb(0, 40, 100);
            };
        }
    }
}
