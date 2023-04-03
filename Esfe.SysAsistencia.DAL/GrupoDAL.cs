using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.DAL
{
    public class GrupoDAL
    {
        private List<Grupo> Grupos = new List<Grupo>();
        private string Path { get; } = "grupos.json";

        public GrupoDAL()
        {
            if (File.Exists(Path))
            {
                string json = File.ReadAllText(Path);
                Grupos = JsonSerializer.Deserialize<List<Grupo>>(json);
            }
            else
            {
                Grupos = new List<Grupo>();
            }
        }

        public List<Grupo> ObtenerGrupos()
        {
            return Grupos;
        }

        public bool ExisteGrupo(int numGrupo)
        {
            return Grupos.Exists(grupo => grupo.NumGrupo == numGrupo);
        }

        public Grupo ObtenerGrupoPorId(int id)
        {
            return Grupos.FirstOrDefault(grupo => grupo.Id == id);
        }

        public void ActualizarGrupo(Grupo grupo)
        {
            var grupoActual = ObtenerGrupoPorId(grupo.Id);
            if (grupoActual != null)
            {
                grupoActual.NumGrupo = grupo.NumGrupo;
                grupoActual.DocenteId = grupo.DocenteId;
            }
        }

        public string AgregarGrupo(Grupo grupo)
        {
            // id autoincremental
            grupo.Id = Grupos.Select(g => g.Id).DefaultIfEmpty(0).Max() + 1;

            // identificador grupos-año-carrera
            // contar grupos de misma carrera y año
            int contarGrupos = Grupos.Count(g => g.Año == grupo.Año && g.Carrera == grupo.Carrera);
            // numero del sig grupo
            int numeroGrupo = contarGrupos + 1;

            // concatenar variables
            grupo.Codigo = $"{numeroGrupo.ToString("D2")}-{grupo.Año}{grupo.Carrera}";


            Grupos.Add(grupo);
            return grupo.Codigo;
        }

        public void EliminarGrupo(int id)
        {
            Grupos.RemoveAll(grupo => grupo.Id == id);
        }
        //// -------------------- json methos -----------------------------------
        public void GuardarJson()
        {

            var options = new JsonSerializerOptions // Opciones para la serialización JSON
            {
                WriteIndented = true // Indentación para que el archivo sea más legible
            };

            var jsonDocentes = JsonSerializer.Serialize(Grupos, options); // Convertir la lista a JSON

            File.WriteAllText(Path, jsonDocentes); // Guardar el JSON en un archivo

        }
    }
}
