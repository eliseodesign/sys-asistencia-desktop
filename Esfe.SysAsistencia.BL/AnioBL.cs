using Esfe.SysAsistencia.EN;
using Esfe.SysAsistencia.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.BL
{
    public class AnioBL
    {
        AnioDAL oAnioDAL = new AnioDAL();
        public List<Anio> ObtenerAnio()
        {
            return oAnioDAL.ObtenerAnio();
        }
    }
}
