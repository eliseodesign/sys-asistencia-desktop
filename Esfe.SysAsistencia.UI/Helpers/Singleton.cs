using Esfe.SysAsistencia.EN;
using Esfe.SysAsistencia.BL;
using Esfe.SysAsistencia.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esfe.SysAsistencia.UI
{
    public class MySingleton
    {
        private static MySingleton _instance = null;
        private DPFP.Template Template;

        private MySingleton() { }

        public static MySingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MySingleton();
                }

                return _instance;
            }
        }
        // --------------- Declaraciones

        public void SetColumnsToGrid(DataGridView grid, string[] columnNames, int gridCount = 2)
        {
            grid.AutoGenerateColumns = false;
            grid.ColumnCount = gridCount;

            for(int i=0; i < gridCount; i++)
            {
                grid.Columns[i].Name = columnNames[i];
                grid.Columns[i].DataPropertyName = columnNames[i];
                grid.Columns[i].Width = 100;
            }
        }
    }
}
