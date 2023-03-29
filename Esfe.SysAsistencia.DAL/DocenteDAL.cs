using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esfe.SysAsistencia.EN;

namespace Esfe.SysAsistencia.DAL
{
    public class DocenteDAL
    {
        private List<Docente> Docentes = new List<Docente>();

        public void AgregarDocente(Docente docente)
        {
            docente.Id = Docentes.Select(d => d.Id).DefaultIfEmpty(0).Max() + 1;
            Docentes.Add(docente);
        }

        public List<Docente> ObtenerDocentes()
        {
            return Docentes;
        }

        public bool ExisteDocente(Docente buscar)
        {
            return Docentes.Exists(docente => docente.Id == buscar.Id);
        }
    }
}
