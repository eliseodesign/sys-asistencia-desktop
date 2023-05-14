using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.BL
{
    public class AnioBL
    {
        AnioBL oAnioBL = new AnioBL();
        public List<Anio> ObtenerAnio()
        {
            return oAnioBL.ObtenerAnio();
        }
    }
}
