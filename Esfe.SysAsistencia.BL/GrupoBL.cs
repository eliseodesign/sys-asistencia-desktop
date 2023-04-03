using Esfe.SysAsistencia.DAL;
using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysGrupo.BL
{
    public class GrupoBL
    {
        private GrupoDAL oGrupoDAL = new GrupoDAL();

        public string AgregarGrupo(Grupo Grupo)
        {
            return oGrupoDAL.AgregarGrupo(Grupo);
        }

        public List<Grupo> ObtenerGrupos()
        {
            return oGrupoDAL.ObtenerGrupos();
        }
        public Grupo ObtenerGrupoPorId(int id)
        {
            return oGrupoDAL.ObtenerGrupoPorId(id);
        }

        public void ActualizarGrupo(Grupo grupo)
        {
            oGrupoDAL.ActualizarGrupo(grupo);
        }
        public void EliminarGrupo(int id)
        {
            oGrupoDAL.EliminarGrupo(id);
        }

        public void GuardarJson()
        {
            oGrupoDAL.GuardarJson();
        }

    }
}
