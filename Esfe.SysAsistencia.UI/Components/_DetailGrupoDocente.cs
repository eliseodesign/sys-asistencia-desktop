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

            var joinDocente = from d in docentes
                              select new
                              {
                                  Id = d.Id,
                                  Nombre = d.Nombre + " " + d.Apellido
                              };

            listBox.DisplayMember = "Nombre";
            listBox.ValueMember = "Id";
            listBox.DataSource = joinDocente.ToList();

            thisGrupo = grupos.FirstOrDefault(x => x.Id == id);
            byte idCarrera = thisGrupo.IdCarrera;
            string CarreraSigla = carreras.FirstOrDefault(x => x.Id == idCarrera)?.Sigla;

            labelCarrera.Text = CarreraSigla;


            var GrupoDocente = from d in docentes
                               select new
                               {
                                   Id = d.Id,
                                   Nombre = d.Nombre + " " + d.Apellido,
                                   IdCarrera = d.IdCarrera
                               };

            gridGrupoDocentes.DataSource = GrupoDocente.Where(x => x.Id == id).ToList();
            gridGrupoDocentes.Columns["Id"].DisplayIndex = 0;
            gridGrupoDocentes.Columns["Id"].Width = 30;
            gridGrupoDocentes.Columns["Nombre"].DisplayIndex = 1;
            gridGrupoDocentes.Columns["Nombre"].Width = 170;
            gridGrupoDocentes.Columns["Delete"].DisplayIndex = 2;
            gridGrupoDocentes.Columns["Delete"].Width = 60;

            gridGrupoDocentes.Columns["IdCarrera"].Visible = false;
        }



        // Evento DrawItem para personalizar la apariencia de cada elemento

    }
}
