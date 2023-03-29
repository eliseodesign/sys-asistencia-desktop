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
        private EstudianteDAL estudianteDAL = new EstudianteDAL();

        public void AgregarEstudiante(Estudiante estudiante)
        {
            estudianteDAL.AgregarEstudiante(estudiante);
        }

        public List<Estudiante> ObtenerEstudiante()
        {
            return estudianteDAL.ObtenerEstudiantes();
        }

        public bool ExisteEstudiatne(Estudiante estudiante)
        {
            return estudianteDAL.ExisteEstudiante(estudiante);
        }
    }
}
