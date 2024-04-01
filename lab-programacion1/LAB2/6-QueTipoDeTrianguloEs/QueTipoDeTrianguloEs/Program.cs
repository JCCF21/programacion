/*
 
6.Pedir al usuario las longitudes de los lados de un triángulo y
usar switch para clasificarlo como equilátero, isósceles o escaleno.
 
 */

using System;

namespace LAB2
{
  public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t¿Que Tipo De Triangulo Es?");
            Console.WriteLine("======================================");
            Console.WriteLine("Introduzaca La medida de Cada Lado: ");
            float[] lados = new float[3];

            for (int i = 0; i < lados.Length; i++)
            {
                Console.Write($"{i + 1}° Lado: ");
                lados[i] = ValidEntry();
            }


            if (lados[0] == lados[1] && lados[1] == lados[2])
            {
                Console.WriteLine($"El triangulo es equilatero ");
            }
            else if ((lados[0] == lados[1] && lados[1] != lados[2]) || (lados[0] == lados[2] && lados[2] != lados[1])|| (lados[1] == lados[2] && lados[2] != lados[0]))
            {
                Console.WriteLine("El triangulo El Isoceles ");
            }
            else
            {
                Console.WriteLine("El triangulo es escaleno");
            }

        }     

        public static float ValidEntry()
        {
            bool exito = false;
            float num = 0.0f;
            do
            {
                try
                {
                    num = Convert.ToSingle(Console.ReadLine());
                    exito = true;
                }
                catch
                {
                    Console.Write("Por favor Introduzca un numero valido...: ");
                }
            } while (!exito);
            return num;
        }
    }
   
}