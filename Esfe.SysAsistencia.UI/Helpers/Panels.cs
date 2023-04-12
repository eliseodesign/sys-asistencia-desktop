using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
namespace Esfe.SysAsistencia.UI.Helpers
{
    /// <summary>
    /// Clase de utilidad que proporciona métodos estáticos para la manipulación de paneles en una interfaz de usuario Windows Forms.
    /// Estos métodos permiten sustituir o agregar un formulario hijo en un panel, limpiando o reemplazando los formularios hijos existentes en el panel.
    /// </summary>
    public static class Panels
    {
        public static void SustituirPanel(Panel panel,Object formHijo)
        {
            if (panel.Controls.Count > 0)
            {
                // limpiamos los elementos dentro del panel
                panel.Controls.Clear();
                Form fH = formHijo as Form;
                fH.TopLevel = false;
                fH.Dock = DockStyle.Fill;
                panel.Controls.Add(fH);
                panel.Tag = fH;
                fH.Show();
            }

        }
        public static void AgregarPanel(Panel panel, Object formHijo)
        {
            if(panel.Controls.Count > 0)
            {
                panel.Controls.Clear();
            }
            Form fH = formHijo as Form;
            fH.TopLevel = false;
            fH.Dock = DockStyle.Fill;
            panel.Controls.Add(fH);
            panel.Tag = fH;
            fH.Show();
        }
    }
}
