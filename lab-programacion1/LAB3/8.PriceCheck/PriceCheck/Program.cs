/*  8.Crea un programa que solicite al usuario ingresar nombres de productos y sus precios,
    luego almacena esta información en un diccionario donde el nombre del producto
    es la clave y el precio es el valor. Después, permite al usuario buscar el
    precio de un producto ingresando su nombre.
 */

using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        Dictionary<string, double> productos = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("\tPRICE CHECK");
            Console.WriteLine("======================");
            Console.WriteLine("\n1. Ingresar producto");
            Console.WriteLine("2. Buscar producto");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opcion: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Introduce el nombre del producto: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Introduce el precio del producto: ");
                    double precio = double.Parse(Console.ReadLine());
                    productos[nombre] = precio;
                    Console.WriteLine($"Producto '{nombre}' con precio {precio} ha sido agregado.");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Write("Introduce el nombre del producto a buscar: ");
                    nombre = Console.ReadLine();
                    if (productos.TryGetValue(nombre, out precio))
                    {
                        Console.WriteLine($"El precio del producto '{nombre}' es {precio}.");
                    }
                    else
                    {
                        Console.WriteLine("El producto no se encuentra en la lista.");
                    }
                    Console.ReadKey();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opcion no valida. Por favor, elige una opcion del menu.");
                    break;
            }
        }
    }
}
