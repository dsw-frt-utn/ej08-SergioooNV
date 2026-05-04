using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio5
{
    public class Sale
    {
        public decimal Subtotal { get; set; }

        public Sale(decimal subtotal)
        {
            Subtotal = subtotal;
        }

        public virtual decimal CalculateTotal()
        {
            return Subtotal;
        }
    }
}
