using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEdit
{
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
        }
        //Sobrecargamos el constructor con parametros
        public MsgBox(string pTipo, string pMensaje)
        {
            InitializeComponent();
            lblMsg.Text = pMensaje;//cambiamos el text del label por el string que recibimos
            //Condición para mostrar imagen y cambiar color
            switch (pTipo)
            {
                case "question":
                    lblTitulo.Text = "¿Pregunta?";//Cambiamos el label titulo
                    lblTitulo.ForeColor = Color.White;//color de letra
                    pL1.BackColor = Color.White;//panel la primera línea
                    pbQue.Visible = true;//mostramos la imagen
                    break;
                case "filled":
                    lblTitulo.Text = "Completado";//Cambiamos el label titulo
                    lblTitulo.ForeColor = Color.FromArgb(94, 226, 51);//color de letra
                    pL1.BackColor = Color.FromArgb(94, 226, 51);//panel la primera línea
                    btnCancel.Visible = false;
                    pbfilled.Visible = true;//mostramos la imagen
                    break;
                case "info":
                    lblTitulo.Text = "Informacion";//Cambiamos el label titulo
                    lblTitulo.ForeColor = Color.FromArgb(80, 71, 196);//color de letra
                    pL1.BackColor = Color.FromArgb(80, 71, 196);//panel la primera línea
                    btnCancel.Visible = false;
                    pbInformation.Visible = true;//mostramos la imagen
                    break;
                case "warning":
                    lblTitulo.Text = "¡Precaución!";//Cambiamos el label titulo
                    lblTitulo.ForeColor = Color.FromArgb(255, 193, 7);//color de letra
                    pL1.BackColor = Color.FromArgb(255, 193, 7);//panel la primera línea
                    pbWar.Visible = true;//mostramos la imagen
                    break;
                case "onlywarning":
                    lblTitulo.Text = "¡Advertencia!";//Cambiamos el label titulo
                    lblTitulo.ForeColor = Color.FromArgb(255, 193, 7);//color de letra
                    pL1.BackColor = Color.FromArgb(255, 193, 7);//panel la primera línea
                    btnCancel.Visible = false;
                    pbWar.Visible = true;//mostramos la imagen
                    break;
                case "error":
                    lblTitulo.Text = "¡Error!";//Cambiamos el label titulo
                    lblTitulo.ForeColor = Color.FromArgb(244, 67, 54);//color de letra
                    pL1.BackColor = Color.FromArgb(244, 67, 54);//panel la primera línea
                    pbError.Visible = true;//most
                    break;
                case "onlyerror":
                    lblTitulo.Text = "¡Error!";//Cambiamos el label titulo
                    lblTitulo.ForeColor = Color.FromArgb(244, 67, 54);//color de letra
                    pL1.BackColor = Color.FromArgb(244, 67, 54);//panel la primera línea
                    btnCancel.Visible = false;
                    pbError.Visible = true;//most
                    break;
                default:
                    lblTitulo.Text = "Error al seleccionar";
                    break;
            }
        }
        //Evento para los botones, cuando el mouse entre en el bóton
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.Transparent;
            b.ForeColor = Color.FromArgb(0, 111, 230);
        }
        //Evento cuando el mouse sale del bóton
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.FromArgb(0, 111, 230);
            b.ForeColor = Color.White;
        }
        //Evento click del bóton aceptar
        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;//enviamos OK
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;//enviamos cancel.
        }

    }
}
