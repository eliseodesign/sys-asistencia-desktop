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
        public bool[] DiasPresencial { get; set; } = new bool[5];
        //public int DocenteId { get; set; } = 0;
        public string Codigo { get; set; }
        public string Carrera { get; set; }
        public string Turno { get; set; }
        public string Docente { get; set; }
        
        public string Presencial
        {
            get
            {
                string[] diasSemana = new string[] { "Lun", "Mar", "Mie", "Jue", "Vie" };
                string diasPresenciales = "";

                for (int i = 0; i < DiasPresencial.Length; i++)
                {
                    if (DiasPresencial[i])
                    {
                        diasPresenciales += ", " + diasSemana[i];
                    }
                }

                if (diasPresenciales.Length > 0)
                {
                    return diasPresenciales = diasPresenciales.Substring(1);
                }
                return diasPresenciales.Trim();
            }
        }

    }
}
