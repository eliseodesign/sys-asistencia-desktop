using Esfe.SysAsistencia.DAL.BD;
using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.DAL
{
    public class GrupoDocenteDAL
    {
        public List<GrupoDocente> ObtenerGrupoDocentes()
        {
            try
            {
                return ComunBD.EjecutarSPSelect<GrupoDocente>("SPReadGrupoDocente");
            }
            catch (Exception)
            {
                return new List<GrupoDocente>();
            }
        }

        public bool ActualizarGrupoDocente(GrupoDocente update)
        {
            List<string> parametros = new() { "Id", "IdGrupo", "IdDocente"};
            try
            {
                int valor = ComunBD.EjecutarSP("SPUpdateGrupoDocente", update, parametros);
                if (valor > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AgregarGrupoDocente(GrupoDocente pGrupoDocente)
        {
            List<string> parametros = new() { "IdGrupo", "IdDocente" };
            try
            {
                int valor = ComunBD.EjecutarSP("SPCreateGrupoDocente", pGrupoDocente, parametros);
                if (valor > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarGrupoDocente(GrupoDocente GrupoDocente)
        {
            List<string> parametros = new() { "Id" };
            try
            {
                int valor = ComunBD.EjecutarSP("SPDeleteGrupoDocente", GrupoDocente, parametros);
                if (valor > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
