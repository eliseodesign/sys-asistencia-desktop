using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esfe.SysAsistencia.UI.Components
{
    public partial class DocentesWF : Form
    {
        public Panel _panel_app;
        public DocentesWF(Panel PanelApp)
        {
            _panel_app = PanelApp;
            InitializeComponent();
        }
    }
}
