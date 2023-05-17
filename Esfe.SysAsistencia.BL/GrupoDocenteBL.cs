using Esfe.SysAsistencia.DAL;
using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.BL
{
    /// <summary>
    /// Clase GrupoDocenteBL
    //Esta clase representa la capa de lógica de negocios(BL) para la entidad GrupoDocente en el sistema SysAsistencia.Proporciona métodos para interactuar con la capa de acceso a datos (DAL) representada por la clase GrupoDocenteDAL para realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) en la entidad GrupoDocente.
    //Uso:
    //- Instanciar la clase GrupoDocenteBL para acceder a los métodos de la capa de lógica de negocios para la entidad GrupoDocente.
    /// </summary>
    public class GrupoDocenteBL // Clase GrupoDocenteBL
    {
        private GrupoDocenteDAL oGrupoDocenteDAL = new GrupoDocenteDAL(); // Instancia de la clase GrupoDocenteDAL para interactuar con la capa de acceso a datos (DAL)

        public bool AgregarGrupoDocente(GrupoDocente GrupoDocente)
        {
            return oGrupoDocenteDAL.AgregarGrupoDocente(GrupoDocente);
        }

        public List<GrupoDocente> ObtenerGrupoDocentes()
        {
            return oGrupoDocenteDAL.ObtenerGrupoDocentes();
        }

        public bool ActualizarGrupoDocente(GrupoDocente GrupoDocente)
        {
            return oGrupoDocenteDAL.ActualizarGrupoDocente(GrupoDocente);
        }

        public bool EliminarGrupoDocente(GrupoDocente GrupoDocente)
        {
            return oGrupoDocenteDAL.EliminarGrupoDocente(GrupoDocente);
        }

    }
}
