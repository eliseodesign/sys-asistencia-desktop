using Esfe.SysAsistencia.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Esfe.SysAsistencia.UI.Helpers
{
    /// <summary>
    /// Clase estática que proporciona funcionalidad para guardar datos en formato JSON.
    /// </summary>
    public static class JsonData
    {
        /// <summary>
        /// Guarda los datos de docentes, estudiantes y grupos en formato JSON.
        /// </summary>
        public static void GuardarDatos()
        {
            State.docenteBL.GuadarJson(); // Obtener la lista de docentes desde tu instancia de DocenteBL
            State.estudianteBL.GuadarJson(); // Obtener la lista de estudiantes desde tu instancia de EstudianteBL
            State.grupoBL.GuardarJson(); // Obtener la lista de grupos desde tu instancia de GrupoBL

            MessageBox.Show("Datos guardados");
        }
    }

}
