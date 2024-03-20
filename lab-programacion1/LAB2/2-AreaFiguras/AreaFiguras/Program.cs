//2.Pedir
//al usuario el tipo de figura geométrica (triángulo, cuadrado, círculo) y
//calcular su área utilizando switch.

using System;
using System.Formats.Asn1;

namespace Lab2
{
    class Program
    {
        public static void Main(string[] args)
        {

            string? opcion;
            do
            {

                opcion = Menu();
                
              
                switch (opcion)
                {
                    case "1":
                        do
                        {
                            Console.Clear();
                            double lado;
                            Console.WriteLine("Calculadora del Area de un Cuadrado");
                            Console.WriteLine("=======================================");

                            Console.WriteLine("Ingrese la medida de los lados: ");
                            Console.Write("Lado: ");
                            lado = ValidEntry();
                            Cuadrado cuadrado = new(lado);
                            Console.WriteLine($"El area del Cuadrado de Lado {lado}: es {cuadrado.Area().ToString("#,#.##")}");

                            opcion = Continuar();
                        } while (opcion == "s" && opcion != "n");
                        break;
                    case "2":
                        do
                        {
                            Console.Clear();
                            double baseTriangulo, altura;
                            Console.WriteLine("Calculadora del Area de un Triangulo");
                            Console.WriteLine("=======================================");

                            Console.WriteLine("Ingrese los datos requeridos");

                            Console.Write("Base del Triandulo: ");
                            baseTriangulo = ValidEntry();

                            Console.Write("Altura del Triangulo: ");
                            altura = ValidEntry();

                            Triangulo triangulo = new Triangulo(baseTriangulo, altura);
                            Console.WriteLine($"El Area del Triangulo de Base: {triangulo.BaseTriangulo} y Altura: {triangulo.Altura} es: {triangulo.Area().ToString("#,#.##")}");

                            opcion = Continuar();
                        } while (opcion == "s" && opcion != "n");
                        break;
                    case "3":
                        do
                        {
                            Console.Clear();
                            double radio;
                            Console.WriteLine("Calculadora del Area de un Circulo");
                            Console.WriteLine("=======================================");

                            Console.WriteLine("Ingrese la medida del Radio: ");
                            Console.Write("Radio: ");
                            radio = ValidEntry();
                            Circulo circulo = new(radio);
                            Console.WriteLine($"El area del Circulo de Radio: {circulo.Radio} es {circulo.Area().ToString("#,#.##")}");

                            opcion = Continuar();
                        } while (opcion == "s" && opcion != "n");
                        break;
                    case "4":

                        break;
                    default:
                        Console.WriteLine($"{Menu()} No es una opcion valida");
                        break;
                     
                }
            } while ( opcion != "4");

        }
        public static string Menu()
        {
            Console.Clear();
            string? opcion;
            Console.WriteLine("\t\tCalculadora de Area");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Por favor, Elija la figura del area a calcular");
            Console.WriteLine(" 1 - Cuadrado | 2 - Triangulo| 3 - Circulo| 4 - Salir  ");
            Console.Write("opcion: ");
            opcion = Console.ReadLine();

            return opcion;

        }
        public static string Continuar()
        {
            string? opcion;
            Console.WriteLine("\nDesea Continuar? S - Si  | N - No : ");
            opcion = Console.ReadLine();

            if (opcion != null)
            {
                opcion.ToLower().Trim();

                while (opcion != "s" && opcion != "n")
                {
                    Console.Write("Opcion Invalidad...Trate Nuevamente:");
                    opcion = Console.ReadLine();
                }
            }
            return opcion;

        }
        public static double ValidEntry()
        {
            bool validEntry = false;
            double validNum  = 0.0;
            do
            {
                try
                {
                    validNum = Convert.ToDouble(Console.ReadLine());

                    validEntry = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Debe de Introducir un Numero valido...");
                    
                }
            } while (!validEntry);
            return validNum;
        }
    }

    class Cuadrado(double lado) : Figura
    {
        public double Lado { get; set; } = lado;
        //formula lado * lado
        public override double Area() => lado * lado;
    }

    class Triangulo(double baseTriangulo, double altura) : Figura
    {
        public double BaseTriangulo { get; } = baseTriangulo;
        public double Altura { get; } = altura;
        // Formula base * altura / 2
        public override double Area() => (BaseTriangulo * Altura) / 2;

    }
    class Circulo(double radio) : Figura
    {
        public double Radio { get; } = radio;
        //formula pi * r ^2
        public override double Area() => Math.PI * (radio * radio);

    }
    public abstract class Figura()
    {
        public abstract double Area();

    }
}

