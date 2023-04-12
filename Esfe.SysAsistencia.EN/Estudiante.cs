using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.EN
{
    /// <summary>
    /// Clase que representa a un Estudiante.
    /// </summary>
    public class Estudiante
    {
        /// <summary>
        /// Propiedad de lectura y escritura que representa la identificación del estudiante.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa el código del grupo al que pertenece el estudiante.
        /// </summary>
        public string CodigoGrupo { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa los nombres del estudiante.
        /// </summary>
        public string Nombres { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa los apellidos del estudiante.
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa el DUI (Documento Único de Identidad) del estudiante.
        /// </summary>
        public string Dui { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa el NIT (Número de Identificación Tributaria) del estudiante.
        /// </summary>
        public string Nit { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa la identificación de la carrera del estudiante.
        /// </summary>
        public string IdCarrera { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa el año de estudios del estudiante.
        /// </summary>
        public int Año { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa el número de celular del estudiante.
        /// </summary>
        public string Cel { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa la huella digital del estudiante en formato byte array.
        /// </summary>
        public byte[] Huella { get; set; }
    }
}
