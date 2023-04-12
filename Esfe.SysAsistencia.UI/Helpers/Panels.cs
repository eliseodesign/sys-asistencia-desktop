using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.UI.Helpers
{
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
