using Esfe.SysAsistencia.BL;
using Esfe.SysAsistencia.UI.Helpers;
using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esfe.SysAsistencia.DAL;
using static DPFP.Verification.Verification;
using DataEdit;

namespace Esfe.SysAsistencia.UI.Components
{
    public partial class AlumnosWF : Form
    {
        //  -------------------------- Variables para el lector --------------------------
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        //  -------------------------- Variables para el lector --------------------------
        //Clase para las validaciones de campos
        ErrorProvider error = new ErrorProvider();
        DialogResult result = new DialogResult();
        List<Carrera> carreras = State.carreraBL.ObtenerCarrera();
        List<Anio> anios = State.anioBL.ObtenerAnio();
        List<NumGrupo> numGrupos = State.numGrupoBL.ObtenerNumGrupo();
        List<Grupo> grupos = State.grupoBL.ObtenerGrupos();
        public EstudianteBL estudianteBL = new EstudianteBL();
        int ID;
        public Panel _panel_app;
        public AlumnosWF(Panel panel)
        {
            _panel_app = panel;
            InitializeComponent();
            SetGridFormat();
            RefreshGrid();
            cargarCBX();
        }
        private void cargarCBX() 
        { 
           cbxCarrera.DisplayMember = "Nombre";
           cbxCarrera.ValueMember = "Id";
 
            cbxCarrera.DataSource = carreras;
        }

        public void LimpiarDatos()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtDui.Text = "";
            cbxCarrera.SelectedIndex = 0;
            Template = null;
        }

        //Signals
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validacion de campos
            if (string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtDui.Text))
            {
                MsgBox msg = new MsgBox("onlywarning", "Todos los datos son obligatorios");
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
            //Creacion del Alumno
            var estudiante = new Estudiante()
            {
                Nombre = txtNombres.Text,
                Apellido = txtApellidos.Text,
                Cel = txtTelefono.Text,
                Dui = txtDui.Text,
                Huella = Template.Bytes,
                IdGrupo = Convert.ToByte(cbxGrupo.SelectedValue)

            };
            if (ID == 0)
            {

                //Agregar alumno al BL
                var result = State.estudianteBL.AgregarEstudiante(estudiante);
                if (!result)
                {
                    MsgBox msg = new MsgBox("onlyerror", "¡No se puede registrar con la misma huella!\nDebe de registrar otra huella.");
                    msg.ShowDialog();
                    //MessageBox.Show("No se puede registrar con la misma huella!", "ERROR GRAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RefreshGrid();
                    MsgBox msg = new MsgBox("filled", "Se regitró al estudiante de forma exitosa");
                    msg.ShowDialog();
                    //MessageBox.Show("Se regitró al estudiante de forma exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                var result = State.estudianteBL.ActualizarEstudiante(estudiante);
                if (!result)
                {
                    MsgBox msg = new MsgBox("onlyerror", "¡No se puede registrar con la misma huella!\nDebe de registrar otra huella.");
                    msg.ShowDialog();
                    //MessageBox.Show("No se puede registrar con la misma huella!", "ERROR GRAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                  
                    MsgBox msg = new MsgBox("filled", "Se edito el estudiante de forma exitosa");
                    msg.ShowDialog();
                    //MessageBox.Show("Se edito el estudiante de forma exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            ID = 0;
            RefreshGrid();
        }

        //Refrescar Tabla
        void RefreshGrid()
        {
            var estudiantes = State.estudianteBL.ObtenerEstudiantes();
            if (estudiantes.Count == 0) return; // si es cero, se retorna

            var join = from e in estudiantes
                       join g in grupos on e.IdGrupo equals g.Id
                       join n in numGrupos on g.IdNumGrupo equals n.Id
                       join c in carreras on g.IdCarrera equals c.Id
                       join a in anios on g.IdAnio equals a.Id
                       select new
                       {
                           Id = e.Id,
                           Nombre = e.Nombre,
                           Apellido = e.Apellido,
                           Celular = e.Cel,
                           Dui = e.Dui,
                           Grupo = "G" + n.Nombre[n.Nombre.Length - 1] + "-" + a.Nombre.Substring(0, 1) + c.Sigla
                       };
            gridEstudiantes.DataSource = null;
            gridEstudiantes.DataSource = join.ToList();
        }

        //Darle formato a la tabla
        public void SetGridFormat()
        {

        }

        //Abrir form para la huella
        private void btnChangeHuella_Click_1(object sender, EventArgs e)
        {
            CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();  //crea un nuevo form para capturar la huella
        }

        //OnTemplate: Señal que se emite cuando se termina la captura de la huella

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

        private void AlumnosWF_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string phone = txtTelefono.Text.Replace("-", "");

            if (System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{0,8}"))
            {
                if (phone.Length > 4 && phone.Length <= 8)
                {
                    txtTelefono.Text = phone.Substring(0, 4) + "-" + phone.Substring(4);
                    txtTelefono.SelectionStart = txtTelefono.Text.Length;
                }
                else
                {
                    txtTelefono.Text = phone;
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


        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (ID == 0)
            {
                MsgBox messages = new MsgBox("onlywarning", "Es necesario selecciona un estudiante de la tabla");
                messages.ShowDialog();
                return;
            }
            MsgBox msg = new MsgBox("question", "¿Desea Eliminar este resgistro?\nSe eliminará permanentemente.");
            msg.ShowDialog();

            if (msg.DialogResult == DialogResult.OK)
            {
                try
                {
                    //Eliminar registros del datagriedview

                    var delete = new Estudiante()
                    {
                        //Captura el Id de la linea seleccionada
                        Id = Convert.ToInt32(gridEstudiantes.CurrentRow.Cells[0].Value)
                    };

                    if (delete != null)
                    {
                        estudianteBL.EliminarEstudiante(delete);
                        var updateList = estudianteBL.ObtenerEstudiantes();

                        gridEstudiantes.DataSource = null;
                        gridEstudiantes.DataSource = updateList;
                        MsgBox messages = new MsgBox("filled", "Los datos del estudiante han sido eliminados exitosamente");
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

        private void gridDocentes_SelectionChanged(object sender, EventArgs e)
        {
            if (gridEstudiantes != null && gridEstudiantes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gridEstudiantes.SelectedRows[0];

                if (row != null)
                {

                    if (row.Cells[0].Value != null) ID = Convert.ToInt32(row.Cells[0].Value);
                    if (row.Cells[1].Value != null) txtNombres.Text = row.Cells[1].Value.ToString();
                    if (row.Cells[2].Value != null) txtApellidos.Text = row.Cells[2].Value.ToString();
                    if (row.Cells[3].Value != null) txtTelefono.Text = row.Cells[3].Value.ToString();
                    if (row.Cells[4].Value != null) txtDui.Text = row.Cells[4].Value.ToString();
                    var idGruop = estudianteBL.ObtenerEstudiantes().FirstOrDefault(x => x.Id == Convert.ToInt32(row.Cells[0].Value)).IdGrupo;
                    ID = idGruop;
                    if (row.Cells[5].Value != null) cbxCarrera.SelectedValue = grupos.FirstOrDefault(x => x.Id == idGruop).IdCarrera;//TODO reparar 
                    cbxCarrera_SelectedValueChanged(null, new EventArgs());
                }
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            DgvDesing.Formato(gridEstudiantes, 1, false);
        }

        private void cbxCarrera_SelectedValueChanged(object sender, EventArgs e)
        {

           

            cbxGrupo.DisplayMember = "Codigo";
            cbxGrupo.ValueMember = "Id";
            if (cbxCarrera.SelectedIndex > -1)
            {
                var join = from g in grupos
                           join n in numGrupos on g.IdNumGrupo equals n.Id
                           join c in carreras on g.IdCarrera equals c.Id
                           join a in anios on g.IdAnio equals a.Id
                           select new
                           {
                               Id = g.Id,
                               Codigo = "G" + n.Nombre[n.Nombre.Length - 1] + "-" + a.Nombre.Substring(0, 1) + c.Sigla,
                               IdCarrera = c.Id
                           };
                cbxGrupo.DataSource = join.Where(x=> x.IdCarrera == Convert.ToByte(cbxCarrera.SelectedValue)).ToList();

            }

            
        }
    }
}
