using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.EN
{
    public class Grupo
    {
        public string Carrera { get; set; }
        public int NumGrupo { get; set;}
        public int Año { get; set; }
        public string Docente { get; set; }
        public bool[] Horario { get; set; } = new bool[5];
        public int Jornada { get; set; } // 1. Diurna, 2. Nocturna 
        public List<Estudiante> Estudiantes { get; set; }
    }
}
