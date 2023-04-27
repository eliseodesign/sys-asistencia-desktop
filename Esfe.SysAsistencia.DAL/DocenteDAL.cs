using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Esfe.SysAsistencia.EN;

namespace Esfe.SysAsistencia.DAL
{
    /// <summary>
    /// Guarda Docentes y metodos para manejar su información
    /// </summary>
    public class DocenteDAL
    {
        private static List<Docente> ListaDocentes;
        private string Path { get; } = "docentes.json";


        // al ejecutarse el constructor busca si existe el archivo y extrae sus datos
        public bool AgregarDocente(Docente docente)
        {
            Docente exist = ListaDocentes.FirstOrDefault(d => d.Id == docente.Id);
            if (exist!= null)
            {
                ActualizarDocente(exist, docente); return true;
            }
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

        public void ActualizarDocente(Docente docente, Docente docenteActualizado)
        {
            docente.Nombres = docenteActualizado.Nombres;
            docente.Apellidos = docenteActualizado.Apellidos;
            docente.Direccion = docenteActualizado.Direccion;
            docente.Cel = docenteActualizado.Cel;
            docente.Dui = docenteActualizado.Dui;
            docente.Carrera = docenteActualizado.Carrera;
            docente.Nit = docenteActualizado.Nit;
            docente.Huella = docenteActualizado.Huella;

            // Actualizamos los códigos de grupo del docente
            docente.GrupoCodigos.Clear();
            docente.GrupoCodigos.AddRange(docenteActualizado.GrupoCodigos);
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
