using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal importe) : base(importe)
        {
        }

        public override decimal CalculateTotal()
        {
            return Importe * 0.90m; // 10% de descuento
        }
    }
}
