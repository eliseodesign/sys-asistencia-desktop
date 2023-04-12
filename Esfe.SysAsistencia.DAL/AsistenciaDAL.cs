using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.DAL
{
    /// <summary>
    /// Contiene las asitencia y el manejo de estas
    /// </summary>
    public class AsistenciaDAL
    {
        private List<Asistencia> Asistencias = new List<Asistencia>();
        private string Path { get; } = "asistencia.json";

        public AsistenciaDAL()
        {
            if (File.Exists(Path))
            {
                string json = File.ReadAllText("docentes.json");
                Asistencias = JsonSerializer.Deserialize<List<Asistencia>>(json);
            }
            else
            {
                Asistencias = new List<Asistencia>();
            }
        }
        public bool AgregarAsistencia(Asistencia asistencia)
        {
            var res = true;
            if(ObtenerAsistencias().Select(g=>g.Id) != null)
            {
                asistencia.Id = Asistencias.Select(d => d.Id).DefaultIfEmpty(0).Max() + 1;
                Asistencias.Add(asistencia);
            }
            else
            {
                res = false;
            }

            return res;
        }

        public List<Asistencia> ObtenerAsistencias()
        {
            return Asistencias;
        }

        public bool ExisteAsistencia(DateTime buscar)
        {
            return Asistencias.Exists(Asist => Asist.Fecha == buscar);
        }

        public bool ModificarAsistencia(int id, Asistencia asistencia)
        {
            int index = Asistencias.FindIndex(a => a.Id == id);
            if (index != -1)
            {
                Asistencias[index] = asistencia;
                return true;
            }
            return false;
        }

        public bool EliminarAsistencia(int id)
        {
            int count = Asistencias.RemoveAll(a => a.Id == id);
            return count > 0;
        }
        //// -------------------- json methos -----------------------------------
        public void GuardarJson()
        {

            var options = new JsonSerializerOptions // Opciones para la serialización JSON
            {
                WriteIndented = true // Indentación para que el archivo sea más legible
            };

            var jsonDocentes = JsonSerializer.Serialize(Asistencias, options); // Convertir la lista a JSON

            File.WriteAllText(Path, jsonDocentes); // Guardar el JSON en un archivo

        }
    }
}
