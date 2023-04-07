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
            InitializeComponent();


            List<string> carreras = State.InfoCarrera.carreras.ToList();
            carreras.Insert(0, "Todas");
            cbxCarrera.DataSource = carreras;

            List<string> años = State.InfoCarrera.años.ToList();
            años.Insert(0, "Todos");
            cbxAño.DataSource = años;

            configGrid();
            refreshGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _DetailGrupo detailGrupo = new _DetailGrupo();
            detailGrupo.ShowDialog();
            refreshGrid();
        }


        private void actualizarGrid(object sender, EventArgs e)
        {
            List<Grupo> gruposFiltrados = FiltrarGrupos();

            gridGrupos.DataSource = null;
            gridGrupos.DataSource = gruposFiltrados;
        }

        private List<Grupo> FiltrarGrupos()
        {
            string? carrera = null;
            string? año = null;

            if (cbxCarrera.SelectedIndex > 0)
                carrera = State.InfoCarrera.idCarrera[cbxCarrera.SelectedIndex - 1];

            if (cbxAño.SelectedIndex > 0)
                año = State.InfoCarrera.idAño[cbxAño.SelectedIndex - 1];

            return State.grupoBL
                .ObtenerGrupos()
                .Where(x => (carrera == null || x.Carrera == carrera) && (año == null || x.Año == año))
                .ToList();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // cuando carge xd

            DGVDisenio.Formato(gridGrupos, 1);

        }

        private void gridGrupos_Click(object sender, EventArgs e)
        {

        }

        private void gridGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridGrupos.Columns[e.ColumnIndex].Name == "Editar")
            {
                string Codigo = gridGrupos.CurrentRow.
                    Cells["Codigo"].Value.ToString();

                MessageBox.Show(Codigo.ToString());
                _DetailGrupo detailGrupo = new _DetailGrupo(Codigo);
                detailGrupo.ShowDialog();
                
                //CargarGrid();
            }
      
        }

        private void refreshGrid()
        {
            gridGrupos.DataSource = null;
            gridGrupos.DataSource = State.grupoBL.ObtenerGrupos();
        }
        private void configGrid()
        {
            gridGrupos.AutoGenerateColumns = false;
            gridGrupos.ReadOnly = true;

            gridGrupos.Columns["Id"].DisplayIndex = 0;
            gridGrupos.Columns["Codigo"].DisplayIndex = 1;
            gridGrupos.Columns["Carrera"].DisplayIndex = 2;
            gridGrupos.Columns["Año"].DisplayIndex = 3;
            gridGrupos.Columns["EstudiantesMax"].DisplayIndex = 4;
            gridGrupos.Columns["Turno"].DisplayIndex = 5;
            gridGrupos.Columns["Editar"].DisplayIndex = 6;
            gridGrupos.Columns["Editar"].Width = 75;
            gridGrupos.Columns["Eliminar"].DisplayIndex = 7;
            gridGrupos.Columns["Eliminar"].Width = 75;

            gridGrupos.Columns["DocenteId"].Visible = false;
        }
    }
}
