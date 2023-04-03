using Esfe.SysAsistencia.UI;
using Esfe.SysAsistencia.UI.Helpers;
using DPFP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DPFP.Verification;
using static DPFP.Verification.Verification;
using System.IO;
using System.Collections;
using Esfe.SysAsistencia.UI.Components;
using Esfe.SysAsistencia.EN;

namespace Esfe.SysAsistencia.UI
{

    public partial class CapturarHuella : CaptureForm
    {
        public delegate void OnTemplateEventHandler(DPFP.Template template);
        public delegate void OnCompleteEventHandler(DPFP.Template template);
        private DPFP.Template Template;
        public event OnTemplateEventHandler OnTemplate;
        public event OnTemplateEventHandler OnComplete;
        private DPFP.Verification.Verification Verificator;
        private DocentesWF _padreDocentes;


        protected override void Init()
        {
            base.Init();
            base.Text = "Registrar una nueva Huella";
            Enroller = new DPFP.Processing.Enrollment();// Create an enrollment.
            Verificator = new DPFP.Verification.Verification();
            UpdateStatus();
            UpdateTitleAndDescription(0);
        }

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            // Check quality of the sample and add to enroller if it's good
            if (features != null) try
                {
                    try
                    {

                        MakeReport("Muestra completada: " + Convert.ToString(5 - Enroller.FeaturesNeeded) + "/4");
                        UpdateMuestras(Convert.ToInt32(5 - Enroller.FeaturesNeeded));
                        Enroller.AddFeatures(features);     // Add feature set to template
                    }
                    catch (Exception e)
                    {


                        MySingleton.Instance.TemplateIsNull = true;
                        MessageBox.Show("Algo salió mal con el registro de la huella, por favor repita el proceso", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UpdateMuestras(99);
                        Enroller.Clear();
                        Stop();
                        UpdateStatus();
                        OnTemplate(null);
                        Start();
                    }


                }
                finally
                {
                    UpdateStatus();

                    // Check if template has been created
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:   // report success and stop capturing

                            OnTemplate(Enroller.Template);
                            //SetPrompt("Click Close, and then click Fingerprint Verification.");
                            Stop();
                            break;

                        case DPFP.Processing.Enrollment.Status.Failed:  // report failure and restart capturing
                            Enroller.Clear();
                            Stop();
                            UpdateStatus();
                            OnTemplate(null);
                            Start();
                            break;
                    }



                }
        }

        private void UpdateStatus()
        {
            // Show number of samples needed.
            SetStatus(String.Format("Muestras de huellas necesarias: {0}", Enroller.FeaturesNeeded));
        }

        public CapturarHuella()
        {
            InitializeComponent();


        }
        private DPFP.Processing.Enrollment Enroller;
    }
}
