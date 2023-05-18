using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Esfe.SysAsistencia.DAL.BD;
using Esfe.SysAsistencia.EN;

namespace Esfe.SysAsistencia.DAL
{
    /// <summary>
    /// Guarda Docentes y metodos para manejar su información
    /// </summary>
    public class DocenteDAL 
    { 
 
        public List<Docente> ObtenerDocentes()
        {
            //try
            //{
                return ComunBD.EjecutarSPSelect<Docente>("SPReadDocente");
            //}
            //catch (Exception)
            //{
            //    return new List<Docente>();
            //}
        }

        public bool ActualizarDocente(Docente update)
        {
            List<string> parametros = new() { "Id", "Nombre", "Apellido", "Dui", "Cel", "Huella", "IdCarrera"};
            //try
            //{
                int valor = ComunBD.EjecutarSP("SPUpdateDocente", update, parametros);
                return valor > 0;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
        }

        public bool AgregarDocente(Docente docente)
        {
            List<string> parametros = new() { "Nombre", "Apellido", "Dui", "Cel", "Huella", "IdGrupo", "IdCarrera"};
            //try
            //{
                int valor = ComunBD.EjecutarSP("SPCreateDocente", docente, parametros);
                return valor > 0;
            //}
            //catch (Exception e)
            //{
            //    Console.Write(Convert.ToString(e));
            //    return false;
            //}
        }

        public bool EliminarDocente(Docente docente)
        {
            List<string> parametros = new() { "Id" };
            //try
            //{
                int valor = ComunBD.EjecutarSP("SPDeleteDocente", docente, parametros);
                return valor > 0;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
        }


        //// -------------------- json methos -----------------------------------
        //public void GuardarJson()
        //{

        //    var options = new JsonSerializerOptions // Opciones para la serialización JSON
        //    {
        //        WriteIndented = true // Indentación para que el archivo sea más legible
        //    };

        //    var jsonDocentes = JsonSerializer.Serialize(ListaDocentes, options); // Convertir la lista a JSON

        //    File.WriteAllText(Path, jsonDocentes); // Guardar el JSON en un archivo

        //}

    }
}
