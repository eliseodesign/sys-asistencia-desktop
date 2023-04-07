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
        public _DetailGrupo()
        {

            InitializeComponent();
            lblTitulo.Text = "Agregar Grupo";
            btnGuardar.Text = "Guardar";

            cbxCarrera.DataSource = State.InfoCarrera.carreras;
            cbxAño.DataSource = State.InfoCarrera.años;
            cbxTurno.DataSource = State.InfoCarrera.turnos;

            numEstudiantes.Maximum = 30;
            numEstudiantes.Minimum = 15;
            numEstudiantes.ReadOnly = true;
        }

        public _DetailGrupo(int id)
        {
            InitializeComponent();
            lblTitulo.Text = "Editar Grupo";
            lblTitulo.ForeColor = Color.FromArgb(255, 193, 7);
            btnGuardar.Text = "Editar";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var grupo = new Grupo()
            {
                Año = State.InfoCarrera.idAño[cbxAño.SelectedIndex],
                Carrera = State.InfoCarrera.idCarrera[cbxCarrera.SelectedIndex],
                Turno = cbxTurno.SelectedItem.ToString()
            };

            string codigo = State.grupoBL.AgregarGrupo(grupo);

            MessageBox.Show($"Se a creado el grupo {codigo}");

        }


    }
}
