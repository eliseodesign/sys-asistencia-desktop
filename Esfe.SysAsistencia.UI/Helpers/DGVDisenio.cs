using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esfe.SysAsistencia.UI.Helpers
{
    public static class DGVDisenio
    {
        //Método para dar formato al DataGridView, recibimos dos paramateros uno tipo DataGrid y otro int para la selección del color.
        public static void Formato(DataGridView pData, int color)
        {
            //Font para las filas
            pData.RowsDefaultCellStyle.Font = new Font("Open Sans", 10f, FontStyle.Regular);
            //Font para las columnas
            pData.ColumnHeadersDefaultCellStyle.Font = new Font("Lato", 12f, FontStyle.Bold);
            //Ancho de columnas
            pData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Alto de las filas
            pData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //No se agrege columnas automaticamente
            pData.AutoGenerateColumns = false;
            //Quitamos el borde
            pData.BorderStyle = BorderStyle.None;
            pData.EnableHeadersVisualStyles = false;
            pData.RowHeadersVisible = false;
            pData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //Color de letra de las columnas
            pData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            switch (color)
            {
                case 1:
                    //Columna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 129, 189);
                    //Fila
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(184, 204, 228);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(143, 191, 231);
                    pData.RowsDefaultCellStyle.Padding = new Padding(0, 3, 0, 3);
                    //Fila alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 230, 241);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(119, 174, 223);
                    pData.AlternatingRowsDefaultCellStyle.Padding = new Padding(0, 3, 0, 3);
                    break;
                case 2:
                    //Columna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 0);
                    //Fila
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(166, 166, 166);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 149, 183);
                    //Fila alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(217, 217, 217);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(141, 183, 216);
                    break;
                case 3:
                    //Columna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 80, 77);
                    //Fila
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(230, 184, 183);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(149, 161, 194);
                    //Fila alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 220, 219);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(157, 185, 217);
                    break;
                case 4:
                    //Columna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(155, 187, 89);
                    //Fila
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(216, 228, 188);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(140, 190, 197);
                    //Fila alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 241, 222);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(152, 198, 219);
                    break;
                case 5:
                    //Columna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 100, 162);
                    //Fila
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(204, 192, 218);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(132, 166, 216);
                    //Fila alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(228, 223, 236);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(148, 186, 228);
                    break;
                case 6:
                    //Columna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 172, 198);
                    //Fila
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(183, 222, 232);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(118, 186, 226);
                    //Fila alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 238, 243);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(141, 196, 233);
                    break;
                case 7:
                    //Columna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(247, 150, 70);
                    //Fila
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(252, 213, 180);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(163, 180, 192);
                    //Fila alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(253, 233, 217);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(164, 193, 216);
                    break;
            }
        }
    }
}
