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
        
        public GruposWF(AplicationWF form)
        {
            padre = form;
            InitializeComponent();
            List<Carrera> carreras = State.carreraBL.ObtenerCarrera();
            List<Anio> anios = State.anioBL.ObtenerAnio();

            //carreras.Insert(0, "Todas");
            cbxCarrera.DisplayMember = "Nombre"; 
            cbxCarrera.ValueMember = "Id";
            cbxCarrera.DataSource = carreras;

            //carreras.Insert(0, "Todas");
            cbxCarrera.DisplayMember = "Nombre"; 
            cbxCarrera.ValueMember = "Id";
            cbxCarrera.DataSource = anios;

            configGrid();
            refreshGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //_DetailGrupo detailGrupo = new _DetailGrupo("Nuevo Grupo");
            //detailGrupo.ShowDialog();
            //refreshGrid();
            //List<Grupo> listaGrupos = State.grupoBL.ObtenerGrupos();
            //if (listaGrupos.Count == 1)
            //{
            //    padre.btnGrupos.PerformClick();
            //}
        }

        private void actualizarGrid(object sender, EventArgs e)
        {
            List<Carrera> carreras = State.carreraBL.ObtenerCarrera();
            List<Anio> anios = State.anioBL.ObtenerAnio();
            List<NumGrupo> numGrupos = State.numGrupoBL.ObtenerNumGrupo();

            List<Grupo> grupos = State.grupoBL.ObtenerGrupos();
            var resultado = from grupo in grupos
                            join carrera in carreras on grupo.IdCarrera equals carrera.Id
                            join anio in anios on grupo.IdAnio equals anio.Id
                            join num in numGrupos on grupo.IdNumGrupo equals num.Id
                            select new
                            {
                                Id = grupo.Id,
                                Codigo = "G" + num.Nombre[num.Nombre.Length - 1] + "-" + anio.Nombre.Substring(0, 1) + carrera.Siglas,
                                EstudiantesMax = grupo.EstudiantesMax,
                                IdCarrera = carrera.Id,
                                Carrera = carrera.Nombre,
                                IdAnio = anio.Id,
                                Año = anio.Nombre
                            };

            byte carreraSelect = 0;
            byte anioSelect = 0;

            if (cbxCarrera.SelectedIndex > 0)
                carreraSelect = Convert.ToByte(cbxCarrera.SelectedValue);

            if (cbxAño.SelectedIndex > 0)
                anioSelect = Convert.ToByte(cbxAño.SelectedValue);

            var gruposFiltrados = resultado
                .Where(x => x.IdAnio == anioSelect && x.IdCarrera == carreraSelect)
                .ToList();

            gridGrupos.DataSource = null;
            gridGrupos.DataSource = gruposFiltrados;
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //// cuando carge
            //DgvDesing.Formato(gridGrupos, 1);
            //gridGrupos.Columns["Id"].Width = 50;
            //gridGrupos.Columns["Presencial"].Width = 200;
            //gridGrupos.Columns["Editar"].Width = 90;
            //gridGrupos.Columns["Eliminar"].Width = 90;
        }

        private void gridGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (gridGrupos.Columns[e.ColumnIndex].Name == "Editar")
            //{
            //    Id = Convert.ToInt32(gridGrupos.CurrentRow.Cells["Id"].Value);
            //    _DetailGrupo detailGrupo = new _DetailGrupo(Id);
            //    detailGrupo.ShowDialog();
            //    refreshGrid();
            //}
            //if (gridGrupos.Columns[e.ColumnIndex].Name == "Eliminar")
            //{
            //    Id = Convert.ToInt32(gridGrupos.CurrentRow.Cells["Id"].Value.ToString());
            //    MsgBox msg = new MsgBox("question", "¿Está seguro que desea eliminar este grupo?\nSe eliminará de forma permanente.");
            //    msg.ShowDialog();
            //    if(msg.DialogResult == DialogResult.OK)
            //    {
            //        State.grupoBL.EliminarGrupo(Id);
            //        refreshGrid();
            //    }
            //}
        }

        private void refreshGrid()
        {
            gridGrupos.DataSource = null;
            List<Grupo> listaGrupos = State.grupoBL.ObtenerGrupos();

            gridGrupos.DataSource = listaGrupos;
        }
        private void configGrid()
        {
            gridGrupos.AutoGenerateColumns = false;
            gridGrupos.ReadOnly = true;

            int i = 0;
            gridGrupos.Columns["Id"].DisplayIndex = 0;
            gridGrupos.Columns["Codigo"].DisplayIndex = 1;
            gridGrupos.Columns["EstudiantesMax"].DisplayIndex = 2;
            gridGrupos.Columns["EstudiantesMax"].DataPropertyName = "EstudiantesMax";
            gridGrupos.Columns["EstudiantesMax"].Name = "EstudiantesMax";
            gridGrupos.Columns["Carrera"].DisplayIndex = 3;
            gridGrupos.Columns["Año"].DisplayIndex = 4;
            gridGrupos.Columns["Editar"].DisplayIndex = 5;
            gridGrupos.Columns["Eliminar"].DisplayIndex = 6;

            //gridGrupos.Columns["DocenteId"].Visible = false;
            //gridGrupos.Columns["Carrera"].Visible = false;
            //gridGrupos.Columns["Año"].Visible = false;
        }

        private void gridGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
