using Esfe.SysAsistencia.DAL.BD;
using Esfe.SysAsistencia.EN;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.DAL
{
    /// <summary>
    /// Clase encarga de almacenar los Grupos y los metodos de los mismos
    /// </summary>
    public class GrupoDAL
    {
        public List<Grupo> ObtenerGrupos()
        {
            try
            {
                return ComunBD.EjecutarSPSelect<Grupo>("SPReadGrupo");
            }
            catch (Exception)
            {
                return new List<Grupo>();
            }
        }

        public bool ActualizarGrupo(Grupo update)
        {
            List<string> parametros = new() { "Id","EstudiantesMax","DiasPresencial", "IdAnio","IdCarrera","IdTurno" };
            try
            {
                int valor = ComunBD.EjecutarSP("SPUpdateGrupo", update, parametros);
                if (valor > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AgregarGrupo(Grupo grupo)
        {
            List<string> parametros = new() {"EstudiantesMax", "DiasPresencial", "IdAnio", "IdCarrera", "IdTurno" };
            try
            {
                int valor = ComunBD.EjecutarSP("SPCreateGrupo", grupo, parametros);
                if (valor > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarGrupo(Grupo grupo)
        {
            List<string> parametros = new() { "Id" };
            try
            {
                int valor = ComunBD.EjecutarSP("SPDeleteGrupo", grupo, parametros);
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
