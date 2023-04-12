using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.DAL
{
    /// <summary>
    /// Clase que se encarga de almacenar Estudianes y contiene los metodo para menjar su información
    /// </summary>
    public class EstudianteDAL
    {
        private static List<Estudiante> Estudiantes;
        private string Path { get; } = "estudiantes.json";

        public Estudiante Existente { get; set; }

        // al ejecutarse el constructor busca si existe el archivo y extrae sus datos
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
            var exist = Estudiantes.FirstOrDefault(e => e.Id == estudiante.Id);
            if(exist != null)
            {
                EditarEstudiante(exist, estudiante);
                return true;
            }
            if (VerificarHuella(estudiante) != null)
            {
                return false;
            }
            estudiante.Id = Estudiantes.Select(d => d.Id).DefaultIfEmpty(0).Max() + 1;
            Estudiantes.Add(estudiante);

            return true;
        }
        private void EditarEstudiante(Estudiante estudiante, Estudiante estudianteActualizado)
        {
            estudiante.CodigoGrupo = estudianteActualizado.CodigoGrupo;
            estudiante.Nombres = estudianteActualizado.Nombres;
            estudiante.Apellidos = estudianteActualizado.Apellidos;
            estudiante.Dui = estudianteActualizado.Dui;
            estudiante.Nit = estudianteActualizado.Nit;
            estudiante.IdCarrera = estudianteActualizado.IdCarrera;
            estudiante.Año = estudianteActualizado.Año;
            estudiante.Cel = estudianteActualizado.Cel;
            estudiante.Huella = estudianteActualizado.Huella;
        }

        public bool EliminarEstudiante(int id)
        {
            var eliminar = Estudiantes.FirstOrDefault(i => i.Id == id);
            if(eliminar != null)
            {
                Estudiantes.Remove(eliminar);
                return true;
            }
            return false;
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
