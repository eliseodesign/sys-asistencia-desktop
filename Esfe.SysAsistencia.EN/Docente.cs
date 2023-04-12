using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.EN
{
    /// <summary>
    /// Clase que representa a un Docente.
    /// </summary>
    public class Docente
    {
        /// <summary>
        /// Propiedad de lectura y escritura que representa la identificación del docente.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa los códigos de grupos asignados al docente.
        /// </summary>
        public List<string> GrupoCodigos { get; set; } = new List<string>();

        /// <summary>
        /// Propiedad de lectura y escritura que representa los nombres del docente.
        /// </summary>
        public string Nombres { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa los apellidos del docente.
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa la dirección del docente.
        /// </summary>
        public string Direccion { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa el número de celular del docente.
        /// </summary>
        public string Cel { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa el DUI (Documento Único de Identidad) del docente.
        /// </summary>
        public string Dui { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa la carrera del docente.
        /// </summary>
        public string Carrera { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa el NIT (Número de Identificación Tributaria) del docente.
        /// </summary>
        public string Nit { get; set; }

        /// <summary>
        /// Propiedad de lectura y escritura que representa la huella digital del docente en formato byte array.
        /// </summary>
        public byte[] Huella { get; set; }
    }

}
