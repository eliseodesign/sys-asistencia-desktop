using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.EN
{
    /// <summary>
    /// Clase que representa la asistencia de un alumno a una clase.
    /// </summary>
    public class Asistencia
    {
        /// <summary>
        /// Enumeración que representa los criterios de asistencia posibles.
        /// </summary>
        public enum CRITERIOS
        {
            PRESENCIAL,
            ASICONCRONICA,
            SINCRONICA,
            NA,
            NO_ASISTIO
        };

        /// <summary>
        /// Enumeración que representa las nomenclaturas posibles para la asistencia.
        /// </summary>
        public enum NOMENCLATURAS
        {
            [Display(Name = "Seguimiento")]
            S,
            [Display(Name = "Asistió Tarde")]
            T,
            [Display(Name = "Solicitó Permiso")]
            P,
            [Display(Name = "Se retiró antes")]
            R
        };

        /// <summary>
        /// Propiedad de lectura y escritura que representa la identificación de la asistencia.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa la identificación del alumno.
        /// </summary>
        public int AlumnoId { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa la fecha de la asistencia.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa el criterio de asistencia.
        /// </summary>
        public CRITERIOS Criterio { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa la nomenclatura de la asistencia.
        /// </summary>
        public NOMENCLATURAS Nomenclaturas { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa las observaciones de la asistencia.
        /// </summary>
        public string Observaciones { get; set; }
    }
}
