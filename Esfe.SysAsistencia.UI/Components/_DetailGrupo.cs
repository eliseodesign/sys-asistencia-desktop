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
    public partial class _DetailGrupo : Form
    {
        private DataGridView _gridGrupo;
        public _DetailGrupo(string titulo, DataGridView gridGrupo)
        {
            _gridGrupo = gridGrupo;
            InitializeComponent();
            lblTitulo.Text = titulo;

            cbxCarrera.DataSource = State.InfoCarrera.carreras;
            cbxAño.DataSource = State.InfoCarrera.años;
            cbxTurno.DataSource = State.InfoCarrera.turnos;

            numEstudiantes.Maximum = 30;
            numEstudiantes.Minimum = 15;
            numEstudiantes.ReadOnly = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var grupo = new Grupo()
            {
                Año = State.InfoCarrera.idAño[cbxAño.SelectedIndex],
                Carrera = State.InfoCarrera.idCarrera[cbxCarrera.SelectedIndex],
                Turno = cbxTurno.SelectedText
            };

            string codigo = State.grupoBL.AgregarGrupo(grupo);

            MessageBox.Show($"Se a creado el grupo {codigo}");
            RefrescarGrid();
        }

        private void RefrescarGrid()
        {
            _gridGrupo.DataSource = null;
            _gridGrupo.DataSource = State.grupoBL.ObtenerGrupos();

        }
    }
}
