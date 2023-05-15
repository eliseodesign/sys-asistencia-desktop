using DataEdit;
using Esfe.SysAsistencia.BL;
using Esfe.SysAsistencia.EN;
using Esfe.SysAsistencia.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esfe.SysAsistencia.UI.Components
{
    public partial class GruposWF : Form
    {
        public AplicationWF padre;
        //variable global para editar y eliminar en el DataGriedView
        int Id;
        List<Carrera> carreras = State.carreraBL.ObtenerCarrera();
        List<Anio> anios = State.anioBL.ObtenerAnio();
        List<NumGrupo> numGrupos = State.numGrupoBL.ObtenerNumGrupo();

       
        public GruposWF(AplicationWF form)
        {
            padre = form;
            InitializeComponent();
            List<Carrera> carreras = State.carreraBL.ObtenerCarrera();
            carreras.Insert(0, new Carrera() { Id = 0, Nombre = "Todas",Siglas="N/A" });
            List<Anio> anios = State.anioBL.ObtenerAnio();
            anios.Insert(0, new Anio() { Id = 0, Nombre = "Todos"});


            cbxCarrera.DisplayMember = "Nombre"; 
            cbxCarrera.ValueMember = "Id";
            cbxCarrera.DataSource = carreras;

            //carreras.Insert(0, "Todas");
            cbxAño.DisplayMember = "Nombre";
            cbxAño.ValueMember = "Id";
            cbxAño.DataSource = anios;

            configGrid();
            refreshGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _DetailGrupo detailGrupo = new _DetailGrupo("Nuevo Grupo");
            detailGrupo.ShowDialog();
            refreshGrid();
            //List<Grupo> listaGrupos = State.grupoBL.ObtenerGrupos();
            //if (listaGrupos.Count == 1)
            //{
            //    padre.btnGrupos.PerformClick();
            //}
        }

        private void actualizarGrid(object sender, EventArgs e)
        {
            refreshGrid();
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //// cuando carge
            DgvDesing.Formato(gridGrupos, 1);
            //gridGrupos.Columns["Id"].Width = 50;
            //gridGrupos.Columns["Presencial"].Width = 200;
            //gridGrupos.Columns["Editar"].Width = 90;
            //gridGrupos.Columns["Eliminar"].Width = 90;
        }

        private void gridGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridGrupos.Columns[e.ColumnIndex].Name == "Editar")
            {
                Id = Convert.ToInt32(gridGrupos.CurrentRow.Cells["Id"].Value);
                _DetailGrupo detailGrupo = new _DetailGrupo(Id);
                detailGrupo.ShowDialog();
                refreshGrid();
            }
            if (gridGrupos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Id = Convert.ToByte(gridGrupos.CurrentRow.Cells["Id"].Value);
                MsgBox msg = new MsgBox("question", "¿Está seguro que desea eliminar este grupo?\nSe eliminará de forma permanente.");
                msg.ShowDialog();
                if (msg.DialogResult == DialogResult.OK)
                {
                    var grupo = new Grupo() { Id = Id};
                    bool resul = State.grupoBL.EliminarGrupo(grupo);
                    if (resul)
                    {
                        refreshGrid();
                        return;
                    }
                    MsgBox err = new MsgBox("onlyerror", "No se pudo eliminar");
                    err.ShowDialog();
                }
            }
        }

        private void refreshGrid()
        {
            List<Grupo> grupos = State.grupoBL.ObtenerGrupos();

            var resultado = from g in grupos
                            join c in carreras on g.IdCarrera equals c.Id
                            join a in anios on g.IdAnio equals a.Id
                            join n in numGrupos on g.IdNumGrupo equals n.Id

                            select new
                            {
                                Id = g.Id,
                                Codigo = "G" + n.Nombre[n.Nombre.Length - 1] + "-" + a.Nombre.Substring(0, 1) + c.Siglas,
                                EstudiantesMax = g.EstudiantesMax,
                                IdCarrera = c.Id,
                                Carrera = c.Siglas,
                                IdAnio = a.Id,
                                Año = a.Nombre
                            };

            byte carreraSelect = Convert.ToByte(cbxCarrera.SelectedValue);
            byte anioSelect = Convert.ToByte(cbxAño.SelectedValue);

            var gruposFiltrados = resultado
                .Where(x => (x.IdAnio == anioSelect || anioSelect == 0) && (x.IdCarrera == carreraSelect || carreraSelect == 0));
                

            gridGrupos.DataSource = null;
            gridGrupos.DataSource = gruposFiltrados.ToList();
        }
        private void configGrid()
        {
            gridGrupos.AutoGenerateColumns = false;
            gridGrupos.ReadOnly = true;

            gridGrupos.Columns["Id"].DisplayIndex = 0;
            gridGrupos.Columns["Codigo"].DisplayIndex = 1;
            gridGrupos.Columns["EstudiantesMax"].DisplayIndex = 2;
            gridGrupos.Columns["EstudiantesMax"].DataPropertyName = "EstudiantesMax";
            gridGrupos.Columns["EstudiantesMax"].Name = "EstudiantesMax";
            gridGrupos.Columns["Carrera"].DisplayIndex = 3;
            gridGrupos.Columns["Año"].DisplayIndex = 4;
            gridGrupos.Columns["Editar"].DisplayIndex = 5;
            gridGrupos.Columns["Eliminar"].DisplayIndex = 6;

            gridGrupos.Columns["IdAnio"].Visible = false;
            gridGrupos.Columns["IdCarrera"].Visible = false;
            //gridGrupos.Columns["Año"].Visible = false;
        }

        private void gridGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
