//1.Implementar
//una calculadora que realice las operaciones básicas (+, -, *, /) con dos
//números introducidos por el usuario. Utilizar switch para seleccionar
//la operación.
using System;
using System.Security.Cryptography;

namespace Asignacion2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? opcion;
            Calculadora calculadora = new Calculadora();
            do
            {
                
                Console.WriteLine("\t\tCaluladora");
                Console.WriteLine("**************************");

                Console.WriteLine("Elige la operacion deseada: ");
                Console.WriteLine("1- Sumar | 2- Restar | 3- Multiplicar | 4 - Dividir      |5- Salir");
                Console.Write("Opcion: ");
                opcion = Console.ReadLine();
                
               if(opcion != "5")
               { 
                Console.Write("Ingrese Primer Numero: ");
                calculadora.NumA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese Segundo Numero: ");
                calculadora.NumB = Convert.ToDouble(Console.ReadLine());
               }

                if (opcion == "4" && calculadora.NumB == 0)
                {
                    while (calculadora.NumB == 0)
                    {
                        Console.WriteLine("Error Critico....");
                        Console.WriteLine("El Segundo numbero No puede ser Cero...");
                        calculadora.NumB = Convert.ToDouble(Console.ReadLine());
                    }
                }

           
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine($"El Resulto de la Suma es: {calculadora.Suma(calculadora.NumA, calculadora.NumB).ToString("###,###,###.##")}");

                        break;
                    case "2":
                        Console.WriteLine($"El Resultado de la Resta ES: {calculadora.Restar(calculadora.NumA, calculadora.NumB)}");
                        break;

                    case "3":
                        Console.WriteLine($"El Resultado de la Multiplicacion ES: {calculadora.Multiplicar(calculadora.NumA, calculadora.NumB)}");
                        break;
                    case "4":
                        Console.WriteLine($"El Resultado de la Division ES: {calculadora.Dividir(calculadora.NumA, calculadora.NumB)}");
                        break;
                    case "5":  break;
                    default:
                        Console.WriteLine("Opcion incorrecta Vulva a tratar...");
                        break;
                }
                if(opcion != "5")
                Console.WriteLine("Desea continuar...|S - Si  | N - No");
                opcionInvalida:
                opcion = Console.ReadLine();
                if(opcion != null)
                    opcion.ToLower().Trim();
                switch(opcion)
                {
                    case"s":
                    Console.Clear(); 
                    break;
                    case "n":
                    break;
                    default: Console.WriteLine($"{opcion} es una opcion invalida");
                    goto opcionInvalida;
                    
                }
            }while((opcion !="5" ||opcion == "s") && opcion != "n");
           
        }
    }
    public class Calculadora
    {
        private double _numA, _numB;

        public double NumA { get; set; }
        public double NumB { get; set; }

        public double Suma(double a, double b)
        {
            return a + b;
        }

        public double Restar(double a, double b)
        {
            return a - b;
        }
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }
        public double Dividir(double a, double b)
        {
            return a / b;
        }
    }

}



