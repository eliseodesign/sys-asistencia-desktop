using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.EN.Utilities
{
    public class Credenciales
    {
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }

        public Credenciales(string usuario, string contrasenia)
        {
            this.Usuario = usuario;
            this.Contrasenia = contrasenia;
        }
    }
}
