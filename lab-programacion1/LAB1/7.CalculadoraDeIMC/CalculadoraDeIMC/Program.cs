using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Indice de Masa Corporal (IMC)");
            Console.Write("Ingresa tu peso en kilogramos: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa tu estatura en metros: ");
            double estatura = Convert.ToDouble(Console.ReadLine());

           
            IMCCalculator calculadora = new IMCCalculator(peso, estatura);

           
            double imc = calculadora.CalcularIMC();

                       Console.WriteLine($"Tu IMC es: {imc:F2}");

            Console.ReadLine();
        }
    }
    class IMCCalculator
    {
        private double Peso { get; }
        private double Estatura { get; }

        public IMCCalculator(double peso, double estatura)
        {
            Peso = peso;
            Estatura = estatura;
        }

        public double CalcularIMC()
        {
            return Peso / (Estatura * Estatura);
        }
    }
}
