using Esfe.SysAsistencia.UI;
using DPFP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Esfe.SysAsistencia.UI
{

    public partial class CapturarHuella : CaptureForm
    {
        public delegate void OnTemplateEventHandler(DPFP.Template template);

        public event OnTemplateEventHandler OnTemplate;


        protected override void Init()
        {
            base.Init();
            base.Text = "Dar de alta Huella";
            Enroller = new DPFP.Processing.Enrollment();// Create an enrollment.
            UpdateStatus();
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            // Check quality of the sample and add to enroller if it's good
            if (features != null) try
                {
                    //The fingerprint feature set was created1.
                    MakeReport("Muestra completada: "+Convert.ToString(5-Enroller.FeaturesNeeded)+"/4");
                    Enroller.AddFeatures(features);     // Add feature set to template.
                }
                finally
                {
                    UpdateStatus();

                    // Check if template has been created.
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:   // report success and stop capturing
                            OnTemplate(Enroller.Template);
                            SetPrompt("Click Close, and then click Fingerprint Verification.");
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
