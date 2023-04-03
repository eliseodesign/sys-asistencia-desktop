using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esfe.SysAsistencia.EN;
using Esfe.SysAsistencia.UI.Helpers;

namespace Esfe.SysAsistencia.UI.Components
{
    public partial class AsistenciaWF : Form
    {
        public Panel _panel_app;

        public AsistenciaWF(Panel panel)
        {
            _panel_app = panel;
            InitializeComponent();

            var codigos = State.DocenteLoged.GrupoCodigos;
            cbxGrupo.DataSource = null;
            cbxGrupo.DataSource = codigos;
        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string grupo = cbxGrupo.SelectedValue.ToString();
            MessageBox.Show(grupo);

            List<Estudiante> lista = new List<Estudiante>();
            foreach(var ee in State.estudianteBL.ObtenerEstudiante())
            {
                if(ee.CodigoGrupo == grupo)
                {
                    lista.Add(ee);
                }
            }

            gridAsistencia.DataSource = null;
            gridAsistencia.DataSource = lista;
        }
    }
}
