using Esfe.SysAsistencia.DAL.BD;
using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.DAL
{
    /// <summary>
    /// Clase que se encarga de almacenar Estudianes y contiene los metodo para menjar su información
    /// </summary>
    public class EstudianteDAL
    {
        public List<Estudiante> ObtenerEstudiantes()
        {
            return ComunBD.EjecutarSPSelect<Estudiante>("SPReadEstudiante");
        }

        public bool ActualizarEstudiante(Estudiante update)
        {
            List<string> parametros = new() { "Id", "Nombre", "Apellido", "Dui", "Cel", "Huella", "IdGrupo" };
            int valor = ComunBD.EjecutarSP("SPUpdateEstudiante", update, parametros);
            return valor > 0;
        }

        public bool AgregarEstudiante(Estudiante docente)
        {
            List<string> parametros = new() { "Nombre", "Apellido", "Dui", "Cel", "Huella", "IdGrupo" };
            int valor = ComunBD.EjecutarSP("SPCreateEstudiante", docente, parametros);
            return valor > 0;

        }

        public bool EliminarEstudiante(Estudiante docente)
        {
            List<string> parametros = new() { "Id" };
            int valor = ComunBD.EjecutarSP("SPDeleteEstudiante", docente, parametros);
            return valor > 0;
        }

    }
}
