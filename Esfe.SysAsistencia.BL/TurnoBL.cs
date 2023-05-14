using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.BL
{
    public class TurnoBL
    {
        TurnoBL oTurnoBL = new TurnoBL();
        public List<Turno> ObtenerTurno()
        {
            return oTurnoBL.ObtenerTurno();
        }
    }
}
