/* 4.Crea
un diccionario donde las claves sean nombres de países y los valores sean
capitales. Permite al usuario buscar la capital de un país ingresando el nombre
del país.
 */
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Dictionary<string, string> paises = new Dictionary<string, string>();
    
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\t\t\tDiccionario De Capitales");
            Console.WriteLine("=============================================================================================\n");
            Console.WriteLine("¿Qué te gustaría hacer? (1: Agregar Un Pais,  2: Mostrar Paises, 3: Buscar capital, 4: Salir)");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Ingrese el nombre de un pais:");
                    string pais = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre de su capital: ");
                    string capital = Console.ReadLine();
                    
                    if (pais != null)
                    paises.Add(pais, capital);
                    
                    break;
                
                case "2":
                    Console.WriteLine("\nPaises ingresados:");
                    foreach (var p in paises)
                    {
                        Console.WriteLine(p.Key);
                    }
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Ingrese el nombre de un pais:");
                    pais = Console.ReadLine();
                    if (paises.ContainsKey(pais))
                    {
                        Console.WriteLine("La capital de " + pais + " es " + paises[pais] + ".");
                    }
                    else
                    {
                        Console.WriteLine("Lo siento, no tengo informacion sobre la capital de " + pais + ".");
                    }
                    Console.ReadKey();
                    break;
                    
                case "4":
                    return;
                default:
                    Console.WriteLine("Opcion no valida. Por favor, intente de nuevo.");
                    break;
            }
        }
    }
}
