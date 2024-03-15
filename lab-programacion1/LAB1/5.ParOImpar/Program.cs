// 5. pedir un numero y mostrar si es par o impar
using System;
using System.Threading;

namespace ParOImpar
{
    class Program
    {
        public static void Main(string[] args)
        {
            string? entrada;
            do
            {
                Console.Clear();
                int numero;

                Console.WriteLine(@"    ¿Es Par o Impar?");
                Console.WriteLine("************************");
                Console.Write("Ingrese Numero a verificar: ");
                entrada = Console.ReadLine();
                numero = ValidEntry(entrada);
                Console.WriteLine(ParOImpar(numero));
                Console.WriteLine(@"Pulse ""C"" para continuar o ""S"" para salir...:");
                entrada = Console.ReadLine();
                if (entrada != null)
                    entrada.ToLower().Trim();

                while (entrada != "s" && entrada != "c")
                {
                    Console.WriteLine(@"Pulse ""C"" para continuar o ""S"" para salir...:");
                    entrada = Console.ReadLine();
                    if (entrada != null)
                        entrada.ToLower().Trim();
                    Console.Clear();

                }
            } while (entrada == "c" && (entrada != "s"));

        }
        public static int ValidEntry(string? entrada)
        {
            int num;
            if (!int.TryParse(entrada, out num))
            {
                do
                {
                    Console.WriteLine("Entrada Invalidad..Ingrese un numero ");
                    Thread.Sleep(3000);
                    entrada = Console.ReadLine();

                } while (!int.TryParse(entrada, out num));
            }
            return num;
        }
        public static string ParOImpar(int num)
        {
            return (num % 2) == 0 ? "Es par!" : "Es Impar!";
        }
    }
}