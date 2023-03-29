using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esfe.SysAsistencia.EN;
using Esfe.SysAsistencia.DAL;

namespace Esfe.SysAsistencia.BL
{
    public class DocenteBL
    {
        private DocenteDAL docenteDAL = new DocenteDAL();

        public void AgregarDocente(Docente docente)
        {
            docenteDAL.AgregarDocente(docente);
        }

        public List<Docente> ObtenerDocentes()
        {
            return docenteDAL.ObtenerDocentes();
        }

        public bool ExisteDocente(Docente buscar)
        {
            return docenteDAL.ExisteDocente(buscar);
        }
    }
}
