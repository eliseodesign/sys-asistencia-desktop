using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataEdit;
using Esfe.SysAsistencia.UI.Helpers;

namespace Esfe.SysAsistencia.UI.Components
{
    public partial class _SelectGrupo : Form
    {
        public List<string> _ListGruposSelect;
        public _SelectGrupo(string carrera, List<string> ListGruposSelect)
        {
            _ListGruposSelect = ListGruposSelect;
            InitializeComponent();
            //UpdateGrupos(carrera);
        }

        //private void UpdateGrupos(string _carrera)
        //{
        //    //Verificar primero si el grupo ya tiene un docente?????
        //    foreach (var gg in State.grupoBL.ObtenerGrupos().Where(g => g.Carrera == _carrera && g.DocenteId == 0).Select(g => g.Codigo))
        //    {
        //        clbGruposCarrera.Items.Add(gg);
        //    }
        //}
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (clbGruposCarrera.CheckedItems.Count > 0)
            {
                _ListGruposSelect.Clear();
                foreach (var g in clbGruposCarrera.CheckedItems)
                {
                    _ListGruposSelect.Add(g.ToString());
                }

                MsgBox msg = new MsgBox("filled", "Los Grupos se seleccionaron correctamente");
                msg.ShowDialog();
              
                this.Close();
            }
            else
            {
                MsgBox msg = new MsgBox("onlyerror", "Debe seleccionar los grupos en donde estará el docente");
                msg.ShowDialog();
 
            }

        }
    }
}
