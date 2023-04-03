using Esfe.SysAsistencia.BL;
using Esfe.SysAsistencia.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.UI.Helpers
{
    public class Verificar
    {
        private DocenteBL pruebaxd = new DocenteBL();
        public static bool VerificarTipo<T>(IEnumerable<T> coleccion, Type tipo)
        {
            foreach (var elemento in coleccion)
            {
                if (!tipo.IsInstanceOfType(elemento))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool validarNumeros(KeyPressEventArgs e)
        {
            //Metodo para permitir solamente numeros
            string cadena = @".*[-]{1}$";
            Regex Rg = new Regex(@"[^01-9\-]");//Cadena de caracteres
            if (Rg.IsMatch(e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return false;
            }

            else
            {
                e.Handled = false;
                return true;

            }


            //if (Char.IsNumber(e.KeyChar))
            //{
            //    e.Handled = false;
            //    return true;
            //}
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //    return true;
            //}
            //else if (e.KeyChar == ' ' &&  e.KeyChar == '-')

            //{
            //    e.Handled = false;
            //    return true;
            //}
            //else
            //{
            //    e.Handled = true;
            //    return false;
            //}
        }

        public static bool validarLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }
    }
}
