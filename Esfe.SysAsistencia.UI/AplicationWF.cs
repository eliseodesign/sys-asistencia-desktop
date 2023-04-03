using Esfe.SysAsistencia.UI.Components;
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
            State.TotalAccess = false;
            Panels.SustituirPanel(_panelGeneral, new LoginWF(_panelGeneral));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

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

        //Botones del menu

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
            Panels.AgregarPanel(PanelApp, new DocentesWF(PanelApp));
            SetButtonsColors(btnDocentes);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            Panels.AgregarPanel(PanelApp, new AlumnosWF(PanelApp));
            SetButtonsColors(btnAlumnos);
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            Panels.AgregarPanel(PanelApp, new AsistenciaWF(PanelApp));
            SetButtonsColors(btnAsistencia);
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            Panels.AgregarPanel(PanelApp, new GruposWF(PanelApp));
            SetButtonsColors(btnGrupos);
        }

        private void lblAsitencia_Click(object sender, EventArgs e)
        {
            Panels.SustituirPanel(PanelApp, new HomeWF());
            foreach (Button i in buttons_list)
            {
                i.BackColor = Color.FromArgb(0, 40, 100);
            };
        }
    }
}
