using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
         
         int copia = originalValue;
         copia++;
         Product productoCopia = product;
         productoCopia.ActualizarDescripcion("Descripcion modificada");
         return $"{originalValue}-{copia}-{product.Description}";
        }
    }
}
