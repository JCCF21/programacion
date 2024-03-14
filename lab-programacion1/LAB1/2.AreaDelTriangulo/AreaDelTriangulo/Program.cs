//Calcular Area de un tiangulo
using System;

namespace AreaDelTriangulo
{
    class Program 
    {
       static void Main(string[] args) 
       {
            
            string? entrada;
            double altura = 0.0;
            double baseTriangulo = 0.0;
            double area;

            Console.WriteLine("\t\tCalcular Area de un Triangulo.");
            Console.WriteLine("\t\t******************************\n");
            Console.WriteLine("Ingrese datos solicitados:");
            
            Console.Write("Altura: ");
            entrada = Console.ReadLine();
            altura = ValidarEntrada(entrada);            
            
            Console.Write("Base: ");
            entrada = Console.ReadLine();
            baseTriangulo = ValidarEntrada(entrada);
            
            Triangulo triangulo = new Triangulo();
            area = triangulo.AreaTriangulo(altura, baseTriangulo);
            Console.WriteLine($"El Area del Triangulo de Altura: {altura} Y base:{baseTriangulo} es: {area}");            
       
        }

       static double ValidarEntrada(string? entrada)
       {
            double num;
            while (!double.TryParse(entrada, out num))
            {
                if (!double.TryParse(entrada, out num))
                {
                    Console.WriteLine("Entrada Invalida.");
                    Console.WriteLine("Vuelva a Tratar....");
                    entrada = Console.ReadLine();
                }
                
            };
           
            return num;
       }
    }
    class Triangulo
    {
        private double _altura;
        private double _baseTriangulo;

        public Triangulo() { }
        
           
        public double Altura { get; set;}
        public double BaseTriangulo { get; set;}

        public double AreaTriangulo(double a, double b)
        {
            return ( b * a) / 2;
        }
    }    
}