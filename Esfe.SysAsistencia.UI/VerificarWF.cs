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
    public partial class VerificarWF : CaptureForm
    {

        //Vaiables
        LoginWF _padre;
        public bool res = false;
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        
        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Verificación de Huella Digital";
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
            UpdateTitleAndDescription(1);
        }

        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }

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
                        res = true;
                        Stop();
                        break;
                    }
                }

                if (res)
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

        public VerificarWF(LoginWF padre)
        {
            InitializeComponent();
            _padre = padre;
        }

        public VerificarWF(AplicationWF app)
        {
            InitializeComponent();

        }

        private void VerificarWF_FormClosing(object sender, FormClosingEventArgs e)
        {
            _padre.LoginDocente(res);
        }
    }
}
