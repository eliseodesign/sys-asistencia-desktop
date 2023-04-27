using Esfe.SysAsistencia.BL;
using Esfe.SysAsistencia.EN;
using Esfe.SysGrupo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.UI.Helpers
{
    public class State
    {
        // --------------- instancias de las capas --------------------------
        public static DocenteBL docenteBL { get; set; } = new DocenteBL();
        public static EstudianteBL estudianteBL { get; set; } = new EstudianteBL();
        public static GrupoBL grupoBL { get; set; } = new GrupoBL();
        public static AsistenciaBL asistenciaBL { get; set; } = new AsistenciaBL();


        // ----------- propiedades globales de acceso ------------------------------
        public static bool TotalAccess { get; set; }
        public static Docente DocenteLoged { get; set; }

        public static List<Grupo> GruposDocente { get; set; } = new List<Grupo>();



        public static class InfoCarrera{
            public static string[] carreras = new string[4] { "Téc. ing Electrica", "Téc. en ing de Desarrollo De Software", "Téc en Mercadeo", "Téc. en Gestión y Desarrollo Turístico" };
            public static string[] idCarrera = new string[4] { "TIE", "TIDS", "TM", "TGT" };

            public static string[] años = new string[2] { "1 año", "2 año" };
            public static string[] idAño = new string[2] { "1°", "2°" };


            public static string[] turnos = new string[3] { "mañana", "tarde", "noche" };
        }

         //-------------- Constructucor ----------------
        public static List<Grupo> obtenerGruposDocente()
        {
            List<Grupo> Grupos = grupoBL.ObtenerGrupos();
            List<string> Codigos = DocenteLoged.GrupoCodigos;



            foreach (String codigo in Codigos)
            {
                

                Grupo busca = Grupos.FirstOrDefault(g => g.Codigo == codigo);
                if (busca != null)
                {
                    GruposDocente.Add(busca);
                }
            }
            return GruposDocente;
        }
    }
}
