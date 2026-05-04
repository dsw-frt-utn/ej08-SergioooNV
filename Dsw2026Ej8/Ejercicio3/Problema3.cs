using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio3
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int valorCopia = originalValue;
            
            valorCopia++;

            Product productoCopiado = product;

            productoCopiado.CambiarDescripcion("Nueva Descripcion Copiada");

            return $"{originalValue}-{valorCopia}-{productoCopiado.Description}";
        } 
    }
}
