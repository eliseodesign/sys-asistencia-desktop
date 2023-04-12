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
    /// Clase AsistenciaBL
    //Esta clase representa la capa de lógica de negocios(BL) para la entidad Grupo en
    //el sistema SysAsistencia.Proporciona métodos para interactuar con la capa de acceso a datos
    //(DAL) representada por la clase AsitenciaDAL para realizar operaciones CRUD
    //
    //Uso:
    //- Instanciar la clase AsistenciaBL para acceder a los métodos de la capa de lógica de negocios para la entidad Asistencia.
    //- Instanciar la clase AsistenciaBL para acceder a los métodos de la capa de lógica de negocios para la entidad Asistencia.
    /// </summary>
    public class AsistenciaBL
    {
        private AsistenciaDAL oAsistenciaDAL = new AsistenciaDAL();

        public bool AgregarAsistencia(Asistencia Asistencia)
        {
            return oAsistenciaDAL.AgregarAsistencia(Asistencia);
        }

        public List<Asistencia> ObtenerAsistencias()
        {
            return oAsistenciaDAL.ObtenerAsistencias();
        }

        public bool ExisteAsistencia(DateTime buscar)
        {
            return oAsistenciaDAL.ExisteAsistencia(buscar);
        }
    }
}
