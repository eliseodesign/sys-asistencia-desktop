using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using Esfe.SysAsistencia.BL;
using Esfe.SysAsistencia.DAL;
using System.Drawing;
using Esfe.SysAsistencia.EN;
using Esfe.SysAsistencia.UI.Helpers;


namespace Esfe.SysAsistencia.UI.Components
{
    public partial class VerificarAsistenciaWF : CaptureForm
    {
        //variables
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        private DPFP.Capture.Capture Capture;
        bool respuestaVerificacion = false;
        bool asistenciaEnable = false;
        AsistenciaWF _padre_asistencia;
        Panel _panel_asistencia;
        string GrupoCarreraSelected = "";
        private Control _control;


        enum ASISTENCIA_STATE
        {
            VERIFIED = 0,
            UNVERIFIED = 1,
            NO_IN_LIST = 2,
            DEFAULT = 3,
            DISABLED = 4,
            FINISHED = 5
        }
        //variables

        public VerificarAsistenciaWF(AsistenciaWF padre, string carrera)
        {
            //base.Controls.Remove(cbxPersons);
            InitializeComponent();
            CloseButton.BringToFront();
            _padre_asistencia = padre;
            GrupoCarreraSelected = carrera;
            _control = this;
            _padre_asistencia.cbxGrupo.SelectedIndexChanged += this.On_cbx_grupo_changed;
            lblStatus.Text = "Asistencia Deshabilitada";
            lblHuella.Text = "Deshabilitado";
            lblHuella.Image = Properties.Resources.huella_verificar;
            lblName.Text = "";
            
        }

        //Funcion del SDK
        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            Stop();
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
        }


        //Verificar sin el lector ¡TESTING!
        private void verifyWhitout()
        {
            List<Estudiante> estudianteVar = State.estudianteBL.ObtenerEstudiante().Where(g => g.CodigoGrupo == GrupoCarreraSelected).ToList();
            //var estudianteVar = State.estudianteBL.ObtenerEstudiante().Where(g => g.CodigoGrupo == GrupoCarreraSelected && g.Huella == State.estudianteBL.ObtenerEstudiante().First().Huella).ToList();
            //var nombreEstudiante = estudianteVar.Nombres + " " + estudianteVar.Apellidos;



            foreach (var xd in estudianteVar)
            {
                if (xd.Huella == State.estudianteBL.ObtenerEstudiante().First().Huella)
                {
                    UpdateInfo(ASISTENCIA_STATE.VERIFIED, xd.Nombres);
                    var AsistenciaOBJ = new Asistencia()
                    {
                        AlumnoId = xd.Id,
                        Fecha = DateTime.Now
                    };
                    State.asistenciaBL.AgregarAsistencia(AsistenciaOBJ);
                    var asis = State.asistenciaBL.ObtenerAsistencias();
                    foreach (var a in asis)
                    {
                        MessageBox.Show("Asistencias: \nID: " + a.Id.ToString() + " \nFecha: " + Convert.ToString(a.Fecha));
                    }

                    return;
                }
                else
                {
                    UpdateInfo(ASISTENCIA_STATE.UNVERIFIED, xd.Nombres);
                    return;
                }
            }



        }

        //Verificar la huella
        protected override void Process(DPFP.Sample Sample)
        {
            if (asistenciaEnable == false)
            {
                Stop();
                return;
            }
                
                

            base.Process(Sample);
            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                Estudiante estudiante = new Estudiante();
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                DPFP.Template template = new DPFP.Template();
                Stream stream;
                var estudiantes = State.estudianteBL.ObtenerEstudiante().Where(x => x.CodigoGrupo == GrupoCarreraSelected).ToList();
                var NombreAlumno = "";
                foreach (var alu in estudiantes)
                {
                    estudiante = alu;
                    stream = new MemoryStream(alu.Huella);
                    template = new DPFP.Template(stream);
                    Verificator.Verify(features, template, ref result);
                    if (result.Verified)
                    {

                        respuestaVerificacion = true;
                        NombreAlumno = estudiante.Nombres + " " + estudiante.Apellidos;
                        Stop();
                        break;
                    }
                }

                if (respuestaVerificacion)
                {
                    Stop();
                    UpdateInfo(ASISTENCIA_STATE.VERIFIED, NombreAlumno);
                    CreateTimer(2);
                    AsistirAlumno(estudiante.Id);
                }
                else
                {
                    UpdateInfo(ASISTENCIA_STATE.UNVERIFIED);
                    CreateTimer(10);
                }
            }
        }

        void AsistirAlumno(int ID)
        {
            _control.Invoke((MethodInvoker)delegate {
                foreach (DataGridViewRow row in _padre_asistencia.gridAsistencia.Rows)
                {
                    if (row.Cells["Id"].Value != null && Convert.ToInt32(row.Cells["Id"].Value) == ID)
                    {
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#83bf71");
                    }
                }
            });
        }

        void CreateAsistencia()
        {

            foreach (DataGridViewRow row in _padre_asistencia.gridAsistencia.Rows)
            {
                
                Color rowColor = row.DefaultCellStyle.BackColor;
                Color hexColorGreen = ColorTranslator.FromHtml("#83bf71");
                Color hexColorRed = ColorTranslator.FromHtml("#780000");
                Asistencia asistencia = new Asistencia()
                {
                    AlumnoId = Convert.ToInt32(row.Cells["Id"].Value),
                    Fecha = DateTime.Now
                };
                if (row.DefaultCellStyle.BackColor == Color.Empty)
                {
                    asistencia.Criterio = Asistencia.CRITERIOS.NO_ASISTIO;
                }
                else if (row.DefaultCellStyle.BackColor == hexColorGreen)
                {
                    asistencia.Criterio = Asistencia.CRITERIOS.PRESENCIAL;
                }

                State.asistenciaBL.AgregarAsistencia(asistencia);
            }



        }

        //Esto actualiza la informacion en el panel
        private void UpdateInfo(ASISTENCIA_STATE ID, string AlumnoName = "")
        {
            _control.Invoke((MethodInvoker)delegate
            {
                if (ID == ASISTENCIA_STATE.VERIFIED)
                {
                    lblStatus.Text = "Huella Verificada, Esperando más asistecias.";
                    lblHuella.Text = "Huella Verificada";
                    lblHuella.Image = Properties.Resources.huella_completa;
                    lblName.Text = AlumnoName + " verificado.";
                }
                else if (ID == ASISTENCIA_STATE.UNVERIFIED)
                {
                    lblStatus.Text = "No se pudo verificar. Reintente por favor.";
                    lblHuella.Text = "Huella no reconocida";
                    lblHuella.Image = Properties.Resources.huella_error;
                }
                else if (ID == ASISTENCIA_STATE.NO_IN_LIST)
                {
                    lblStatus.Text = "Estudiante no encontrado en la Lista.";
                    lblHuella.Text = "¿Huella correcta?";
                    lblHuella.Image = Properties.Resources.huella_error;
                    lblName.Text = "";
                }
                else if (ID == ASISTENCIA_STATE.DEFAULT)
                {
                    lblStatus.Text = "Esperando la Huella del Alumno.";
                    lblHuella.Text = "Esperando...";
                    lblHuella.Image = Properties.Resources.huella_dactilar_;
                    lblName.Text = "";

                }
                else if(ID == ASISTENCIA_STATE.DISABLED)
                {
                    lblStatus.Text = "Asistencia Deshabilitada";
                    lblHuella.Text = "Deshabilitado";
                    lblHuella.Image = Properties.Resources.huella_verificar;
                    lblName.Text = "";
                }
                else if (ID == ASISTENCIA_STATE.FINISHED)
                {
                    lblStatus.Text = "Asistencia del día Terminada";
                    lblHuella.Text = "Deshabilitado";
                    lblHuella.Image = Properties.Resources.huella_verificar;
                    lblName.Text = "";
                }
            });

        }

        //--------- ATENCION: Esto es para habilitar o deshabilitar la asistencia
        //--------- pero fue pospuesta por falta de tiempo
        //--------- Y ahora se dejo solo pa cancelarla :C
        //
        //
        private void btnEnableAsis_Click(object sender, EventArgs e)
        {
            //Funcion para cancelar la asitencia
            if (!asistenciaEnable)
            {
                UpdateInfo(ASISTENCIA_STATE.DEFAULT);
                asistenciaEnable = true;
                btnEnableAsis.BackColor = Color.FromArgb(229, 90, 90);
                btnEnableAsis.Text = "Terminar Asistencias";
                _padre_asistencia.cbxGrupo.Enabled = false;
                MySingleton.Instance.IsAsistenciaFinished = false;
                Start();

            }
            else
            {
                UpdateInfo(ASISTENCIA_STATE.FINISHED);
                asistenciaEnable = false;
                btnEnableAsis.BackColor = Color.FromArgb(90, 200, 90);
                btnEnableAsis.Text = "Asistencias Terminadas";
                _padre_asistencia.cbxGrupo.Enabled = true;
                MySingleton.Instance.IsAsistenciaFinished = true;
                CreateAsistencia(); ;
                Stop();
                MessageBox.Show("La asistencia del Día se ha guardado de forma exitosa. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void On_cbx_grupo_changed(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            GrupoCarreraSelected = comboBox.Text;
        }

        void CreateTimer(int time = 1)
        {
            _control.Invoke((MethodInvoker)delegate
            {
                System.Timers.Timer timer = new System.Timers.Timer(1000);
                int countdown = time;
                // Asignar un evento para que se ejecute cada vez que se complete el intervalo
                timer.Elapsed += (sender, e) =>
                {
                    countdown--;
                    if (countdown == 0)
                    {
                        // Detener el temporizador
                        timer.Stop();

                        // Ejecutar el método deseado
                        UpdateInfo(ASISTENCIA_STATE.DEFAULT);
                        respuestaVerificacion = false;
                        Template = new DPFP.Template();
                        Start();
                        return;
                    }
                };
                // Iniciar el temporizador
                timer.Start();
            });
        }
    }


}
