using Esfe.SysAsistencia.DAL;
using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.BL
{
    /// <summary>
    /// Clase EstudianteBL
    //Esta clase representa la capa de lógica de negocios(BL) para la entidad Grupo en
    //el sistema SysAsistencia.Proporciona métodos para interactuar con la capa de acceso a datos
    //(DAL) representada por la clase EstudianteDAL para realizar operaciones CRUD
    //
    //Uso:
    //- Instanciar la clase EstudianteBL para acceder a los métodos de la capa de lógica de negocios para la entidad Estudiante.
    /// </summary>
    public class EstudianteBL
    {
        private EstudianteDAL oEstudianteDAL = new EstudianteDAL();

        public bool AgregarEstudiante(Estudiante estudiante)
        {
            return oEstudianteDAL.AgregarEstudiante(estudiante);
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            return oEstudianteDAL.ObtenerEstudiantes();
        }

        public void EliminarEstudiante(Estudiante estudiante)
        {
            oEstudianteDAL.EliminarEstudiante(estudiante);
        }

        public bool ActualizarEstudiante(Estudiante estudiante)
        {
            return oEstudianteDAL.ActualizarEstudiante(estudiante);
        }

    }
}
