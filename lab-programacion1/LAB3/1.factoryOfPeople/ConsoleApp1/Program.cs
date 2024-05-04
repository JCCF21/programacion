/*
 * 1.Define una clase llamada Persona con propiedades como nombre, edad y género. Luego,
    crea instancias de esta clase y muestra la información de cada persona.
 */
namespace LAB3
{
    class Program
    {
        public static void Main(string[] args) 
        {

            List<Persona> personas = new List<Persona>();
            string? continuar = "";

            do
            {
                Console.WriteLine("\tGod's Factory");
                Console.WriteLine("=====================================");
                Console.WriteLine("Introduce el nombre de la persona:");
                string? nombre = Console.ReadLine();

                Console.WriteLine("Introduce la edad de la persona:");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduce el género de la persona:");
                string? genero = Console.ReadLine();

                personas.Add(new Persona(nombre, edad, genero));

                Console.WriteLine("¿Deseas agregar otra persona? (s/n)");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");

            foreach (Persona persona in personas)
            {
                Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}, Género: {persona.Genero}");
            }
            Console.ReadKey();
        }
    }
    public class Persona
    {
        private string nombre;
        private int edad;
        private string genero;

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }

        public Persona(string nombre, int edad, string genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
        }
    }

}
