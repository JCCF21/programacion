/*
 * 3.Crea una lista de strings que contenga nombres de ciudades. Permite al usuario agregar nuevas ciudades a la
lista y luego muestra todas las ciudades ingresadas.
 */
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> ciudades = new List<string>();
        Console.WriteLine("\t\t\tCIUDADES");
        Console.WriteLine("==============================================================");

        while (true)
        {
            Console.WriteLine("Ingrese el nombre de una ciudad (o 'salir' para terminar):");
            string ciudad = Console.ReadLine();

            if (ciudad.ToLower() == "salir")
            {
                break;
            }

            ciudades.Add(ciudad);
        }

        Console.WriteLine("\nCiudades ingresadas:");
        foreach (string ciudad in ciudades)
        {
            Console.WriteLine(ciudad);
        }
    }
}
