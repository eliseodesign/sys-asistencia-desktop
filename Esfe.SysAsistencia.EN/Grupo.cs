using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.EN
{
    public class Grupo
    {
        public int Id { get; set; }
        public int DocenteId { get; set; } = 0;
        public string Codigo { get; set; }//
        public string Carrera { get; set; }//
        public string Año { get; set; } //
        public string Turno { get; set; }//
        public int EstudiantesMax { get; set; } //
        public bool[] Horario { get; set; } = new bool[5];

        public string Presencial
        {
            get
            {
                string[] diasSemana = new string[] { "Lun", "Mar", "Mie", "Jue", "Vie" };
                string diasPresenciales = "";

                for (int i = 0; i < Horario.Length; i++)
                {
                    if (Horario[i])
                    {
                        diasPresenciales += diasSemana[i] + ", ";
                    }
                }

                return diasPresenciales.Trim();
            }
        }

    }
}