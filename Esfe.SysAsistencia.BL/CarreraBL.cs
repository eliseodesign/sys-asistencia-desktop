using Esfe.SysAsistencia.DAL;
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
        CarreraDAL oCarreraDAL = new CarreraDAL();
        public List<Carrera> ObtenerCarrera()
        {
            return oCarreraDAL.ObtenerCarrera();
        }
    }
}
