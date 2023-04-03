using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // librería para mover ventana
using Esfe.SysAsistencia.EN.Static;
using Esfe.SysAsistencia.UI.Helpers;

namespace Esfe.SysAsistencia.UI
{
    public partial class MainWF : Form
    {
        public MainWF()
        {
            InitializeComponent();
            //txtUseKey.PasswordChar = '*'; // definir * para ocultar caracteres
            Panels.AgregarPanel(this.panelGeneral, new LoginWF(this.panelGeneral));
        }
    }
}
