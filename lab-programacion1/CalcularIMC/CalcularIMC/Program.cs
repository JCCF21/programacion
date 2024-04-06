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

            if (imc < 18.5)
            {
                Console.WriteLine("Esta bajo Peso...Come Algo!");
            }
            else if(imc >= 18.5 &&  imc < 24.0)
            {
                Console.WriteLine("Felicitaciones Estas en forma, tu peso es Normal ");
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                Console.WriteLine("Creo que es Hora de Hacer Ejercicios...Tienes Sobre Peso");
            }
            else if (imc >= 30.0 && imc < 35.0)
            {
                Console.WriteLine("Te Gusta mucho el Pica Pollo...Tienes Obecidad Tipo I ");
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                Console.WriteLine("Los Vegetales Tambien son comida...Tienes Obecidad Tipo II");
            }
            else 
            {
                Console.WriteLine("Dios ve al medico...Tienes Obecidad Y Dibetes tipo II");
            }


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
