using Esfe.SysAsistencia.DAL;
using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.BL
{
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
