using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esfe.SysAsistencia.EN;
using Esfe.SysAsistencia.UI.Helpers;

namespace Esfe.SysAsistencia.UI.Components
{
    public partial class AsistenciaWF : Form
    {
        public Panel _panel_app;

        public AsistenciaWF(Panel panel)
        {
            _panel_app = panel;
            InitializeComponent();
            SetGridFormatStyle(gridAsistencia);
            var codigos = State.DocenteLoged.GrupoCodigos;
            cbxGrupo.DataSource = null;
            cbxGrupo.DataSource = codigos;
            Panels.AgregarPanel(panelVerificar, new VerificarAsistenciaWF(this, cbxGrupo.SelectedValue.ToString()));
        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string grupo = cbxGrupo.SelectedValue.ToString();
            List<Estudiante> lista = new List<Estudiante>();
            foreach (var ee in State.estudianteBL.ObtenerEstudiante())
            {
                if (ee.CodigoGrupo == grupo)
                {
                    lista.Add(ee);
                }
            }

            gridAsistencia.DataSource = null;
            gridAsistencia.DataSource = lista;

        }

        public void SetGridFormatStyle(DataGridView dataGridView)
        {

            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnCount = 3;

            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[0].DataPropertyName = "Id";
            dataGridView.Columns[0].Width = 50;

            dataGridView.Columns[1].Name = "Nombre";
            dataGridView.Columns[1].DataPropertyName = "Nombres";
            dataGridView.Columns[1].Width = 200;

            dataGridView.Columns[2].Name = "Apellidos";
            dataGridView.Columns[2].DataPropertyName = "Apellidos";
            dataGridView.Columns[2].Width = 200;

            // Establecer el estilo de celda predeterminado para las filas de datos
            DataGridViewCellStyle dataCellStyle = new DataGridViewCellStyle();
            dataCellStyle.BackColor = ColorTranslator.FromHtml("#f69e7d");
            dataCellStyle.ForeColor = Color.Black;
            dataGridView.DefaultCellStyle = dataCellStyle;

            // Establecer el estilo de celda para la fila de encabezado
            DataGridViewCellStyle headerCellStyle = new DataGridViewCellStyle();
            headerCellStyle.BackColor = ColorTranslator.FromHtml("#780000");
            headerCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle = headerCellStyle;

            // Establecer el estilo de celda para la fila seleccionada
            DataGridViewCellStyle selectedCellStyle = new DataGridViewCellStyle();
            selectedCellStyle.BackColor = ColorTranslator.FromHtml("#0401ad");
            selectedCellStyle.ForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#0401ad");
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Establecer el estilo de celda predeterminado para las columnas de datos
            dataCellStyle.BackColor = ColorTranslator.FromHtml("#f69e7d");
            dataCellStyle.ForeColor = Color.Black;
            dataGridView.Columns[0].DefaultCellStyle = dataCellStyle;
            dataGridView.Columns[1].DefaultCellStyle = dataCellStyle;
            dataGridView.Columns[2].DefaultCellStyle = dataCellStyle;

            // Establecer el estilo de celda para la celda de encabezado de la primera columna

            headerCellStyle.BackColor = ColorTranslator.FromHtml("#780000");
            headerCellStyle.ForeColor = Color.White;
            dataGridView.Columns[0].HeaderCell.Style = headerCellStyle;

            // Establecer el estilo de celda para la celda seleccionada de la segunda columna

            selectedCellStyle.BackColor = ColorTranslator.FromHtml("#0401ad");
            selectedCellStyle.ForeColor = Color.White;
            dataGridView.Columns[1].DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#0401ad");
            dataGridView.Columns[1].DefaultCellStyle.SelectionForeColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var asis = State.asistenciaBL.ObtenerAsistencias();
            var Str = "";
            foreach (var a in asis)
            {

                Str += "\n ================= " +
                    "\n Alumno ID: " + a.AlumnoId.ToString() +
                    "\n Nombre: " + State.estudianteBL.ObtenerEstudiante().FirstOrDefault(e => e.Id == a.AlumnoId).Nombres +
                    "\n Fecha: " + a.Fecha.ToString() +
                    "\n Criterio: " + a.Criterio.ToString();
            }

            MessageBox.Show("La lista de asistencia de hoy es: \n" + Str, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
