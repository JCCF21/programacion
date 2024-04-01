/*
 *7.Pedir al usuario la temperatura en grados Celsius y utilizar 
 *if para convertirla a Fahrenheit.
 */

using System;
using System.Globalization;

namespace conversor
{
    class Temperatura
    {
        public static void Main(string[] args)
        {
            double celsius, fahrenheit;
            bool exito = false;

            Console.WriteLine("***********************************************");
            Console.WriteLine("\tConventir Celsius A Fahrenheit");
            Console.WriteLine("***********************************************");
            Console.Write("Ingrese Celsio: ");
            string? entrada = Console.ReadLine();
            //fahrenheit = CelsiosAFahrenheit(celsius);

            if (double.TryParse(entrada, out celsius))
            {
                fahrenheit = celsius * 9 / 5 + 32;
                Console.WriteLine($"{celsius.ToString("#,#.##")}°Celsios = {fahrenheit.ToString("#,#.##")}° Fahrenheit");
            }
            else
            {
                do
                {
                    try
                    {
                        entrada = Console.ReadLine();
                        double.TryParse(entrada, out celsius);
                        exito = true;

                    }
                    catch
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingresa un número.");
                    }

                } while (!exito);

            }
        }
    }

}

