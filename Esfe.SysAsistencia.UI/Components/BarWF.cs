using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esfe.SysAsistencia.UI.Helpers;

namespace Esfe.SysAsistencia.UI.Components
{
    public partial class BarWF : Form
    {
        public BarWF()
        {

            InitializeComponent();
            if (State.DocenteLoged != null)
                txtLoginNombre.Text = State.DocenteLoged.Nombres.ToString();
            else
                txtLoginNombre.Text = "Admin";
        }

        private void GuardarDatos_Click(object sender, EventArgs e)
        {
            JsonData.GuardarDatos();
        }
    }
}
