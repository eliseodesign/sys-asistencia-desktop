using Esfe.SysAsistencia.EN;
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
            InitializeComponent() ;

            
            List<string> carreras = State.InfoCarrera.carreras.ToList();
            carreras.Insert(0, "Todas");
            cbxCarrera.DataSource = carreras;

            List<string> años = State.InfoCarrera.años.ToList();
            años.Insert(0, "Todos");
            cbxAño.DataSource = años;

            gridGrupos.DataSource = null;
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

        private void actualizarGrid(object sender, EventArgs e)
        {
            // creamos un list para filtrar los grupos
            List<Grupo> gruposFiltrados = new List<Grupo>();

            // validamos de esta manera ya que agregamos a los cbxs un nuevo elemento y si obtenemos el indice al extraer el valor del array corespondiente podría dar error
            if (cbxCarrera.SelectedIndex <= 0 && cbxAño.SelectedIndex <= 0)
            {
                gruposFiltrados = State.grupoBL.ObtenerGrupos();
            }
            else if (cbxCarrera.SelectedIndex > 0 && cbxAño.SelectedIndex == 0)
            {
                string carrera = State.InfoCarrera.idCarrera[cbxCarrera.SelectedIndex -1];

                gruposFiltrados = State.grupoBL
                    .ObtenerGrupos()
                    .Where(x => x.Carrera == carrera).ToList();

            }
            else if (cbxCarrera.SelectedIndex == 0 && cbxAño.SelectedIndex > 0)
            {
                string año = State.InfoCarrera.idAño[cbxAño.SelectedIndex - 1];

                gruposFiltrados = State.grupoBL
                    .ObtenerGrupos()
                    .Where(x => x.Año == año).ToList();
            }
            else if(cbxCarrera.SelectedIndex > 0 && cbxAño.SelectedIndex > 0)
            {
                string carrera = State.InfoCarrera.idCarrera[cbxCarrera.SelectedIndex - 1];
                string año = State.InfoCarrera.idAño[cbxAño.SelectedIndex - 1];
                gruposFiltrados = State.grupoBL
                    .ObtenerGrupos()
                    .Where(x =>x.Carrera == carrera && x.Año == año).ToList();
            }
            gridGrupos.DataSource = null;
            gridGrupos.DataSource = gruposFiltrados;
        }

    }
}
