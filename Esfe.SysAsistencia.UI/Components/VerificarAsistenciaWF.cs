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
using DPFP.Verification;
using Esfe.SysAsistencia.BL;
using System.Drawing;
using Esfe.SysAsistencia.EN;
using Esfe.SysAsistencia.UI.Helpers;


namespace Esfe.SysAsistencia.UI.Components
{

    /*
    Clase VerificarAsistenciaWF

    Propósito:
    Esta clase proporciona la funcionalidad para poder tomar la asistencia por medio de el Lector de Huellas

    Funcionalidades:
    - Toma la muestra de la huella del alumno y marca la asistencia
    - Habilitar o deshabilitar la toma de la asistencia

    Componentes:
    - Botone para guardar y cancelar la asistencia.
    */

    public partial class VerificarAsistenciaWF : CaptureForm
    {
        //variables
        private DPFP.Template Template; // Es la plantilla para la huella
        private DPFP.Verification.Verification Verificator; //Herramienta que ayuda a verificar la huella
        bool respuestaVerificacion = false; //El resultado de la verificacion de la huella
        bool asistenciaEnable = false; //Si la asistencia esta habilitada
        AsistenciaWF _padre_asistencia;
        string GrupoCarreraSelected = ""; //El grupo de la carrera
        private Control _control;//Controlador para el Hilo de subprocesos que usa el lector
        enum ASISTENCIA_STATE //Un simple enum para los estados de la asitencia
        {
            VERIFIED = 0,
            UNVERIFIED = 1,
            NO_IN_LIST = 2,
            DEFAULT = 3,
            DISABLED = 4,
            FINISHED = 5
        }
        //variables

        //TODO: Remover el cbxPersons de CaptureForm
        public VerificarAsistenciaWF(AsistenciaWF padre, string carrera)
        {
            InitializeComponent();
            base.Hide();
            _padre_asistencia = padre;
            GrupoCarreraSelected = carrera;
            _control = this;
            _padre_asistencia.cbxGrupo.SelectedIndexChanged += this.On_cbx_grupo_changed;
            lblStatus.Text = "Asistencia Deshabilitada";
            lblHuella.Text = "Deshabilitado";
            lblHuella.Image = Properties.Resources.huella_verificar;
            lblName.Text = "";
            MySingleton.Instance.AsistenciasVerifyOBJ = this;//Esto se ocupa para poder desactivar el lector de forma remota en esa clase
            
        }

        //Funcion del SDK
        //
        // Este metodo es especifico para el funcionamiento del lector, No remover!
        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        // Constructor del Padre CaptureForm
        protected override void Init()
        {
            base.Init();
            Verificator = new DPFP.Verification.Verification();//Crea un objeto verificador de huellas
            
        }

        //Metodo del padre que sobre escribe pero a la vez se llama en la base
        //Funcionamiento: Procesar cada que el lector detecta una huella
        //
        //Paramteros:
        //  Sample -> la muestra que es tomada directamente del lector
        // Este metodo es especifico para el funcionamiento del lector, No remover!
        //
        protected override void Process(DPFP.Sample Sample)
        {
            if (asistenciaEnable == false)
            {
                Stop(); //Este metodo es heredado, detiene la lectura del lector
                return;
            }
            base.Process(Sample);
            // Procesa la muestra
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Verifica la calidad de la muestra y continua si está correcta
            
            if (features != null)
            {
                Estudiante estudiante = new Estudiante();
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                DPFP.Template template = new DPFP.Template();
                Stream stream;

                //Descongelar si algo sale mal xD -->
                //var alumnos = State.estudianteBL.ObtenerEstudiante().Where(x => x.CodigoGrupo == GrupoCarreraSelected).ToList();

                var alumnos = State.estudianteBL.ObtenenerEstudiantesByGroup(GrupoCarreraSelected);
                var NombreAlumno = "";
                foreach (var alu in alumnos)
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

        /// <summary>
        /// Crea la asistencia en la grid del Alumno.(Cuando se marca en verde)
        /// </summary>
        /// <param name="ID">El ID del alumno que se pasará la asistencia.</param>
        /// 
        //TODO: Cambiar Nombre al Metodo
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

        /// <summary>
        /// Detiene el Lector y Termina las asistencias. (En prueba pero funcional)
        /// </summary>
        /// TODO: Mejorar el metodo
        public void StopLector()
        {
            base.Stop();
            Stop();
            asistenciaEnable = false;
            btnEnableAsis.Enabled = false; btnEnableAsis.BackColor = Color.Gray;
            btnEnableAsis.Text = "Asistencias Terminadas";
            _padre_asistencia.cbxGrupo.Enabled = true;
            MySingleton.Instance.IsAsistenciaFinished = true;

        }

        /// <summary>
        /// Crea la asistencia final, marcando las inasistencias y asistencias
        /// </summary>
        /// 
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

        /// <summary>
        /// Actualiza la informacion UI del Panel.
        /// </summary>
        /// <param name="ID">Estado de la asistencia</param>
        /// <param name="AlumnoName">El nombre del alumno(Opcional)</param>
        /// 
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

        //Este evento es el que se encarga de activar o desactivar la asistencia del dia
        //
        //TODO: Meterlo a un meotodo tal vez?
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
                _padre_asistencia.cbxGrupo.Enabled = true;
                MySingleton.Instance.IsAsistenciaFinished = true;
                Stop();
                CreateAsistencia();
                StopLector();
                MessageBox.Show("La asistencia del Día se ha guardado de forma exitosa. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }

        //Evento que se ejecuta cuando el combo box grupo de AsistenciasWF se cambia
        //Crea un Combobox y lo convierte en el Sender cbxGrupo
        //Cambia la variable GrupoCarreraSelected para saber la carrera de los alumnos a tomarle la asistencia
        private void On_cbx_grupo_changed(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            GrupoCarreraSelected = comboBox.Text;
        }

        /// <summary>
        /// Crea un temporizador especifico para restablecer el estado del panel, Solo funciona si se encuentra en el bucle de Process
        /// </summary>
        /// <param name="time">El tiempo que tendrá el temporizador.</param>
        /// 
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
