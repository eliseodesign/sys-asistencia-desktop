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
        /// <summary>
        /// Propiedad de lectura y escritura que representa la identificación del grupo.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Propiedad de lectura y escritura que representa la identificación del docente asignado al grupo. El valor por defecto es 0.
        /// </summary>
        public int DocenteId { get; set; } = 0;
        /// <summary>
        /// Propiedad de lectura y escritura que representa el código del grupo.
        /// </summary>
        public string Codigo { get; set; }
        /// <summary>
        /// Propiedad de lectura y escritura que representa la carrera del grupo.
        /// </summary>
        public string Carrera { get; set; }
        /// <summary>
        /// Propiedad de lectura y escritura que representa el año del grupo.
        /// </summary>
        public string Año { get; set; }
        /// <summary>
        /// Propiedad de lectura y escritura que representa el turno del grupo.
        /// </summary>
        public string Turno { get; set; }
        /// <summary>
        /// Propiedad de lectura y escritura que representa la cantidad máxima de estudiantes permitidos en el grupo.
        /// </summary>
        public int EstudiantesMax { get; set; }
        /// <summary>
        /// Propiedad de lectura y escritura que representa el horario de clases del grupo.
        /// </summary>
        public bool[] Horario { get; set; } = new bool[5];

        /// <summary>
        /// Propiedad de solo lectura que representa los días presenciales de clases del grupo.
        /// </summary>
        public string Presencial
        {
            get
            {
                string[] diasSemana = new string[] { "Lun", "Mar", "Mie", "Jue", "Vie" };
                string diasPresenciales = "";

                for (int i = 0; i < Horario.Length; i++)
                {
                    if (Horario[i])
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
