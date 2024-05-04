//using System.Runtime.CompilerServices;
using System.Collections.Generic;
class program
{
    public static void Main()
    {
        //       Persona persona1 = new Persona("Juan Perez", 25, "123456789");
        //        persona1.saludar();

        //        if (persona1.esMayorDeEdad())
        //        { 
        //            Console.WriteLine(persona1.nombre + " es mayor de edad.");
        //        }
        //        else 
        //        {
        //            Console.WriteLine(persona1.nombre + " es menor de edad.");
        //        }

        //Punto punto1 = new Punto(3,4);
        //Console.WriteLine("Coordenada X:" + punto1.x);
        //Console.WriteLine("Coordenada Y:" + punto1.y);

        //double distancia = punto1.distanciaAlOrigen();
        //Console.WriteLine("Distancia al origen: " + distancia);
        //int[] edades;
        //edades = new int[5];

        //edades[0] = 25;
        //int segundaEdad = edades[1];

        //string[] nombres = { "Juan", "Maria", "Pedro" };

        //for (int i = 0; i < edades.Length; i++)
        //{
        //    Console.WriteLine($"Edad {i + 1}: {edades[i]}");
        //}
        //foreach(int edad in edades) 
        //{
        //    Console.WriteLine(edad);
       // //}
       //// List<string> frutas  = new List<string>() { "Manzana", "Pera","Uva", "Naranja"};
       // frutas.Add("Banana");
       // frutas.Contains(frutas[0]);
       // frutas.Sort();
        

        //List<int> numeros = new List<int>() { 1, 5, 3, 4, 2};


        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine( fruta);
        //}

        Dictionary<string, int> edades = new Dictionary<string, int>();
        edades.Add("Juan", 30);
        edades.Add("Maria", 25);

        //int edadJuan = edades["Juan"];
        //Console.WriteLine(edadJuan);

        //bool existeMaria = edades.ContainsKey("Maria");
        //Console.WriteLine(existeMaria);

        HashSet<string> frutas = new HashSet<string>();
        frutas.Add("Mazana");
        frutas.Add("Pera");
        Console.WriteLine(frutas.Contains("Uva"));
    }
}

//class Persona
//{
//    public string nombre;
//    public int edad;
//    public string cedula;

//    public Persona(string nombre, int edad, string cedula)
//    {
//        this.nombre = nombre;
//        this.edad = edad;
//        this.cedula = cedula;
//    }

//    public void saludar()
//    {
//        Console.WriteLine($"Hola Me llamo {nombre} y tengo {edad} years old");
//    }

//    public bool esMayorDeEdad()
//    { return edad >= 18; }
//}

//struct Punto
//{
//    public int x;
//    public int y;

//    public Punto(int x, int y)
//    {
//        this.x = x;
//        this.y = y;
//    }
    
//    public double distanciaAlOrigen()
//    {
//        return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y,2));
//    }
//}

//Arrays 

