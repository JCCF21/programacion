using System;

namespace Program1
{
    class OperadoresMatematicos
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            string? entrada;
            int num1, num2, num3;
            double result;
            Console.WriteLine("Introduzca Tres numeros: ");
            Console.Write("Primer numero: ");
            entrada = Console.ReadLine();
            num1 = EsUnNumero(entrada) ;

            Console.Write("Segundo numero: ");
            entrada = Console.ReadLine();
            num2 = EsUnNumero(entrada);
            
            siEsCero:
            Console.Write("Tercer numero: ");
            entrada = Console.ReadLine();
            num3 = EsUnNumero(entrada);

            try
            {
                result = (num1 + num2) / num3;
                Console.WriteLine($"El resultado de la Operacion: {num1} + {num2} / {num3} es: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("No es posible dividir Entre 0.");
                goto siEsCero;
            }

        }

        static int EsUnNumero(string? entrada)
        {
            int num;
            
            if(!int.TryParse(entrada, out num))
            {
                Console.WriteLine("numero NO valido.");
                Console.WriteLine("Vuelva a Intentar...");
    
                while (!int.TryParse(entrada, out num))
                {
                    entrada = Console.ReadLine();
                };
                 
            }
            return num;
        }
    }
}