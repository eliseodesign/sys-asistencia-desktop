using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.UI.Helpers
{
    public class Verificar
    {
        public static bool VerificarTipo<T>(IEnumerable<T> coleccion, Type tipo)
        {
            foreach (var elemento in coleccion)
            {
                if (!tipo.IsInstanceOfType(elemento))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
