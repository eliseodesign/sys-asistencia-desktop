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



        public _DetailGrupo()
        {

        }
        public _DetailGrupo(string msg = "Nuevo Grupo") : this()
        {
            InitializeComponent();
            cargarCBX();
            lblTitulo.Text = msg;
            btnGuardar.Text = "Guardar";
            imgEdit.Visible = false;
        }

        public _DetailGrupo(int id) : this()
        {
            oGrupo = State.grupoBL
                .ObtenerGrupos()
                .FirstOrDefault(x => x.Id == id);

            if (oGrupo == null)
            {
                MessageBox.Show("ERROR - GRUPO NO ENCONTRADO");
                return;
            }
            InitializeComponent();
            cargarCBX();
            imgAgregar.Visible = false;
            lblTitulo.Text = "Editar " + oGrupo.Codigo;
            btnGuardar.Text = "Editar";

            cbxCarrera.Enabled = false;
            cbxAño.Enabled = false;


            cbxAño.SelectedIndex = Array.IndexOf(State.InfoCarrera.idAño, oGrupo.Año);
            cbxCarrera.SelectedIndex = Array.IndexOf(State.InfoCarrera.idCarrera, oGrupo.Carrera);
            cbxTurno.SelectedIndex = Array.IndexOf(State.InfoCarrera.turnos, oGrupo.Turno);

            numEstudiantes.Value = oGrupo.EstudiantesMax;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (imgAgregar.Visible == true)
            {
                var days = obtenerPresencial();


                var grupo = new Grupo()
                {
                    Año = State.InfoCarrera.idAño[cbxAño.SelectedIndex],
                    Carrera = State.InfoCarrera.idCarrera[cbxCarrera.SelectedIndex],
                    Turno = State.InfoCarrera.turnos[cbxTurno.SelectedIndex],
                    EstudiantesMax = Convert.ToInt32(numEstudiantes.Value),
                    Horario = days
                };

                string codigo = State.grupoBL.AgregarGrupo(grupo);

                MessageBox.Show($"Se a creado el grupo {codigo}");
                this.Close();
            }
            else if (imgEdit.Visible == true)
            {
                oGrupo.EstudiantesMax = Convert.ToInt32(numEstudiantes.Value);
                oGrupo.Turno = State.InfoCarrera.turnos[cbxTurno.SelectedIndex];

                var si = State.grupoBL.ActualizarGrupo(oGrupo);
                if (si == false)
                {
                    MessageBox.Show("Ocurrio un error!!!");
                }

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            var CheckBoxDays = new CheckBox[5] { lun, mar, mie, jue, vie };
            bool[] day = new bool[5] { false, false, false, false, false};

            for (int i = 0; i < CheckBoxDays.Length; i++)   
            {
                if (CheckBoxDays[i] ==null)
                {
                    MessageBox.Show("null carajo");
                    
                }
                else if (CheckBoxDays[i].Checked)
                {
                    day[i] = true;
                    
                }
            }
            return day;
        }
    }
}
