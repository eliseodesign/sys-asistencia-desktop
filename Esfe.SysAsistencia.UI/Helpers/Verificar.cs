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
    /// <summary>
    /// Clase que proporciona métodos para verificaciones y validaciones en la interfaz de usuario de la aplicación de asistencia.
    /// </summary>
    public class Verificar
    {
        /// <summary>
        /// Verifica si una colección de elementos es del tipo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de elementos en la colección</typeparam>
        /// <param name="coleccion">Colección de elementos</param>
        /// <param name="tipo">Tipo a verificar</param>
        /// <returns>true si todos los elementos de la colección son del tipo especificado, false en caso contrario</returns>
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
