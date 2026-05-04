using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio6
{
    public static class Extensiones
    {
        public static string ToProductCode(this string code)
        {
            if (code == null)
            {
                return "Sin-Codigo";
            }

            return code.Trim().ToUpper().Replace(" ", "-");
        }
    }
}
