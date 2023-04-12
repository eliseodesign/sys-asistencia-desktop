using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esfe.SysAsistencia.EN;
using Esfe.SysAsistencia.DAL;

namespace Esfe.SysAsistencia.BL
{
    /// <summary>
    /// Clase DocenteBL
    //Esta clase representa la capa de lógica de negocios(BL) para la entidad Grupo en
    //el sistema SysAsistencia.Proporciona métodos para interactuar con la capa de acceso a datos
    //(DAL) representada por la clase DocenteDAL para realizar operaciones CRUD
    //
    //Uso:
    //- Instanciar la clase DocenteBL para acceder a los métodos de la capa de lógica de negocios para la entidad Docente.
    /// </summary>
    public class DocenteBL
    {
        private DocenteDAL oDocenteDAL = new DocenteDAL();

        public bool AgregarDocente(Docente docente)
        {
            return oDocenteDAL.AgregarDocente(docente);
        }

        public List<Docente> ObtenerDocentes()
        {
            return oDocenteDAL.ObtenerDocentes();
        }

        public bool ExisteDocente(Docente buscar)
        {
            return oDocenteDAL.ExisteDocente(buscar);
        }

        public void EliminarDocente(Docente docente)
        {
            oDocenteDAL.EliminarDocente(docente);
        }

        public void ModificarDocente(Docente docente)
        {
            oDocenteDAL.ModificarDocente(docente);
        }

        public void GuadarJson()
        {
            oDocenteDAL.GuardarJson();
        }
    }
}
