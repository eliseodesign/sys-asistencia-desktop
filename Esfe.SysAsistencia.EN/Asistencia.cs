using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.EN
{
    public class Asistencia
    {
        public enum CRITERIOS { PRESENCIAL, ASICONCRONICA, SINCRONICA, NA, NO_ASISTIO };
        public enum NOMENCLATURAS { 
            [Display(Name = "Seguimiento")] S,
            [Display(Name = "Asistió Tarde")] T,
            [Display(Name = "Solicitó Permiso")] P,
            [Display(Name = "Se retiró antes")] R,
        };
        public int Id { get; set; }
        public int AlumnoId { get; set; }
        public DateTime Fecha { get; set; }
        public CRITERIOS Criterio { get; set;}
        //public string CriterioDescripción { get; set; }
        public NOMENCLATURAS Nomenclaturas { get; set; }
        //public string SignificadoNomenclatura { get; set; }
        public string Observaciones { get; set; }

    }
}
