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
using DPFP.Verification;
using DPFP;
using Esfe.SysAsistencia.DAL;

namespace Esfe.SysAsistencia.UI.Components
{
    public partial class DocentesWF : Form
    {
        public DocenteBL docenteBL = new DocenteBL();

        public Panel _panel_app;

        public List<string> ListGruposSelect = new List<string>(); // nos servira para almacenar los grupos elegidos

        //  -------------------------- Variables para el lector --------------------------
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        //  -------------------------- Variables para el lector --------------------------

        //Instancia de la clase ErrorProvider para la validacion en los combobox
        ErrorProvider error = new ErrorProvider();
        //Instancia de la clase DialogResult para confirmacion de un messagesbox
        DialogResult result = new DialogResult();

        //public string[] carreras = State.InfoCarrera.carreras;
        public DocentesWF(Panel PanelApp)
        {
            _panel_app = PanelApp;
            InitializeComponent();
            SetGridFormat();

            string[] carreras = new string[5] { "", "Téc. ing Electica", "Téc. ing de Desarrollo De Software", "Téc en Mercadeo", "Téc. en Gestión y Desarrollo Turístico" };
            txtCarrera.DataSource = carreras;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar si los campos obligatorios están llenos
            if (string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtDui.Text))
            {
                MessageBox.Show("Los datos son obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Template == null)
            {
                MessageBox.Show("Aún no se ha registrado una huella", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var docente = new Docente()
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Cel = txtTelefono.Text,
                Dui = txtDui.Text,
                Nit = txtNit.Text,
                Huella = Template.Bytes,
                GrupoCodigos = ListGruposSelect
                
            };

            var result = State.docenteBL.AgregarDocente(docente);
            if (!result)
            {
                MessageBox.Show("No se puede registrar con la misma huella!", "ERROR GRAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RefreshGrid();
                MessageBox.Show("Se regitró al docente de forma exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Funcion para establacer un formato a la tabla

        public void RefreshGrid()
        {

            var docentes = State.docenteBL.ObtenerDocentes();
            if (docentes.Count == 0) return;
            gridDocentes.DataSource = null;
            gridDocentes.DataSource = docentes;
        }

        public void SetGridFormat()
        {
            gridDocentes.AutoGenerateColumns = false;
            gridDocentes.ColumnCount = 7;

            gridDocentes.Columns[0].Name = "ID";
            gridDocentes.Columns[0].DataPropertyName = "Id";
            gridDocentes.Columns[0].Width = 50;

            gridDocentes.Columns[1].Name = "Nombre";
            gridDocentes.Columns[1].DataPropertyName = "Nombres";
            gridDocentes.Columns[1].Width = 200;

            gridDocentes.Columns[2].Name = "Apellidos";
            gridDocentes.Columns[2].DataPropertyName = "Apellidos";
            gridDocentes.Columns[2].Width = 200;

            gridDocentes.Columns[3].Name = "Telefono";
            gridDocentes.Columns[3].DataPropertyName = "Cel";
            gridDocentes.Columns[3].Width = 200;

            gridDocentes.Columns[4].Name = "DUI";
            gridDocentes.Columns[4].DataPropertyName = "Dui";
            gridDocentes.Columns[4].Width = 200;

            gridDocentes.Columns[5].Name = "NIT";
            gridDocentes.Columns[5].DataPropertyName = "Nit";
            gridDocentes.Columns[5].Width = 200;

            gridDocentes.Columns[6].Name = "Carrera";
            gridDocentes.Columns[6].DataPropertyName = "carrera";
            gridDocentes.Columns[6].Width = 200;
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
                    //Comprobar si la huella existe->
                    if (!MySingleton.Instance.TemplateIsNull)
                    {
                        var huellaExist = false;

                        if (huellaExist) return;
                        //Exito->
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            RefreshGrid();
        }

        //Extraer los datos de la linea seleccionada del Datagriedview y los pasa a los combobox 
        private void gridDocentes_SelectionChanged(object sender, EventArgs e)
        {
            if (gridDocentes != null && gridDocentes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gridDocentes.SelectedRows[0];

                if (row != null)
                {
                    if (row.Cells[1].Value != null) txtNombres.Text = row.Cells[1].Value.ToString();
                    if (row.Cells[2].Value != null) txtApellidos.Text = row.Cells[2].Value.ToString();
                    if (row.Cells[3].Value != null) txtTelefono.Text = row.Cells[3].Value.ToString();
                    if (row.Cells[4].Value != null) txtDui.Text = row.Cells[4].Value.ToString();
                    if (row.Cells[5].Value != null) txtNit.Text = row.Cells[5].Value.ToString();
                    if (row.Cells[6].Value != null) txtCarrera.Text = row.Cells[6].Value.ToString();
                }
            }
        }

        //EDITAR REGISTRO
        private void btnModificar_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("¿Desea modificar este registro?", "MODIFICAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var teacherUpdate = new Docente
                    {
                        Id = Convert.ToInt32(gridDocentes.CurrentRow.Cells[0].Value),
                        Nombres = txtNombres.Text,
                        Apellidos = txtApellidos.Text,
                        Cel = Convert.ToString(txtTelefono.Text),
                        Dui = Convert.ToString(txtDui.Text),
                        Nit = Convert.ToString(txtNit.Text),
                        carrera = txtCarrera.Text

                    };

                    if (teacherUpdate != null)
                    {
                        docenteBL.ModificarDocente(teacherUpdate);
                        var updateList = docenteBL.ObtenerDocentes();

                        gridDocentes.DataSource = null;
                        gridDocentes.DataSource = updateList;
                        MessageBox.Show("¡Se actualizaron los datos!", "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarDatos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }


        //ELIMINAR REGISTRO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("¿Desea Eliminar este resgistro?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //Eliminar registros del datagriedview
                    var delete = new Docente()
                    {
                        //Captura el Id de la linea seleccionada
                        Id = Convert.ToInt32(gridDocentes.CurrentRow.Cells[0].Value)
                    };
                    if (delete != null)
                    {
                        docenteBL.EliminarDocente(delete);
                        var updateList = docenteBL.ObtenerDocentes();

                        gridDocentes.DataSource = null;
                        gridDocentes.DataSource = updateList;
                        MessageBox.Show("Se elimaron los datos!", "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarDatos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Limpiar los campos del formlario
        public void LimpiarDatos()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtDui.Text = "";
            txtNit.Text = "";
            txtCarrera.SelectedIndex = 0;
            Template = null;
        }

        //VALIDACIONES
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            bool phone = Verificar.validarNumeros(e);
            if (!phone)
            {
                error.SetError(txtTelefono, "Solo números!");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool name = Verificar.validarLetras(e);
            if (!name)
            {
                error.SetError(txtNombres, "¡Solo letras!");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool lastName = Verificar.validarLetras(e);
            if (!lastName)
            {
                error.SetError(txtApellidos, "¡Solo letras!");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dui = Verificar.validarNumeros(e);
            if (!dui)
            {
                error.SetError(txtDui, "¡Solo numeros!");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool nit = Verificar.validarNumeros(e);
            if (!nit)
            {
                error.SetError(txtNit, "¡Solo numeros!");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtCarrera_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtCarrera.SelectedIndex != 0)
            {
                new _SelectGrupo(State.InfoCarrera.idCarrera[txtCarrera.SelectedIndex - 1], ListGruposSelect).ShowDialog();

            };
        }
    }
}
