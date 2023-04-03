using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.EN
{
    public class Asistencia
    {
        public int Id { get; set; }
        public int AlumnoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Criterio { get; set; }
        //public string CriterioDescripción { get; set; }
        public string Nomenclaturas { get; set; }
        //public string SignificadoNomenclatura { get; set; }
        public string Observaciones { get; set; }

    }
}
