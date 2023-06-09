﻿using DataEdit;
using Esfe.SysAsistencia.UI.Components;
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
    public partial class AplicationWF : Form
    {
        public Panel _panelGeneral;
        Button[] buttons_list = new Button[4]; //Esta lista almacena los botones de Menu, para saber cual se ha presionado 
        public AplicationWF(Panel panel)
        {
            _panelGeneral = panel;
            InitializeComponent();
            // bar superior 
            Panels.AgregarPanel(panelBar, new BarWF());
            UserLoged();

            buttons_list[0] = btnAsistencia;
            buttons_list[1] = btnAlumnos;
            buttons_list[2] = btnDocentes;
            buttons_list[3] = btnGrupos;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MsgBox msg = new MsgBox("question", "¿Quieres salir del sistema?\nSe debera registrar nuevamente en el login.");
            msg.ShowDialog();

            if (msg.DialogResult == DialogResult.OK)
            {
                if (!MySingleton.Instance.IsAsistenciaFinished)
                {
                    MsgBox messages = new MsgBox("onlywarning", "La asistencia aún está activa");
                    messages.ShowDialog();
                    return;
                }

                State.TotalAccess = false;
                if (MySingleton.Instance.AsistenciasVerifyOBJ != null)
                {
                    MySingleton.Instance.AsistenciasVerifyOBJ.StopLector();
                }
                Panels.SustituirPanel(_panelGeneral, new LoginWF(_panelGeneral));
            }

        }


        //Botones del menu
        void SetButtonsColors(Button b)
        {
            var pressed_color = Color.FromArgb(60, 152, 222);
            var flat_color = Color.FromArgb(0, 40, 100);
            foreach (Button i in buttons_list)
            {
                i.BackColor = flat_color;
            }
            b.BackColor = pressed_color;
        }

        //Loged
        private void UserLoged() //En esta parte se le darán los privilegios al usuario
        {
            Panels.AgregarPanel(PanelApp, new HomeWF());
            if (!State.TotalAccess)
            {
                btnAlumnos.Enabled = false;
                btnDocentes.Enabled = false;
                btnGrupos.Enabled = false;
            }
            else
            {
                btnAsistencia.Enabled = false;
                //Nothing to do
            }
        }
        private void btnDocentes_Click(object sender, EventArgs e)
        {

            if (!MySingleton.Instance.IsAsistenciaFinished)
            {
                MsgBox messages = new MsgBox("onlywarning", "La asistencia aún está activa");
                messages.ShowDialog();
                return;
            }

            Panels.AgregarPanel(PanelApp, new DocentesWF(PanelApp));
            SetButtonsColors(btnDocentes);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {

            if (!MySingleton.Instance.IsAsistenciaFinished)
            {
                MsgBox messages = new MsgBox("onlywarning", "La asistencia aún está activa");
                messages.ShowDialog();
                return;
            }

            Panels.AgregarPanel(PanelApp, new AlumnosWF(PanelApp));
            SetButtonsColors(btnAlumnos);
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {

            if (!MySingleton.Instance.IsAsistenciaFinished)
            {
                MsgBox messages = new MsgBox("onlywarning", "La asistencia aún está activa");
                messages.ShowDialog();
                return;
            }

            Panels.AgregarPanel(PanelApp, new AsistenciaWF());
            SetButtonsColors(btnAsistencia);
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {

            if (!MySingleton.Instance.IsAsistenciaFinished)
            {
                MsgBox messages = new MsgBox("onlywarning", "La asistencia aún está activa");
                messages.ShowDialog();
                return;
            }

            Panels.AgregarPanel(PanelApp, new GruposWF(this));
            SetButtonsColors(btnGrupos);
        }

        private void lblAsitencia_Click(object sender, EventArgs e)
        {

            if (!MySingleton.Instance.IsAsistenciaFinished)
            {
                MsgBox messages = new MsgBox("onlywarning", "La asistencia aún está activa");
                messages.ShowDialog();
                return;
            }

            Panels.SustituirPanel(PanelApp, new HomeWF());
            foreach (Button i in buttons_list)
            {
                i.BackColor = Color.FromArgb(0, 40, 100);
            };
        }
    }
}
