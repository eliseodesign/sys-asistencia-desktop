using Esfe.SysAsistencia.EN;
using Esfe.SysAsistencia.BL;
using Esfe.SysAsistencia.UI.Helpers;
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

    public partial class DocentesWF : Form
    {
        //public DocenteBL docenteBL = new DocenteBL();

        public Panel _panel_app;

        //  -------------------------- Variables para el lector --------------------------
        private DPFP.Template Template;
        //  -------------------------- Variables para el lector --------------------------
        public DocentesWF(Panel PanelApp)
        {
            _panel_app = PanelApp;
            InitializeComponent();
            SetGridFormat();

            string[] carreras = new string[4] { "Téc. ing Electica", "Téc. ing de Desarrollo De Software", "Téc en Mercadeo", "Téc. en Gestión y Desarrollo Turístico" };
            txtCarrera.DataSource = carreras;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar si los campos obligatorios están llenos
            if (string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtDui.Text))
            {
                MessageBox.Show("Los datos son obligatorios");
                return;
            }
            var docente = new Docente()
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Cel = txtTelefono.Text,
                Dui = txtDui.Text,
                Nit = txtNit.Text,
                Huella = Template.Bytes
            };

            State.BL.AgregarDocente(docente);
            Listar();
            MessageBox.Show("Se regitró al docente de forma exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //MySingleton.Instance.
        }

        //Funcion para establacer un formato a la tabla

        public void Listar()
        {
            
            var docentes = State.BL.ObtenerDocentes();
            if (docentes.Count == 0) return;
            gridDocentes.DataSource = null;
            gridDocentes.DataSource = docentes;
        }

        public void SetGridFormat()
        {
            gridDocentes.AutoGenerateColumns = false;
            gridDocentes.ColumnCount = 2;

            gridDocentes.Columns[0].Name = "ID";
            gridDocentes.Columns[0].DataPropertyName = "Id";
            gridDocentes.Columns[0].Width = 50;

            gridDocentes.Columns[1].Name = "Nombre";
            gridDocentes.Columns[1].DataPropertyName = "Nombres";
            gridDocentes.Columns[1].Width = 200;
        }

        private void btnChangeHuella_Click(object sender, EventArgs e)
        {
            CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();  //crea un nuevo form para capturar la huella
        }

        // Ontemplate: Señal del Lector cuando se ha completado la captura
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                btnGuardar.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
                    //txtHuella.Text = "Huella capturada correctamente";
                }
                else
                {
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
                }
            }));
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Listar();   
        }
    }
}
