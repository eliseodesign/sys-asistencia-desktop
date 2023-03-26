using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esfe.SysAsistencia.EN.Utilities;

namespace Esfe.SysAsistencia.EN.Static
{
    // Esta clase almacena usuarios que vienen por defecto como el coordinador
    public static class UsuariosDefecto
    {
        public static Credenciales Cordinador { get; } = new Credenciales("coordinador", "coordinador");
    }
}
