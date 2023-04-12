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

        public bool AgregarEstudiante(Estudiante Estudiante)
        {
            return oEstudianteDAL.AgregarEstudiante(Estudiante);
        }

        public List<Estudiante> ObtenerEstudiante()
        {
            return oEstudianteDAL.ObtenerEstudiantes();
        }

        public List<Estudiante> ObtenenerEstudiantesByGroup(string grupo)
        {
            List<Estudiante> lista = new List<Estudiante>();
            foreach (var ee in oEstudianteDAL.ObtenerEstudiantes())
            {
                if (ee.CodigoGrupo == grupo)
                {
                    lista.Add(ee);
                }
            }

            return lista;
        }

        public bool EliminarEstudiante(int id)
        {
            return oEstudianteDAL.EliminarEstudiante(id);
        }
        public bool ExisteEstudiatne(Estudiante Estudiante)
        {
            return oEstudianteDAL.ExisteEstudiante(Estudiante);
        }
        public void GuadarJson()
        {
            oEstudianteDAL.GuardarJson();
        }

    }
}
