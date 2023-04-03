using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.DAL
{
    public class EstudianteDAL
    {
        private static List<Estudiante> Estudiantes;
        private string Path { get; } = "estudiantes.json";

        public Estudiante Existente { get; set; }

        public EstudianteDAL()
        {
            if (File.Exists(Path))
            {
                string json = File.ReadAllText(Path);
                Estudiantes = JsonSerializer.Deserialize<List<Estudiante>>(json);
            }
            else
            {
                Estudiantes = new List<Estudiante>();
            }
        }
        public bool AgregarEstudiante(Estudiante estudiante)
        {
            if (VerificarHuella(estudiante) != null)
            {
                return false;
            }
            estudiante.Id = Estudiantes.Select(d => d.Id).DefaultIfEmpty(0).Max() + 1;
            Estudiantes.Add(estudiante);

            return true;
        }

        public Estudiante VerificarHuella(Estudiante estudiante)
        {
            return Estudiantes.FirstOrDefault(h => h.Huella == estudiante.Huella);

        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            return Estudiantes;
        }

        public bool ExisteEstudiante(Estudiante buscar)
        {
            return Estudiantes.Exists(e => (e.Nombres == buscar.Nombres || e.Apellidos == buscar.Apellidos));
        }
        public void GuardarJson()
        {

            var options = new JsonSerializerOptions // Opciones para la serialización JSON
            {
                WriteIndented = true // Indentación para que el archivo sea más legible
            };

            var jsonDocentes = JsonSerializer.Serialize(Estudiantes, options); // Convertir la lista a JSON

            File.WriteAllText(Path, jsonDocentes); // Guardar el JSON en un archivo

        }
    }
}
