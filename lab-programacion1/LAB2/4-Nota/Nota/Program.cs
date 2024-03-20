using System;

namespace LAB2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? opcion;
            do
            {
                Console.Clear();
            
                Console.WriteLine("\t<Verificador de Calificaciones>");
                Console.WriteLine("================================================");
                Console.WriteLine("Introduzca su calificacion:");
                uint nota = ValidEntry();
                if (nota >= 70)
                {
                    Console.WriteLine("Felicitaciones has Aprobado!! ");
                }
                else
                {
                    Console.WriteLine($"Lo siento has Reprobado... {nota} No es sufiente para aprobar... ");
                }
                Console.WriteLine("\n\nDeseas Verificar Otra Calificacion...|S - Si || Cualquier tecla para salir...");

                opcion = Console.ReadLine();
                if(opcion != null)
                    opcion.ToLower().Trim();

            }while (opcion == "s");

        }
        public static uint ValidEntry()
        {
            bool entry = false;
            uint num = 0;
            do
            {
                try
                {
                    num = Convert.ToUInt16(Console.ReadLine());
                    entry = true;
                } catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\nPor favor introduzca una Calificacion Valida: ");
                }
            }while(!entry);
           return num;
        }
    }
}
