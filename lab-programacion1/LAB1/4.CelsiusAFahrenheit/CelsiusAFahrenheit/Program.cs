// 4. Convertir de grados Celsius a Fahrenheit.
//Formula C x 9/5(1.8) + 32

using System;
using System.Globalization;

namespace conversor
{
    class Temperatura
    {
        public static void Main(string[] args)
        {
            double celsius, fahrenheit;
            string? entrada;
            Console.WriteLine("***********************************************");
            Console.WriteLine("\tConventir Celsius A Fahrenheit");
            Console.WriteLine("***********************************************");
            Console.Write("Ingrese Celsio: ");
            entrada = Console.ReadLine();
            celsius = ValidarEntrada(entrada);
            fahrenheit = CelsiosAFahrenheit(celsius);
            Console.WriteLine($"{celsius.ToString("#,#",CultureInfo.InvariantCulture)}°Celsios = {fahrenheit.ToString("#,#.#",CultureInfo.InvariantCulture):F2}° Fahrenheit");
        }
        private static double ValidarEntrada(string? entrada)
        {
            double number;
            if (!double.TryParse(entrada,out number)) 
            {
                do
                {
                    Console.WriteLine("Entrada Invalida...Trate nuevamente");
                    entrada = Console.ReadLine();

                }while (!double.TryParse(entrada, out number));
            }
            return number;
        }
        private static double CelsiosAFahrenheit(double celsius)
        {
            return celsius * 1.8 + 32;
        }
    }

}

