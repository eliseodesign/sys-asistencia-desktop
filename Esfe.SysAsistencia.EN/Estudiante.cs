using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.EN
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set;}
        public string IdCarrera { get; set; }
        public string IdGrupo {get; set; }
        public int Año {get; set;}
        public string Cel { get; set; }
        public byte[] HuellaDigital { get; set; } 
    }
}
