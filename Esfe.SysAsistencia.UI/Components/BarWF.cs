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
                txtLoginNombre.Text = State.DocenteLoged.Nombre.ToString() + "     ";
            else
                txtLoginNombre.Text = "Admin     ";

            SetHourBar();
        }

        private void GuardarDatos_Click(object sender, EventArgs e)
        {
            JsonData.GuardarDatos();
        }

        private void timeHour_Tick(object sender, EventArgs e)
        {
            SetHourBar();
        }

        void SetHourBar()
        {
            DateTime currentTime = DateTime.Now;
            string timeString = currentTime.ToString("h:mm tt");
            lblHour.Text = timeString;
        }
    }
}
