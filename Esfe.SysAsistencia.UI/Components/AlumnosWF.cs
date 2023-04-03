using Esfe.SysAsistencia.BL;
using Esfe.SysAsistencia.UI.Helpers;
using Esfe.SysAsistencia.EN;
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
    public partial class AlumnosWF : Form
    {
        //  -------------------------- Variables para el lector --------------------------
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        //  -------------------------- Variables para el lector --------------------------

        public Panel _panel_app;
        public AlumnosWF(Panel panel)
        {
            _panel_app = panel;
            InitializeComponent();
            SetGridFormat();
            string[] carreras = new string[4] { "Téc. ing Electica", "Téc. ing de Desarrollo De Software", "Téc en Mercadeo", "Téc. en Gestión y Desarrollo Turístico" };
            cbxCarrera.DataSource = carreras;

            cbxGrupo.DataSource = State.grupoBL.ObtenerGrupos().Select(g => g.Codigo).ToList();
        }

        //Signals
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validacion de campos

            //Creacion del Alumno
            var estudiante = new Estudiante()
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Cel = txtTelefono.Text,
                Dui = txtDui.Text,
                Nit = txtNit.Text,
                IdCarrera = cbxCarrera.SelectedValue.ToString(),
                Huella = Template.Bytes,
                CodigoGrupo = cbxGrupo.SelectedValue.ToString(),

            };

            //Agregar alumno al BL
            var result = State.estudianteBL.AgregarEstudiante(estudiante);
            if (!result)
            {
                MessageBox.Show("No se puede registrar con la misma huella!", "ERROR GRAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RefreshGrid();
                MessageBox.Show("Se regitró al estudiante de forma exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Refrescar Tabla
        void RefreshGrid()
        {

            var estudiantes = State.estudianteBL.ObtenerEstudiante();
            if (estudiantes.Count == 0) return; // si es cero, se retorna
            gridEstudiantes.DataSource = null;
            gridEstudiantes.DataSource = estudiantes;
        }

        //Darle formato a la tabla
        public void SetGridFormat()
        {
            gridEstudiantes.AutoGenerateColumns = false;

            gridEstudiantes.ColumnCount = 4;

            gridEstudiantes.Columns[0].Name = "ID";
            gridEstudiantes.Columns[0].DataPropertyName = "Id";
            gridEstudiantes.Columns[0].Width = 50;

            gridEstudiantes.Columns[1].Name = "Nombre";
            gridEstudiantes.Columns[1].DataPropertyName = "Nombres";
            gridEstudiantes.Columns[1].Width = 200;

            gridEstudiantes.Columns[2].Name = "Carrera";
            gridEstudiantes.Columns[2].DataPropertyName = "IdCarrera";
            gridEstudiantes.Columns[2].Width = 200;

            gridEstudiantes.Columns[3].Name = "Grupo";
            gridEstudiantes.Columns[3].DataPropertyName = "CodigoGrupo";
            gridEstudiantes.Columns[3].Width = 200;
        }

        //Abrir form para la huella
        private void btnChangeHuella_Click_1(object sender, EventArgs e)
        {
            CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();  //crea un nuevo form para capturar la huella
        }

        //OnTemplate: Señal que se emite cuando se termina la captura de la huella

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                btnGuardar.Enabled = (Template != null);
                if (Template != null)
                {
                    //Comprobar si la huella existe->
                    if (!MySingleton.Instance.TemplateIsNull)
                    {
                        MessageBox.Show("La huella está lista.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MySingleton.Instance.TemplateIsNull = false;
                    MessageBox.Show("La huella no es valida.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }));
        }

        private void AlumnosWF_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
