using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.EN
{
    public class Grupo
    {
        public int Id { get; set; }
        public int DocenteId { get; set; } = 0;
        public string Codigo { get; set; }
        public string Carrera { get; set; }
        public string Año { get; set; }
        public string Turno { get; set; }
        public int NumGrupo { get; set; }
        public int EstudaintesMax { get; set; }
        public bool[] Horario { get; set; } = new bool[5];
        public int Jornada { get; set; } // 1. Diurna, 2. Nocturna 

    }
}