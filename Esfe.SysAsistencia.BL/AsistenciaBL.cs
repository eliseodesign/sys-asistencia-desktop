using Esfe.SysAsistencia.DAL;
using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.BL
{
    public class AsistenciaBL
    {
        private AsistenciaDAL oAsistenciaDAL = new AsistenciaDAL();

        public void AgregarAsistencia(Asistencia Asistencia)
        {
            oAsistenciaDAL.AgregarAsistencia(Asistencia);
        }

        public List<Asistencia> ObtenerAsistencias()
        {
            return oAsistenciaDAL.ObtenerAsistencias();
        }

        public bool ExisteAsistencia(DateTime buscar)
        {
            return oAsistenciaDAL.ExisteAsistencia(buscar);
        }
    }
}
