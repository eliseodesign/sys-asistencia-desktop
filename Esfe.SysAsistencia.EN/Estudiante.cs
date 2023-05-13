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
        public int Id { get; set; }
        public string CodigoGrupo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dui { get; set; }
        public string Nit { get; set; }
        public string IdCarrera { get; set; }
        public int Año { get; set; }
        public string Cel { get; set; }
        public byte[] Huella { get; set; }
    }
}
