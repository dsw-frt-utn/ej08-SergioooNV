using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio5
{
    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal subtotal) : base(subtotal)
        {

        }

        public override decimal CalculateTotal()
        {
            decimal totalSinDescuento = base.CalculateTotal();

            decimal descuento = totalSinDescuento * 0.10m;

            return totalSinDescuento - descuento;
        }
    }
}
