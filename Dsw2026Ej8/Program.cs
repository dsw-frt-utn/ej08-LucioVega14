namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1 COMPILACION
            /*ProductHelper helper = new ProductHelper();

            string etiqueta = helper.ObtenerEtiquetaProducto(1001, "Coca Cola 500ml", 1500.50m);
            Console.WriteLine(etiqueta);
            ==========================================
            ==========================================*/
            //EJERCICIO 2 COMPILACION

            /* Problema2 p2 = new Problema2();
             Console.WriteLine(p2.CrearResumenVenta(1001, "Fernet Branca 750ml", 3, 9500.50m));
             Console.WriteLine(p2.CrearResumenVenta(1001, "Fernet Branca 750ml", -1, 9500.50m)); // quantity <= 0, total = 0
            En el segundo me fijo si realmente el total da 0 al ser la cantidad <=0 
            ===========================================
            ===========================================*/
            //EJERCICIO 3 COMPILACION
            /*Problema3 p3 = new Problema3();
            Product producto = new Product("Descripcion original");
            Console.WriteLine(p3.CompararCopias(999, producto));
            ===========================================
            ===========================================*/
            //EJERCICIO 4 COMPILACION
            /*Problema4 p4 = new Problema4();
            Console.WriteLine(p4.CalcularPromedio(8, 6, 10));  aca esta todo bien porque las notas son validas 
            Console.WriteLine(p4.CalcularPromedio(8, null, 10)); aca tambien esta todo joya porque las notas son validas
            Console.WriteLine(p4.CalcularPromedio(null, null, null)); // 0
            Console.WriteLine(p4.CalcularPromedio(8, -1, 10));   // ignora -1 porque no es una nota aceptada, promedio de 8 y 10 = 9
            Console.WriteLine(p4.CalcularPromedio(8, 15, 10));   // ignora 15 porque no es una nota aceptada tampoco, promedio de 8 y 10 = 9
            ===========================================
            ===========================================*/
        }
    }
}
