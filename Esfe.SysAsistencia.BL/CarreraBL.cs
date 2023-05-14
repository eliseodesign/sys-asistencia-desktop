using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.BL
{
    public class CarreraBL
    {
        CarreraBL oCarreraBL = new CarreraBL();
        public List<Carrera> ObtenerCarrera()
        {
            return oCarreraBL.ObtenerCarrera();
        }
    }
}
