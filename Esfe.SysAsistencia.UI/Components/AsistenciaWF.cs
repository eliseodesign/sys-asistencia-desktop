using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esfe.SysAsistencia.BL;
using Esfe.SysAsistencia.EN;
using Esfe.SysAsistencia.UI.Helpers;

namespace Esfe.SysAsistencia.UI.Components
{

    /*
    Clase AsistenciaWF

    Propósito:
    Esta clase proporciona una interfaz para que el docente pueda registrar la asistencia de los alumnos en una sesión de clase. 

    Funcionalidades:
    - Muestra una lista de estudiantes en un grupo seleccionado por el docente.
    - Permite al docente marcar la asistencia de cada alumno en la lista.
    - Guarda los registros en su respectivas capas BL -> DAl

    Componentes:
    - ComboBox para seleccionar el grupo.
    - DataGridView para mostrar la lista de estudiantes.
    - Botones para guardar y cancelar la asistencia.
    */

    public partial class AsistenciaWF : Form
    {

        public AsistenciaWF()
        {
            InitializeComponent();
            //Inicializacion de variables para los Componentes ->
            SetGridFormatStyle(gridAsistencia, 3); // Se le da formato a la Grid
            Panels.AgregarPanel(panelVerificar, new VerificarAsistenciaWF(this, cbxGrupo.SelectedValue.ToString()));// Se añade el FormVerificar
        }

        // Este evento se dispara cuando se cambia la selección del ComboBox de grupos.
        // Su propósito es mostrar en el grid los alumnos que pertenecen al grupo seleccionado.
        // Se obtienen los alumnos del grupo seleccionado a través del servicio de alumnos y se añaden al grid.
        // Si no hay alumnos en el grupo seleccionado, se muestra un mensaje en el grid indicando que no hay resultados.
        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string grupo = cbxGrupo.SelectedValue.ToString();
            //var lista = State.estudianteBL.ObtenenerEstudiantesByGroup(grupo);
            //gridAsistencia.DataSource = null;
            //gridAsistencia.DataSource = lista;

        }

        /// <summary>
        /// Da formato y estilo al DataGridView especificado.
        /// </summary>
        /// <param name="dataGridView">El DataGridView al que se le dará formato.</param>

        public void SetGridFormatStyle(DataGridView dataGridView, int ColumnCount)
        {
            /*ar codigos = State.DocenteLoged.GrupoCodigos;*/
            cbxGrupo.DataSource = null;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnCount = ColumnCount;

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


            //cbxGrupo.DataSource = codigos;

        }



        //Este evento es cuando el Boton de Asistencias del Día se presiona
        //
        //Funcion: Lo que hace es obtener una lista de asistencias de tipo Asistencia
        //
        // TODO: REMOVER o REEMPLAZAR

        private void button1_Click(object sender, EventArgs e)
        {
            //var asis = State.asistenciaBL.ObtenerAsistencias();
            //var Str = "";
            //foreach (var a in asis)
            //{

            //    Str += "\n ================= " +
            //        "\n Alumno ID: " + a.AlumnoId.ToString() +
            //        "\n Nombre: " + State.estudianteBL.ObtenerEstudiante().FirstOrDefault(e => e.Id == a.AlumnoId).Nombres +
            //        "\n Fecha: " + a.Fecha.ToString() +
            //        "\n Criterio: " + a.Criterio.ToString();
            //}

            //MessageBox.Show("La lista de asistencia de hoy es: \n" + Str, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
