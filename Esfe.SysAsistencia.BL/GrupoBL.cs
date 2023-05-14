using Esfe.SysAsistencia.DAL; // Se importa el espacio de nombres de la capa de acceso a datos (DAL)
using Esfe.SysAsistencia.EN; // Se importa el espacio de nombres de la entidad Grupo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysGrupo.BL 
{
    /// <summary>
    /// Clase GrupoBL
    //Esta clase representa la capa de lógica de negocios(BL) para la entidad Grupo en el sistema SysAsistencia.Proporciona métodos para interactuar con la capa de acceso a datos (DAL) representada por la clase GrupoDAL para realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) en la entidad Grupo.
    //Uso:
    //- Instanciar la clase GrupoBL para acceder a los métodos de la capa de lógica de negocios para la entidad Grupo.
    /// </summary>
    public class GrupoBL // Clase GrupoBL
    {
        private GrupoDAL oGrupoDAL = new GrupoDAL(); // Instancia de la clase GrupoDAL para interactuar con la capa de acceso a datos (DAL)

        public bool AgregarGrupo(Grupo Grupo) 
        {
            return oGrupoDAL.AgregarGrupo(Grupo);
        }

        public List<Grupo> ObtenerGrupos()
        {
            return oGrupoDAL.ObtenerGrupos(); 
        }

        public bool ActualizarGrupo(Grupo grupo) 
        {
            return oGrupoDAL.ActualizarGrupo(grupo); 
        }

        public bool EliminarGrupo(int id) 
        {
            return oGrupoDAL.EliminarGrupo(id); 
        }

    }
}