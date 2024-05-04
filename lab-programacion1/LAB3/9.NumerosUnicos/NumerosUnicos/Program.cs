/*
 9. Escribe un programa que tome dos listas de números enteros y encuentre los números únicos
    que están presentes en ambas listas, es decir, los números que no se repiten en
    ninguna de las dos listas.
*/

using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        // Pedir al usuario que introduzca los números para la primera lista
        Console.WriteLine("Introduce los numeros para la primera lista (separados por espacios): ");
        string[] entrada1 = Console.ReadLine().Split(' ');
        List<int> lista1 = new List<int>();
        for (int i = 0; i < entrada1.Length; i++)
        {
            if (int.TryParse(entrada1[i], out int num))
            {
                lista1.Add(num);
            }
            else
            {
                Console.WriteLine($"'{entrada1[i]}' no es un numero entero valido y sera ignorado.");
            }
        }

        // Pedir al usuario que introduzca los números para la segunda lista
        Console.WriteLine("Introduce los numeros para la segunda lista (separados por espacios): ");
        string[] entrada2 = Console.ReadLine().Split(' ');
        List<int> lista2 = new List<int>();
        for (int i = 0; i < entrada2.Length; i++)
        {
            if (int.TryParse(entrada2[i], out int num))
            {
                lista2.Add(num);
            }
            else
            {
                Console.WriteLine($"'{entrada2[i]}' no es un numero entero valido y sera ignorado.");
            }
        }

        // Unir las dos listas
        List<int> listaUnida = new List<int>(lista1);
        listaUnida.AddRange(lista2);

        // Encontrar los números que aparecen exactamente una vez en la lista unida
        List<int> numerosUnicos = new List<int>();
        for (int i = 0; i < listaUnida.Count; i++)
        {
            int num = listaUnida[i];
            if (!numerosUnicos.Contains(num) && ContarOcurrencias(listaUnida, num) == 1)
            {
                numerosUnicos.Add(num);
            }
        }

        // Imprimir los números únicos
        if (numerosUnicos.Count > 0)
        {
            Console.WriteLine("Los números que aparecen exactamente una vez en las listas son: ");
            for (int i = 0; i < numerosUnicos.Count; i++)
            {
                Console.WriteLine(numerosUnicos[i]);
            }
        }
        else
        {
            Console.WriteLine("No hay números que aparezcan exactamente una vez en las listas.");
        }
    }

    static int ContarOcurrencias(List<int> lista, int num)
    {
        int contador = 0;
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i] == num)
            {
                contador++;
            }
        }
        return contador;
    }
}
