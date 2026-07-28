namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1 COMPILACION
            ProductHelper helper = new ProductHelper();

            string etiqueta = helper.ObtenerEtiquetaProducto(1001, "Coca Cola 500ml", 1500.50m);
            Console.WriteLine(etiqueta);
           
            //EJERCICIO 2 COMPILACION

            Problema2 p2 = new Problema2();
             Console.WriteLine(p2.CrearResumenVenta(1001, "Fernet Branca 750ml", 3, 9500.50m));
             Console.WriteLine(p2.CrearResumenVenta(1001, "Fernet Branca 750ml", -1, 9500.50m)); 
            
            //EJERCICIO 3 COMPILACION
            Problema3 p3 = new Problema3();
            Product producto = new Product("Descripcion original");
            Console.WriteLine(p3.CompararCopias(999, producto));
            
            //EJERCICIO 4 COMPILACION
            Problema4 p4 = new Problema4();
            Console.WriteLine(p4.CalcularPromedio(8, 6, 10));  //aca esta todo bien porque las notas son validas 
            Console.WriteLine(p4.CalcularPromedio(8, null, 10)); //aca tambien esta todo joya porque las notas son validas
            Console.WriteLine(p4.CalcularPromedio(null, null, null)); // 0
            Console.WriteLine(p4.CalcularPromedio(8, -1, 10));   // ignora -1 porque no es una nota aceptada, promedio de 8 y 10 = 9
            Console.WriteLine(p4.CalcularPromedio(8, 15, 10));   // ignora 15 porque no es una nota aceptada tampoco, promedio de 8 y 10 = 9
            
            //EJERCICIO 5 COMPILACION
            Problema5 p5 = new Problema5();
            RetailSale retail = new RetailSale(15000m);
            WholesaleSale wholesale = new WholesaleSale(15000m);
            Console.WriteLine(p5.ObtenerImporteFinal(retail)); //Aca se retorna el importe sin el descuento 
            Console.WriteLine(p5.ObtenerImporteFinal(wholesale)); //y aca muestro el importe pero con el descuento del %10
            
            //EJERCICIO 6 COMPILACION
            Problema6 p6 = new Problema6();
            Console.WriteLine(p6.NormalizarCodigoProducto(" ab 123 x ")); // AB-123-X
            Console.WriteLine(p6.NormalizarCodigoProducto(null));          // SIN-CODIGO
            Console.WriteLine(p6.NormalizarCodigoProducto("red label"));   // RED-LABEL
          
        }
    }
}
