using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.BL
{
    public class NumGrupoBL
    {
        NumGrupoBL oNumGrupoBL = new NumGrupoBL();
        public List<NumGrupo> ObtenerNumGrupo()
        {
            return oNumGrupoBL.ObtenerNumGrupo();
        }
    }
}
