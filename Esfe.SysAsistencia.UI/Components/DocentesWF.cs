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
using DataEdit;

namespace Esfe.SysAsistencia.UI.Components
{
    public partial class DocentesWF : Form
    {

        public DocenteBL docenteBL = new DocenteBL();

        public Panel _panel_app;
        private int GloabalID;
        List<Carrera> carreras = State.carreraBL.ObtenerCarrera();
        List<NumGrupo> numGrupos = State.numGrupoBL.ObtenerNumGrupo();

        //  -------------------------- Variables para el lector --------------------------
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        //  -------------------------- Variables para el lector --------------------------

        //Instancia de la clase ErrorProvider para la validacion en los texbox
        ErrorProvider error = new ErrorProvider();
        //Instancia de la clase DialogResult para confirmacion de un messagesbox
        DialogResult result = new DialogResult();


        //public string[] carreras = State.InfoCarrera.carreras;
        public DocentesWF(Panel PanelApp)
        {
            _panel_app = PanelApp;
            InitializeComponent();
            cargarCBX();
        }

        private void cargarCBX()
        {
            ComboBox[] cbxs = new ComboBox[1] { txtCarrera };

            foreach (ComboBox combo in cbxs)
            {
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "Id";
            }

            txtCarrera.DataSource = carreras;
        }


        //------------------------------------------------------------------------
        //                                  EVENTOS
        //------------------------------------------------------------------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar si los campos obligatorios están llenos
            if (string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtDui.Text))
            {
                MsgBox msg = new MsgBox("onlywarning", "Los datos son obligatorios");
                msg.ShowDialog();
                //MessageBox.Show("Los datos son obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Template == null)
            {
                MsgBox msg = new MsgBox("onlywarning", "Aún no se ha registrado una huella");
                msg.ShowDialog();
                //MessageBox.Show("Aún no se ha registrado una huella", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var docente = new Docente()
            {
                Nombre = txtNombres.Text,
                Apellido = txtApellidos.Text,
                Cel = txtTelefono.Text,
                Dui = txtDui.Text,
                Huella = Template.Bytes,
                IdCarrera = Convert.ToByte(txtCarrera.SelectedValue)
            };

            var si = State.docenteBL.AgregarDocente(docente);
            if (si)
            {
                MsgBox msg = new MsgBox("filled", $"Se creó el grupo de forma exitosa");
                msg.ShowDialog();
            }
            else
            {
                MsgBox msg = new MsgBox("onlywarning", "¡Error en el proceso!");
                msg.ShowDialog();
            }
        }


        //Funcion para establacer un formato a la tabla

        public void RefreshGrid()
        {
            var docentes = State.docenteBL.ObtenerDocentes();

            var joinDocente = from d in docentes
                            join c in carreras on d.IdCarrera equals c.Id
                            select new
                            {
                                Id = d.Id,
                                Nombre = d.Nombre,
                                Apellido = d.Apellido,
                                Celular = d.Cel,
                                Dui = d.Dui,
                                Carrera = c.Sigla
                            };

            gridDocentes.DataSource = null;
            gridDocentes.DataSource = joinDocente.ToList();
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
                        MsgBox msg = new MsgBox("info", "¡Excelente!\nLa huella está lista.");
                        msg.ShowDialog();
                        //MessageBox.Show("La huella está lista.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MySingleton.Instance.TemplateIsNull = false;
                    MsgBox msg = new MsgBox("onlyerror", "Lo sentimos\nLa huella no es valida.");
                    msg.ShowDialog();
                    //MessageBox.Show("La huella no es valida.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            RefreshGrid();
            DgvDesing.Formato(gridDocentes, 1, false);
        }

        //Extraer los datos de la linea seleccionada del Datagriedview y los pasa a los combobox 
        private void gridDocentes_SelectionChanged(object sender, EventArgs e)
        {
            if (gridDocentes != null && gridDocentes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gridDocentes.SelectedRows[0];

                if (row != null)
                {

                    if (row.Cells[0].Value != null) GloabalID = Convert.ToInt32(row.Cells[0].Value);
                    if (row.Cells[1].Value != null) txtNombres.Text = row.Cells[1].Value.ToString();
                    if (row.Cells[2].Value != null) txtApellidos.Text = row.Cells[2].Value.ToString();
                    if (row.Cells[3].Value != null) txtTelefono.Text = row.Cells[3].Value.ToString();
                    if (row.Cells[4].Value != null) txtDui.Text = row.Cells[4].Value.ToString();
                    if (row.Cells[5].Value != null) txtCarrera.Text = row.Cells[6].Value.ToString();
                }
            }
        }

        //EDITAR REGISTRO
        // eliminar este metodo 
        private void btnModificar_Click(object sender, EventArgs e)
        {
            MsgBox msg = new MsgBox("question", "¿Desea modificar este registro?");
            msg.ShowDialog();
            //result = MessageBox.Show("¿Desea modificar este registro?", "MODIFICAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msg.DialogResult == DialogResult.OK)
            {
                try
                {
                    var teacherUpdate = new Docente
                    {
                        Id = Convert.ToInt32(gridDocentes.CurrentRow.Cells[0].Value),
                        Nombre = txtNombres.Text,
                        Apellido = txtApellidos.Text,
                        Cel = Convert.ToString(txtTelefono.Text),
                        Dui = Convert.ToString(txtDui.Text),
                        IdCarrera = Convert.ToByte(txtCarrera.SelectedValue)
                        //TODO: AGREGAR FK DE GRUPO XD
                    };

                    if (teacherUpdate != null)
                    {
                        docenteBL.ActualizarDocente(teacherUpdate);
                        var updateList = docenteBL.ObtenerDocentes();

                        gridDocentes.DataSource = null;
                        gridDocentes.DataSource = updateList;
                        MsgBox mssg = new MsgBox("filled", "Se edito el docente de forma exitosa");
                        mssg.ShowDialog();
                        //MessageBox.Show("¡Se actualizaron los datos!", "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (GloabalID == 0)
            {
                MsgBox messages = new MsgBox("onlywarning", "Es necesario selecciona un docente de la tabla");
                messages.ShowDialog();
                return;
            }
            MsgBox msg = new MsgBox("question", "¿Desea Eliminar este resgistro?\nSe eliminara permanentemente.");
            msg.ShowDialog();
            if (msg.DialogResult == DialogResult.OK)
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
                        MsgBox messages = new MsgBox("filled", "Los datos del docente han sido eliminados exitosamnte");
                        messages.ShowDialog();
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
            txtCarrera.SelectedIndex = 0;
            Template = null;
        }

        //VALIDACIONES

        private void textBox_Press(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            txt_KeyPress(txtBox, e);
        }

        private void txt_KeyPress(TextBox txtBox, KeyPressEventArgs e)
        {

            if (txtBox == txtTelefono)
            {
                bool phone = Verificar.validarNumeros(e);
                if (!phone)
                {
                    error.SetError(txtTelefono, "¡Solo números!");
                }
                else
                {
                    error.Clear();
                }
            }
            else if (txtBox == txtNombres || txtBox == txtApellidos)
            {
                bool name = Verificar.validarLetras(e);
                if (!name)
                {
                    error.SetError(txtBox, "¡Solo letras!");
                }
                else
                {
                    error.Clear();
                }
            }
            else if (txtBox == txtDui)
            {
                bool num = Verificar.validarNumeros(e);
                if (!num)
                {
                    error.SetError(txtBox, "¡Solo números!");
                }
                else
                {
                    error.Clear();
                }
            }
        }


        private void txtCarrera_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtCarrera.SelectedIndex != 0)
            {
                //new _SelectGrupo(State.InfoCarrera.idCarrera[txtCarrera.SelectedIndex - 1], ListGruposSelect).ShowDialog();

            };
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string text = txtTelefono.Text.Replace("-", "");

            if (System.Text.RegularExpressions.Regex.IsMatch(text, @"^\d{0,8}$"))
            {
                if (text.Length > 4 && text.Length <= 8)
                {
                    txtTelefono.Text = text.Substring(0, 4) + "-" + text.Substring(4);
                    txtTelefono.SelectionStart = txtTelefono.Text.Length;
                }
                else
                {
                    txtTelefono.Text = text;
                    txtTelefono.SelectionStart = txtTelefono.Text.Length;
                }
            }
        }

        private void txtDui_TextChanged(object sender, EventArgs e)
        {
            string dui = txtDui.Text.Replace("-", "");
            if (System.Text.RegularExpressions.Regex.IsMatch(dui, @"^\d{0,9}"))
            {
                if (dui.Length > 8 && dui.Length <= 9)
                {
                    txtDui.Text = dui.Substring(0, 8) + "-" + dui.Substring(8);
                    txtDui.SelectionStart = txtDui.Text.Length;
                }
                else
                {
                    txtDui.Text = dui;
                    txtDui.SelectionStart = txtDui.Text.Length;
                }
            }
        }
    }
}
