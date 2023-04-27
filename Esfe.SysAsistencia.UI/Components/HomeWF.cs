using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esfe.SysAsistencia.UI.Helpers;

namespace Esfe.SysAsistencia.UI.Components
{
    public partial class HomeWF : Form
    {
        public HomeWF()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();

            lblDocentes.Text = State.docenteBL.ObtenerDocentes().Count().ToString();
            lblEstudiantes.Text = State.estudianteBL.ObtenerEstudiante().Count().ToString();
            lblGrupos.Text = State.grupoBL.ObtenerGrupos().Count().ToString();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
            
        }

    }
}
