/*6.Recibir
el nombres y apellidos de dos usuarios e imprimir por pantalla los nombres con
los apellidos intercambiados.*/
using System;

namespace SwapLastName
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            string? answer;
            do
            {
                string nomber1, appellido1, nombre2, apellido2;
                Console.WriteLine(" Intercambiador de apellidos");
                Console.WriteLine("*****************************");
                Console.WriteLine("Introduzca Primera persona Nombre: ");
                nomber1 = Console.ReadLine();
                Console.WriteLine("Introduzca Primera persona apellido: ");
                appellido1 = Console.ReadLine();
                Console.WriteLine("Introduzca Segunda Persona nombre: ");
                nombre2 = Console.ReadLine();
                Console.WriteLine("Introduzca Segunda Persona nombre: ");
                apellido2 = Console.ReadLine();

                Console.WriteLine("\nLos alpellidos han sido cambiados....");
                Console.WriteLine($"\nPrimera Persona ahora es: {nomber1} {apellido2}\nLa Segunda persona Ahora es:{nombre2} {appellido1}");

                Console.Write("\n\nDesea tratar nuevamente...Y(si)/ N(para salir): ");
                answer = Console.ReadLine();
                answer.ToLower().Trim();
                while (answer != "n" && answer != "y")
                {
                    Console.WriteLine("Y(si)/ N(para salir):");
                    answer = Console.ReadLine();
                    answer.ToLower().Trim();
                }
            } while (answer == "y");                           
        }
    }
}
