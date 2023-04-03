using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.EN
{
    public class Docente
    {
        public int Id { get; set; }
        public List<string> GrupoCodigos { get; set; } = new List<string>();
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Cel { get; set; }
        public string Dui { get; set; }
        public string Carrera { get; set; }
        public string Nit { get; set; }
        public byte[] Huella { get; set; }
    }
}
