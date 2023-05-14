using Esfe.SysAsistencia.DAL.BD;
using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.DAL
{
    public class AnioDAL
    {
        public List<Anio> ObtenerAnio()
        {
            return ComunBD.EjecutarSPSelect<Anio>("SPReadAnio");
        }

    }
}
