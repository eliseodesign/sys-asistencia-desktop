using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.DAL
{
    public class EstudianteDAL
    {
        private List<Estudiante> Estudiantes = new List<Estudiante>();

        public void AgregarEstudiante(Estudiante estudiante)
        {
            estudiante.Id = Estudiantes.Select(d => d.Id).DefaultIfEmpty(0).Max() + 1;
            Estudiantes.Add(estudiante);
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            return Estudiantes;
        }

        public bool ExisteEstudiante(Estudiante buscarE)
        {
            return Estudiantes.Exists(e => e.Id == buscarE.Id);
        }
    }
}
