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

    /*
    Clase CapturarHuella

    Propósito:
    Esta clase proporciona una interfaz heredada de CaptureForm. Esta clase se utiliza para capturar y registrar la huella

    Funcionalidades:
    - Tomar 4 muestras de huellas del lector
    - Convertir muestras en un Template
    - Guardar la muestra en el objeto correspondiente

    Componentes:
    - Los heredados de CaptureForm
    */

    public partial class CapturarHuella : CaptureForm
    {
        public CapturarHuella()
        {
            cbxPersons.Hide(); //TODO: REMOVER Y BORRAR EL COMPONENTE cbxPersons

        }
        public delegate void OnTemplateEventHandler(DPFP.Template template);
        public delegate void OnCompleteEventHandler(DPFP.Template template);
        private DPFP.Template Template;
        public event OnTemplateEventHandler OnTemplate;
        public event OnTemplateEventHandler OnComplete;

        //Constructor deñ padre
        protected override void Init()
        {
            base.Init();
            base.Text = "Registrar una nueva Huella";
            Enroller = new DPFP.Processing.Enrollment();// Crea un objeto Enroller (donde se almacena la huella)
            UpdateStatus();
            UpdateTitleAndDescription(0);
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
            base.Process(Sample);

            // Procesa la muestra
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            // Verifica la calidad de la muestra y continua si está correcta
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

        /// <summary>
        /// Actualiza el status del CaptureForm
        /// </summary>
        private void UpdateStatus()
        {
            // Show number of samples needed.
            SetStatus(String.Format("Muestras de huellas necesarias: {0}", Enroller.FeaturesNeeded));
        }


        private DPFP.Processing.Enrollment Enroller;
    }
}
