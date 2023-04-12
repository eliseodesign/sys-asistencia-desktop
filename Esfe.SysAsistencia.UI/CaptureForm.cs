using DPFP;
using Esfe.SysAsistencia.UI;
using Esfe.SysAsistencia.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Esfe.SysAsistencia.UI
{
    /*
    Clase CaptureForm

    Propósito:
    Esta clase proporciona una interfaz para la captura y verificacion de la huella con el lector
    Todas las clases hijas de este formulario heredan las propiedades y metodos de este formulario y el SDK del lector

    Funcionalidades:
    - Procesa las muestras de las huellas y el Template
    - Activa y Desactiva el Lector
    - Maneja todos los eventos dele lector, cuando detecta huella, cuando termina el proceso, etc.
    - Cambiar las propiedades de los metodos de forma remota con Invoke

    Componentes:
    - PictureBox -> Picture: Donde se muestra la imagen de la huella
    - Label -> LabelMuestra1 - LabelMuestra4: para cambiar el icono de la huella si ya detecto la muestra
    - Button -> CloseButton: para cerrar el formulario desactivar e lector
    - TextBox -> StatusText: Para añadir texto en donde se de el informe actual de la toma de las huellas

    */
    delegate void Function();

    public partial class CaptureForm : Form, DPFP.Capture.EventHandler
    {

        public CaptureForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Inicia el Constructor de esta clase para crear la captura
        /// </summary>
        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();// Create a capture operation.

                if (null != Capturer)
                    Capturer.EventHandler = this;// Subscribe for capturing events.
                else
                    SetPrompt("No se pudo iniciar la operación de captura");
            }
            catch
            {
                MessageBox.Show("No se pudo iniciar la operación de captura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Dibuja la huella en una imagen con los Bytes
        /// </summary>
        /// <param name="Sample">La muestra de la huella</param>
        protected virtual void Process(DPFP.Sample Sample)
        {
            // Draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(Sample));
        }

        /// <summary>
        /// Activa el Lector
        /// </summary>
        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Escanea tu huella usando el lector");
                }
                catch
                {
                    SetPrompt("No se puede iniciar la captura");
                }
            }
        }

        /// <summary>
        /// Desactiva el lector
        /// </summary>
        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("No se puede terminar la captura");
                }
            }
        }

        //A lo demás si le se pero me dio hueva documentar ajshajsasajshjasjasad
        //de todos modos nadie leera esto y no servira para nada ¿o si?

        #region Form Event Handlers:

        private void CaptureForm_Load(object sender, EventArgs e)
        {
            Init();
            Start();                                                // Start capture operation.
        }

        private void CaptureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }
        #endregion


        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            MakeReport("Muestra de la huella Capturada");

            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            //MakeReport("La huella fue removida del lector");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            //MakeReport("El lector fue tocado");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("El Lector de huellas ha sido conectado");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("El Lector de huellas ha sido desconectado");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("La calidad de la muestra es BUENA");
            else
                MakeReport("La calidad de la muestra es MALA");
        }
        #endregion

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();  // Create a sample convertor.
            Bitmap bitmap = null;                                                           // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);                                 // TODO: return bitmap as a result
            return bitmap;
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        protected void SetStatus(string status)
        {
            this.Invoke(new Function(delegate ()
            {
                StatusLine.Text = status;
            }));
        }

        protected void SetPrompt(string prompt)
        {
            this.Invoke(new Function(delegate ()
            {
                //Prompt.Text = prompt;
            }));
        }
        protected void MakeReport(string message)
        {
            this.Invoke(new Function(delegate ()
            {
                StatusText.AppendText(message + "\r\n");

            }));
        }

        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate ()
            {
                Picture.Image = new Bitmap(bitmap, Picture.Size);   // fit the image into the picture box
            }));
        }
        // MIAS
        protected void UpdateTitleAndDescription(int idx) //0=Registrar huella; 1=Verificar huella
        {
            if (idx == 0)
            {
                this.Invoke(new Function(delegate ()
                {
                    lblTitle.Text = "Registrar nueva huella";
                    lblDescription.Text = "Por favor, complete las cuatro muestras de huellas necesarias.";
                }));
            }
            else
            {
                this.Invoke(new Function(delegate ()
                {
                    lblTitle.Text = "Escanear Huella";
                    lblDescription.Text = "Por favor, escanee su huella para completar el proceso.";
                    lblMuestra2.Image = Properties.Resources.huella_verificar; lblMuestra2.Text = "Innecesaria";
                    lblMuestra3.Image = Properties.Resources.huella_verificar; lblMuestra3.Text = "Innecesaria";
                    lblMuestra4.Image = Properties.Resources.huella_verificar; lblMuestra4.Text = "Innecesaria";
                }));
            }
        }

        protected void UpdateMuestras(int idxMuestra)
        {
            this.Invoke(new Function(delegate ()
            {
                switch (idxMuestra)
                {
                    case 1: lblMuestra1.Text = "Completa"; lblMuestra1.Image = Properties.Resources.huella_completa; break;
                    case 2: lblMuestra2.Text = "Completa"; lblMuestra2.Image = Properties.Resources.huella_completa; break;
                    case 3: lblMuestra3.Text = "Completa"; lblMuestra3.Image = Properties.Resources.huella_completa; break;
                    case 4: lblMuestra4.Text = "Completa"; lblMuestra4.Image = Properties.Resources.huella_completa; break;
                    case 99:
                        lblMuestra1.Text = "Incompleta"; lblMuestra1.Image = Properties.Resources.huella_dactilar_;
                        lblMuestra2.Text = "Incompleta"; lblMuestra2.Image = Properties.Resources.huella_dactilar_;
                        lblMuestra3.Text = "Incompleta"; lblMuestra3.Image = Properties.Resources.huella_dactilar_;
                        lblMuestra4.Text = "Incompleta"; lblMuestra4.Image = Properties.Resources.huella_dactilar_; break;
                }
            }));
        }

        private DPFP.Capture.Capture Capturer;

        private void btnScan_Click(object sender, EventArgs e)
        {

        }

        private void cbxPersons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}