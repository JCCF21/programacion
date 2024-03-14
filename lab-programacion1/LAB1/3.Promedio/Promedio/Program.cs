/* 3.Calcular
el promedio de 10 números recibidos por teclado y presenta el resultado de los
primeros 5 y luego el resultado general*/
using System;

namespace Promedio
{
    class Promedio
    {
        static void Main(string[] args)
        {
            double[] numerosArray = new double[10];
            
            double num = 0.0;
            double num2 = 0.0;
            int divisor = numerosArray.Length;
            double promedio = 0.0;
            Console.WriteLine("Este Programa calculara el promedio de 10 numero ingresados por teclado");
            Console.WriteLine("************************************************************************");
                             
            RecolectarNum(numerosArray);
           
            for (int i = 0; i < numerosArray.Length; i++) 
            {      
                if(i<= 4)
                {
                    num2 = num2 + numerosArray[i];
                }
                num = num + numerosArray[i];
            }
            promedio = num2 / (divisor / 2);

            Console.WriteLine($"El Promedio de los primero 5 digitos es: {promedio}");
            promedio = num / (divisor);
            Console.WriteLine($"El Promedio de Todos los Numero es: {promedio}");    
            
        }
        private static double[] RecolectarNum(double[] array)
        {
            double numero;
            string? entrada;
            Console.WriteLine("Ingrese datos Solicitados:");
            
            for (int i = 0; i < array.Length; i++) 
            {                
                Console.Write($"{i +1}` Numero: ");
                entrada = Console.ReadLine();
                numero = ValidarEntrada(entrada);
                array[i] = numero;
            }
            return array;
        }
        private static double ValidarEntrada(string? entrada)
        {
            double number;
            double.TryParse(entrada, out number);

            if (!double.TryParse(entrada, out number))
            {
                while (!double.TryParse(entrada, out number))
                {
                    Console.WriteLine("entrada Invalida. Vuelva a tratar...");
                    entrada = Console.ReadLine();
                }
            }
            return number;
        }
    }
}