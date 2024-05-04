/*
2.Crea un programa que solicite al usuario ingresar 5 números enteros y los almacene
en un array. Luego, muestra la suma de todos los números.
*/

int[] numeros = new int[5];
int suma = 0;
Console.WriteLine("Y si lo Sumo Todos");
Console.WriteLine("===================");

for (int i = 0; i < 5; i++)
{
    while (true)
    {
        Console.WriteLine($"Por favor, introduce el número {i + 1}:");
        string entrada = Console.ReadLine();

        bool esNumeroValido = int.TryParse(entrada, out int numero);

        if (esNumeroValido)
        {
            numeros[i] = numero;
            suma += numero;
            break;
        }
        else
        {
            Console.WriteLine("Lo siento, eso no es un número válido. Por favor, intenta de nuevo.");
        }
    }
}

Console.WriteLine($"La suma de todos los números es: {suma}");
