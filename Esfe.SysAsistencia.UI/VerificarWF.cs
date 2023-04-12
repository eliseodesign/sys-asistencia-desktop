using Esfe.SysAsistencia.UI.Helpers;
using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esfe.SysAsistencia.DAL;

namespace Esfe.SysAsistencia.UI
{

    /*
    Clase VerificarWF

    Propósito:
    Esta clase proporciona una interfaz heredada de CaptureForm
    Su proposito es verificar si la huella obtenida ya existe en algun registro

    Funcionalidades:
    - Toma de la muestra de la huella
    - Verificacion de la huella

    Componentes:
    - Los heredados por CaptureForm
    */
    public partial class VerificarWF : CaptureForm
    {

        //Vaiables
        LoginWF _padre;
        public bool respuestaVerifiation = false;
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;

        //Evento necesario para la verificacion
        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        //Constructor del padre
        protected override void Init()
        {
            base.Init();
            base.Text = "Verificación de Huella Digital";
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
            UpdateTitleAndDescription(1);
        }

        /// <summary>
        /// Actualiza el Status en el Padre. Mire: CaptureForm
        /// </summary>
        /// <param name="FAR">Ni idea :(</param>
        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));

        }

        /// <summary>
        /// Verificacion de la Huella sin el lector (ONLY TESTING)
        /// </summary>
        /// TODO: REMOVER
        private void verifyWhitout(object sender, EventArgs e)
        {
            this.CancelButton.PerformClick();
            foreach (var doc in State.docenteBL.ObtenerDocentes())
            {
                if (doc.Nombres == cbxPersons.Text)
                {
                    State.DocenteLoged = doc;
                    _padre.LoginDocente(true);
                }
                else
                {
                    _padre.LoginDocente(false);
                }
            }
            
        }

        //Ya explique esto, ya me aburri. chequen CaptureForm y CapturarHuella
        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);


            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                Docente docenteVar = new Docente();
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                DPFP.Template template = new DPFP.Template();
                Stream stream;
                var docentes = State.docenteBL.ObtenerDocentes();
                foreach (var emp in docentes)
                {
                    docenteVar = emp;
                    stream = new MemoryStream(emp.Huella);
                    template = new DPFP.Template(stream);

                    Verificator.Verify(features, template, ref result);
                    UpdateStatus(result.FARAchieved);
                    if (result.Verified)
                    {
                        MakeReport("Huella verificada " + emp.Nombres);
                        MakeReport("Por favor cierre el formulario.");
                        UpdateMuestras(1);
                        respuestaVerifiation = true;
                        Stop();
                        break;
                    }
                }

                if (respuestaVerifiation)
                {
                    State.DocenteLoged = docenteVar;
                    Stop();

                }
                else
                {
                    MakeReport("No se reconoce ninguna huella");
                }
            }
        }

        public VerificarWF(LoginWF padre, bool initWhitoutScanner = false)
        {
            _padre = padre;
            base.FormClosing += new FormClosingEventHandler(VerificarWF_FormClosing);

            //TODO: ELIMINAR
            foreach (var doc in State.docenteBL.ObtenerDocentes())
            {
                cbxPersons.Items.Add(doc.Nombres);
            }
            cbxPersons.SelectedIndexChanged += new EventHandler(verifyWhitout);

        }

        private void VerificarWF_FormClosing(object sender, FormClosingEventArgs e)
        {

            _padre.LoginDocente(respuestaVerifiation);
        }
    }
}
