//3.Utilizar if para
//verificar si un número introducido por el usuario es par o impar.
using System;

namespace LAB2
{
    public class Program
    {
        public static void Main()
        {
            string? opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("\t¿ Par O Impar ? ");
                Console.WriteLine("================================");
                Console.WriteLine("Introduzca Un numero: ");
                int numero=0;
                bool valid = false;
                do
                {
                    try
                    {
                        numero = Convert.ToInt32(Console.ReadLine());
                        valid = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($" Solo se abmiten numeros");
                    }
                    
                }while (!valid);



                if (numero % 2 == 0)
                {
                    Console.WriteLine($"El numero {numero.ToString("#,#")} es Par!");
                }
                else
                {
                    Console.WriteLine($"El numero {numero.ToString("#,#")} es Impar! ");
                }
                Console.WriteLine("\n\nPluse R para reinciar o culquier tecla para Salir....");
                opcion = Console.ReadLine();
                if(opcion != null)
                opcion.Trim().ToLower();
               
            } while (opcion == "r") ;
        }

    }
    

}