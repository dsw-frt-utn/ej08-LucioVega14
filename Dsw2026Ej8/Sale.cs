using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal Importe { get; set; }

        public Sale(decimal importe)
        {
            Importe = importe;
        }

        public virtual decimal CalculateTotal()
        {
            return Importe;
        }
    }
}
