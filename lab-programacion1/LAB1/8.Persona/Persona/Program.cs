using System;

namespace Persona
{
    class Program
    {
        static void Main()
        {
            Persona persona = new Persona();

            Console.Write("Por favor, ingresa tu nombre: ");
            persona.Nombre = Console.ReadLine();

            Console.Write("Por favor, ingresa tus apellidos: ");
            persona.Apellidos = Console.ReadLine();

            Console.Write("Por favor, ingresa tu edad: ");
            persona.Edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Por favor, ingresa tu altura en metros: ");
            persona.Altura = Convert.ToDouble(Console.ReadLine());

            persona.MostrarInformacion();
        }
        class Persona
        {
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public int Edad { get; set; }
            public double Altura { get; set; }

            public void MostrarInformacion()
            {
                Console.WriteLine("\nInformación ingresada:");
                Console.WriteLine("Nombre: " + Nombre);
                Console.WriteLine("Apellidos: " + Apellidos);
                Console.WriteLine("Edad: " + Edad);
                Console.WriteLine("Altura: " + Altura + " m");
            }
        }
    }
}
