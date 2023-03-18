using Asincrona_s8_Almacen.Models;

Console.WriteLine("          ---------------------------------------------------------------------       ");
Console.WriteLine("             Bienvenido a almacenes roock          ");
Console.WriteLine("          ---------------------------------------------------------------------       ");

AlmacenContext db = new AlmacenContext();
Producto producto = new Producto();

Console.WriteLine();

Console.Write("Ingrese el nombre de el producto ");
producto.Nombre = Console.ReadLine();
Console.Write("Describa el producto ");
producto.Descripcion = Console.ReadLine();
Console.Write("Ingrese el precio que tendra el producto ");
producto.Precio = Convert.ToDecimal(Console.ReadLine());
Console.Write("Ingrese la cantidad de productos de stock ");
producto.Stock = Convert.ToInt32(Console.ReadLine());

db.Producto.Add(producto);
db.SaveChanges();

Console.WriteLine("   el producto ha sido registrado con exito   ");
Console.WriteLine(" ...........................................");
Console.WriteLine(" Id Cantidad. Productos Descripcion Precio ");
Console.WriteLine(" ...........................................");

Console.WriteLine();

var ListaProductos = db.Producto.ToList();
foreach (var product in ListaProductos){

    Console.WriteLine($"  {product.Id}  {product.Stock}    {product.Nombre} / {product.Descripcion} / ${product.Precio}");
}


Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("         Gracias por preferirnos como su tienda online          ");
Console.WriteLine("-------------------------------------------------------------------------");
