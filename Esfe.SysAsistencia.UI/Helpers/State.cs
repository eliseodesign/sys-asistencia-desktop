using Esfe.SysAsistencia.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.UI.Helpers
{
    public class State
    {
        public static DocenteBL BL { get; set; } = new DocenteBL();

        public static bool TotalAccess { get; set; } = false;
    }
}
