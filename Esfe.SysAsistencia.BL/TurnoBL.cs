using Esfe.SysAsistencia.EN;
using Esfe.SysAsistencia.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.BL
{
    public class TurnoBL
    {
        TurnoDAL oTurnoDAL = new TurnoDAL();
        public List<Turno> ObtenerTurno()
        {
            return oTurnoDAL.ObtenerTurno();
        }
    }
}
