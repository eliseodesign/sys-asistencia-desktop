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
using DPFP;
using Esfe.SysAsistencia.UI.Components;

namespace Esfe.SysAsistencia.UI
{
    public class MySingleton
    {
        private static MySingleton _instance = null;
        private DPFP.Template Template;
        public bool TemplateIsNull = false;
        public bool IsAsistenciaFinished = true;

        public VerificarAsistenciaWF AsistenciasVerifyOBJ;
        
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

        

    }
}
