using DataEdit;
using Esfe.SysAsistencia.EN;
using Esfe.SysAsistencia.UI.Helpers;
using System.Text.Json;
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

        List<Carrera> carreras = State.carreraBL.ObtenerCarrera();
        List<Anio> anios = State.anioBL.ObtenerAnio();
        List<NumGrupo> numGrupos = State.numGrupoBL.ObtenerNumGrupo();
        List<Turno> turnos = State.turnoBL.ObtenerTurno();

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
            lblTitulo.Text = "Editar ";
            btnGuardar.Text = "Editar";

            cbxCarrera.Enabled = false;
            cbxAño.Enabled = false;

            cbxAño.SelectedValue = oGrupo.IdAnio;
            cbxCarrera.SelectedValue = oGrupo.IdCarrera;
            cbxTurno.SelectedValue = oGrupo.IdTurno;

            if (oGrupo.EstudiantesMax > 0)
            {
                numEstudiantes.Value = oGrupo.EstudiantesMax;
            }
            var diasDeserializados = JsonSerializer.Deserialize<bool[]>(oGrupo.DiasPresencial);
            
            for (int i = 0; i < diasDeserializados?.Length; i++)
            {
                if (diasDeserializados[i] == true)
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
                if (CheckBoxDays.Count(x => x.Checked == true) >= 3)
                {
                    var grupo = new Grupo()
                    {
                        IdAnio = Convert.ToByte(cbxAño.SelectedValue),
                        IdCarrera = Convert.ToByte(cbxCarrera.SelectedValue),
                        IdTurno = Convert.ToByte(cbxTurno.SelectedValue),
                        EstudiantesMax = Convert.ToByte(numEstudiantes.Value),
                        DiasPresencial = obtenerPresencial()
                    };

                    var si = State.grupoBL.AgregarGrupo(grupo);
                    if (si)
                    {
                         MsgBox msg = new MsgBox("filled", $"Se creó el grupo de forma exitosa");
                         msg.ShowDialog();
                    }
                    else
                    {
                        MsgBox msg = new MsgBox("onlywarning", "¡Error en el proceso!");
                        msg.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    MsgBox msg = new MsgBox("onlywarning", "¡Deben haber 3 días marcados como Presenciales!");
                    msg.ShowDialog(); 
                }
            }
            else if (imgEdit.Visible == true)
            {
                if (CheckBoxDays.Count(x => x.Checked == true) >= 3)
                {
                    oGrupo.EstudiantesMax = Convert.ToByte(numEstudiantes.Value);
                    oGrupo.IdTurno = Convert.ToByte(cbxTurno.SelectedValue);
                    oGrupo.DiasPresencial = obtenerPresencial();
                    oGrupo.IdAnio = Convert.ToByte(cbxAño.SelectedValue);
                    oGrupo.IdCarrera = Convert.ToByte(cbxCarrera.SelectedValue);
                       

                    var si = State.grupoBL.ActualizarGrupo(oGrupo);
                    if (si == false)
                    {
                        MsgBox msg = new MsgBox("onlyerror", "¡Ocurrio un error en el proceso!");
                        msg.ShowDialog();
                    }

                    this.Close();
                }
                else
                {
                    MsgBox msg = new MsgBox("onlywarning", "¡Deben haber 3 días marcados como Presenciales!");
                    msg.ShowDialog();

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
            ComboBox[] cbxs = new ComboBox[3] { cbxCarrera, cbxAño, cbxTurno };
            
            foreach (ComboBox combo in cbxs)
            {
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "Id";
            }

            cbxCarrera.DataSource = carreras;
            cbxAño.DataSource = anios;
            cbxTurno.DataSource = turnos;

            numEstudiantes.Maximum = 30;
            numEstudiantes.Minimum = 15;
            numEstudiantes.ReadOnly = true;
        }

        private string obtenerPresencial()
        {
            bool[] day = new bool[5] { false, false, false, false, false };

            for (int i = 0; i < CheckBoxDays.Length; i++)
            {
                if (CheckBoxDays[i] == null)
                    MessageBox.Show("Error");
                else if (CheckBoxDays[i].Checked)
                    day[i] = true;
            }
            return JsonSerializer.Serialize<bool[]>(day);
        }
    }
}
