using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Esfe.SysAsistencia.EN;

namespace Esfe.SysAsistencia.DAL
{
    public class DocenteDAL
    {
        private static List<Docente> ListaDocentes;
        private string Path { get; } = "docentes.json";

        public Docente Existente { get; set; }
        public bool AgregarDocente(Docente docente)
        {
            if (VerificarHuella(docente) != null)
            {
                return false;
            }
                docente.Id = ListaDocentes.Select(d => d.Id).DefaultIfEmpty(0).Max() + 1;
                ListaDocentes.Add(docente);
            
                return true;
        }

        public Docente VerificarHuella(Docente docente)
        {
           return ListaDocentes.FirstOrDefault(h => h.Huella == docente.Huella);

        }

        public DocenteDAL()
        {

            if (File.Exists(Path))
            {
                string json = File.ReadAllText("docentes.json");
                ListaDocentes = JsonSerializer.Deserialize<List<Docente>>(json);
            }
            else
            {
                ListaDocentes = new List<Docente>();
            }
        }

        public List<Docente> ObtenerDocentes()
        {
            return ListaDocentes;
        }

        public bool ExisteDocente(Docente buscar)
        {
            return ListaDocentes.Exists(docente => (docente.Nombres == buscar.Nombres || docente.Apellidos == buscar.Apellidos));
        }

        public void ActualizarDocente(Docente docenteActualizado)
        {
            var index = ListaDocentes.FindIndex(d => d.Id == docenteActualizado.Id);
            if (index != -1)
            {
                ListaDocentes[index] = docenteActualizado;
            }
        }

        public void EliminarDocente(Docente docente)
        {
            var eliminar = ListaDocentes.FirstOrDefault(i => i.Id == docente.Id);
            ListaDocentes.Remove(eliminar);
        }

        public void ModificarDocente(Docente docente)
        {
            var update = ListaDocentes.FirstOrDefault(i => i.Id == docente.Id);
            ListaDocentes.Remove(update);
            ListaDocentes.Add(docente);
        }

        public Docente ObtenerDocentePorId(int id)
        {
            return ListaDocentes.FirstOrDefault(d => d.Id == id);
        }
        //// -------------------- json methos -----------------------------------
        public void GuardarJson()
        {

            var options = new JsonSerializerOptions // Opciones para la serialización JSON
            {
                WriteIndented = true // Indentación para que el archivo sea más legible
            };

            var jsonDocentes = JsonSerializer.Serialize(ListaDocentes, options); // Convertir la lista a JSON

            File.WriteAllText(Path, jsonDocentes); // Guardar el JSON en un archivo

        }

    }
}
