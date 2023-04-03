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
    public static class JsonData
    {
        public static void GuardarDatos()
        {
            State.docenteBL.GuadarJson();// Obtener la lista de docentes desde tu instancia de DocenteBL
            State.estudianteBL.GuadarJson();// Obtener la lista de docentes desde tu instancia de DocenteBL
            State.grupoBL.GuardarJson();// Obtener la lista de docentes desde tu instancia de DocenteBL

            MessageBox.Show("Datos guardados");
        }

    }
}
