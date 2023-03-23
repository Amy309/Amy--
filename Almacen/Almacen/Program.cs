// See https://aka.ms/new-console-template for more information
using Almacen.DAO;
using Almacen.Models;

//Console.WriteLine("Hello, World!");

#region Anterior
//using AlmacenContext db = new AlmacenContext();

//Producto producto = new Producto();

//Console.WriteLine("Ingrese nombre del producto");
//producto.Nombre = (Console.ReadLine());

//Console.WriteLine("Ingrese descripciòn");
//producto.Descripcion = (Console.ReadLine());

//Console.WriteLine("Ingrese el precio");
//producto.Precio = Convert.ToDecimal(Console.ReadLine());

//Console.WriteLine("Ingrese el stock");
//producto.Stock = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Los datos que ingreso son: Nombre {producto.Nombre}, Descripcion {producto.Descripcion}, Precio {producto.Precio} y Stock {producto.Stock} ");

//db.Productos.Add(producto);
//db.SaveChanges();
#endregion
CrudProductos CrudProductos = new CrudProductos();
Producto producto = new Producto();

Console.Write("Menu\n");
Console.Write("Presione 1 para ingresar producto\n");
Console.Write("Presione 2 para salir\n");

var Menu = Convert.ToInt32(Console.ReadLine());

switch (Menu)
{
    case 1:
        bool bucle = true;
        while(bucle == true)
        {
            Console.Write("Ingrese el nombre del producto");
            producto.Nombre = Console.ReadLine();
            Console.Write("\nIngrese una breve descripcion del producto");
            producto.Descripcion = Console.ReadLine();
            Console.Write("\nIngrese el precio del producto");
            producto.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.Write("\nIngrese la cantidad de productos existentes");
            producto.Stock = Convert.ToInt32(Console.ReadLine());

            CrudProductos.AgregarProductos(producto);

            Console.Write("Se ingreso correctamente\n");
            Console.Write("Presione 1 para ingresar producto\n");
            Console.Write("Presione 2 para salir\n");

            var Menu2 = Convert.ToInt32(Console.ReadLine());

            switch (Menu2)
            {
                case 1:
                    bucle = true;
                    break;

                case 2:
                    Console.Write("Gracias por utilizar el programa");
                    bucle = false;
                    break;

                default:
                    Console.Write("Ingrese una opcion del menu");
                    break;
            }
        }
        break;

    case 2:
        Console.Write("Gracias por utilizar el programa");
        break;

    default:
        Console.Write("Ingrese una opcion del menu");
        break;
}