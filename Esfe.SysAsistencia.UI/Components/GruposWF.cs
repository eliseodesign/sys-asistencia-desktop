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

namespace Esfe.SysAsistencia.UI.Components
{
    public partial class GruposWF : Form
    {
        public Panel _panel_app;
        public GruposWF(Panel panel_app)
        {
            _panel_app = panel_app;
            InitializeComponent();
            gridGrupos.DataSource = State.grupoBL.ObtenerGrupos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _DetailGrupo detailGrupo = new _DetailGrupo("Agregar Grupo", gridGrupos);
            detailGrupo.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _DetailGrupo detailGrupo = new _DetailGrupo("Editar Grupo", gridGrupos);
            detailGrupo.ShowDialog();
        }
    }
}
