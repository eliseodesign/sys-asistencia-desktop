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

        public string AgregarGrupo(Grupo Grupo) // Método para agregar un nuevo grupo
        {
            return oGrupoDAL.AgregarGrupo(Grupo); // Llama al método correspondiente en la capa de acceso a datos (DAL)
        }

        public List<Grupo> ObtenerGrupos() // Método para obtener la lista de grupos
        {
            return oGrupoDAL.ObtenerGrupos(); // Llama al método correspondiente en la capa de acceso a datos (DAL)
        }

        public Grupo ObtenerGrupoPorId(int id) // Método para obtener un grupo por su ID
        {
            return oGrupoDAL.ObtenerGrupoPorId(id); // Llama al método correspondiente en la capa de acceso a datos (DAL)
        }

        public bool ActualizarGrupo(Grupo grupo) // Método para actualizar información de un grupo
        {
            return oGrupoDAL.ActualizarGrupo(grupo); // Llama al método correspondiente en la capa de acceso a datos (DAL)
        }

        public void EliminarGrupo(int id) // Método para eliminar un grupo por su ID
        {
            oGrupoDAL.EliminarGrupo(id); // Llama al método correspondiente en la capa de acceso a datos (DAL)
        }

        public void GuardarJson() // Método para guardar los datos de los grupos en formato JSON
        {
            oGrupoDAL.GuardarJson(); // Llama al método correspondiente en la capa de acceso a datos (DAL)
        }

    }
}