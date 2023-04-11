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
        Grupo oGrupo = new Grupo();

        CheckBox[] CheckBoxDays = new CheckBox[5];

        public _DetailGrupo()
        {
            InitializeComponent();
            cargarCBX();
            CheckBoxDays = new CheckBox[5] { lun, mar, mie, jue, vie };
        }
        public _DetailGrupo(string msg = "Nuevo Grupo") : this()
        {
            lblTitulo.Text = msg;
            btnGuardar.Text = "Guardar";
            imgEdit.Visible = false;
        }
        public _DetailGrupo(int id) : this()
        {
            oGrupo = State.grupoBL.ObtenerGrupos().FirstOrDefault(x => x.Id == id);

            if (oGrupo == null)
            {
                MessageBox.Show("¡No se pudo encontrar el grupo!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            imgAgregar.Visible = false;
            lblTitulo.Text = "Editar " + oGrupo.Codigo;
            btnGuardar.Text = "Editar";

            cbxCarrera.Enabled = false;
            cbxAño.Enabled = false;

            cbxAño.SelectedIndex = Array.IndexOf(State.InfoCarrera.idAño, oGrupo.Año);
            cbxCarrera.SelectedIndex = Array.IndexOf(State.InfoCarrera.idCarrera, oGrupo.Carrera);
            cbxTurno.SelectedIndex = Array.IndexOf(State.InfoCarrera.turnos, oGrupo.Turno);

            if (oGrupo.EstudiantesMax > 0)
            {
                numEstudiantes.Value = oGrupo.EstudiantesMax;
            }

            for (int i = 0; i < oGrupo.Horario.Length; i++)
            {
                if (oGrupo.Horario[i] == true)
                {
                    CheckBoxDays[i].Checked = true;
                }
            }
        }
        // EVENTOS 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (imgAgregar.Visible == true)
            {
                if(CheckBoxDays.Count(x=>x.Checked == true) >= 3)
                {
                    var grupo = new Grupo()
                    {
                        Año = State.InfoCarrera.idAño[cbxAño.SelectedIndex],
                        Carrera = State.InfoCarrera.idCarrera[cbxCarrera.SelectedIndex],
                        Turno = State.InfoCarrera.turnos[cbxTurno.SelectedIndex],
                        EstudiantesMax = Convert.ToInt32(numEstudiantes.Value),
                        Horario = obtenerPresencial()
                    };

                    string codigo = State.grupoBL.AgregarGrupo(grupo);

                    MessageBox.Show($"Se creó el gurpo {codigo} de forma exitosa", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Deben haber 3 días marcados como Presenciales!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else if (imgEdit.Visible == true)
            {
                if (CheckBoxDays.Count(x => x.Checked == true) >= 3)
                {
                    oGrupo.EstudiantesMax = Convert.ToInt32(numEstudiantes.Value);
                    oGrupo.Turno = State.InfoCarrera.turnos[cbxTurno.SelectedIndex];
                    oGrupo.Horario = obtenerPresencial();

                    var si = State.grupoBL.ActualizarGrupo(oGrupo);
                    if (si == false)
                    {
                        MessageBox.Show("Ocurrio un error!!!");
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Deben haber 3 días marcados como Presenciales!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeLbl(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            var count = CheckBoxDays.Count(x => x.Checked == true);

            if (count <= 3)
            {
                lblPresencial.Text = CheckBoxDays.Count(x => x.Checked == true) + " presencial";
                lblVirtual.Text = CheckBoxDays.Count(x => x.Checked == false) + " virtual";

            }
            else
            {
                checkBox.Checked = false;
            }



        }
        private void cargarCBX()
        {
            cbxCarrera.DataSource = State.InfoCarrera.carreras;
            cbxAño.DataSource = State.InfoCarrera.años;
            cbxTurno.DataSource = State.InfoCarrera.turnos;

            numEstudiantes.Maximum = 30;
            numEstudiantes.Minimum = 15;
            numEstudiantes.ReadOnly = true;
        }

        private bool[] obtenerPresencial()
        {
            bool[] day = new bool[5] { false, false, false, false, false };

            for (int i = 0; i < CheckBoxDays.Length; i++)
            {
                if (CheckBoxDays[i] == null)
                    MessageBox.Show("Error");
                else if (CheckBoxDays[i].Checked)
                    day[i] = true;
            }
            return day;
        }
    }
}
