using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.EN
{
    /// <summary>
    /// Clase que representa a un grupo de estudiantes en un sistema de asistencia.
    /// </summary>
    public class Grupo
    {
        public int Id { get; set; }
        public byte EstudiantesMax { get; set; }
        public string DiasPresencial { get; set; } 
        //public int DocenteId { get; set;  } = 0;
        public byte IdNumGrupo { get; set; }
        public byte IdAnio { get; set; }
        public byte IdCarrera { get; set; }
        public byte IdTurno { get; set; }
    }
}
