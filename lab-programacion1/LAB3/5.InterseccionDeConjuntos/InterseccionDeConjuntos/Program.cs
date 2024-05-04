/*5.Escribe un programa que tome dos conjuntos de números enteros y encuentre la
 * intersección de ambos conjuntos, es decir, los números que están presentes en ambos conjuntos
 */
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Console.WriteLine("\t\t\tINTERSECCION DE CONJUSTOS");
        Console.WriteLine("=========================================================================");
       
        HashSet<int> conjunto1 = new HashSet<int>();
        HashSet<int> conjunto2 = new HashSet<int>();

        Console.WriteLine("Introduce los numeros para el primer conjunto (separados por espacios): ");
        string[] entrada1 = Console.ReadLine().Split(' ');
        foreach (string num in entrada1)
        {
            if (int.TryParse(num, out int numero))
            {
                conjunto1.Add(numero);
            }
            else
            {
                Console.WriteLine($"'{num}' no es un numero entero valido y sera ignorado.");
            }
        }

       
        Console.WriteLine("Introduce los numeros para el segundo conjunto (separados por espacios): ");
        string[] entrada2 = Console.ReadLine().Split(' ');
        foreach (string num in entrada2)
        {
            if (int.TryParse(num, out int numero))
            {
                conjunto2.Add(numero);
            }
            else
            {
                Console.WriteLine($"'{num}' no es un numero entero valido y sera ignorado.");
            }
        }

        
        conjunto1.IntersectWith(conjunto2);

 
        if (conjunto1.Count > 0)
        {
            
            Console.WriteLine("La intersección de ambos conjuntos es: ");
            foreach (int num in conjunto1)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No hay interseccion entre los dos conjuntos.");
        }
    }
}
