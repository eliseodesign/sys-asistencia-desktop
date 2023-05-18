using DataEdit;
using Esfe.SysAsistencia.BL;
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
    public partial class _DetailGrupoDocente : Form
    {
        List<Docente> docentes = State.docenteBL.ObtenerDocentes();
        List<Grupo> grupos = State.grupoBL.ObtenerGrupos();
        List<Carrera> carreras = State.carreraBL.ObtenerCarrera();
        Grupo thisGrupo;
        public _DetailGrupoDocente(int id)
        {
            InitializeComponent();

            thisGrupo = grupos.FirstOrDefault(x => x.Id == id);
            refreshListView();
            refreshGrid();

            byte idCarrera = thisGrupo.IdCarrera;
            string CarreraSigla = carreras.FirstOrDefault(x => x.Id == idCarrera)?.Sigla;

            labelCarrera.Text = CarreraSigla;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex > -1 && thisGrupo != null) // Verifica que se haya seleccionado un item
            {
                var selectedValue = listBox.SelectedValue;
               
                GrupoDocente newGrupoDocente = new GrupoDocente()
                {
                    IdGrupo = Convert.ToByte(thisGrupo.Id),
                    IdDocente = Convert.ToByte(selectedValue)
                };
                var res = State.grupoDocenteBL.AgregarGrupoDocente(newGrupoDocente);
                if (!res)
                {
                    MsgBox msg = new MsgBox("filled", "Se registro de forma exitosa");
                    msg.ShowDialog();
                }

                refreshGrid();
            }
        }

        private void refreshListView()
        {
            var joinDocente = from d in docentes
                              select new
                              {
                                  Id = d.Id,
                                  Nombre = d.Nombre + " " + d.Apellido,
                                  IdCarrera = d.IdCarrera
                              };

            listBox.DisplayMember = "Nombre";
            listBox.ValueMember = "Id";
            listBox.DataSource = joinDocente.Where(x=>x.IdCarrera == thisGrupo.IdCarrera).ToList();
        }
        private void refreshGrid()
        {
            List<GrupoDocente> grupoDocentes = State.grupoDocenteBL.ObtenerGrupoDocentes();
            var GrupoDocente = from gd in grupoDocentes
                               join d in docentes on gd.IdDocente equals d.Id
                               select new
                               {
                                   Id = gd.Id,
                                   Nombre = d.Nombre + " " + d.Apellido,
                                   IdGrupo = gd.IdGrupo
                               };

            gridGrupoDocentes.DataSource = GrupoDocente.Where(x => x.IdGrupo == thisGrupo.Id).ToList();

        }

        private void _DetailGrupoDocente_Load(object sender, EventArgs e)
        {
            gridGrupoDocentes.Columns["Id"].DisplayIndex = 0;
            gridGrupoDocentes.Columns["Id"].Width = 30;
            gridGrupoDocentes.Columns["Nombre"].DisplayIndex = 1;
            gridGrupoDocentes.Columns["Nombre"].Width = 170;
            gridGrupoDocentes.Columns["Delete"].DisplayIndex = 2;
            gridGrupoDocentes.Columns["Delete"].Width = 60;

            gridGrupoDocentes.Columns["IdGrupo"].Visible = false;
        }

        private void gridGrupoDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridGrupoDocentes.Columns[e.ColumnIndex].Name == "Delete")
            {
                DataGridViewRow row = gridGrupoDocentes.Rows[e.RowIndex];
                DataGridViewCell idCell = row.Cells["Id"];

                byte idGrupo = Convert.ToByte(idCell.Value);
                GrupoDocente delete = new GrupoDocente()
                {
                    Id = idGrupo
                };
                bool res = State.grupoDocenteBL.EliminarGrupoDocente(delete);
                if (!res) MessageBox.Show("error al eliminar");
                refreshGrid();
            }
        }
    }
}
