//8.Pedir al usuario la hora actual y usar if-elseif para
//mostrar un mensaje de saludo adecuado (buenos días, buenas tardes, buenas
//noches).

using System;

namespace LAB2
{
    class Program
    {
        public static void Main()
        {
            bool exito = false;
            do
            {
                Console.Write("Por favor, ingresa la hora actual (formato 24 horas): ");
                try
                { 
                    string? entrada = Console.ReadLine();
                    int.TryParse(entrada, out int hora);
                    
                    double horaCompleta = (double)hora / 100; 
                    

                    entrada = horaCompleta.ToString("F2").Replace('.', ':');
                    string[] horaArry = entrada.Split(':');

                    entrada = horaArry[0];

                    int.TryParse(entrada, out hora);
                    entrada = horaArry[1];
                    int.TryParse(entrada, out int minutos);

                    exito = true;

                    if (exito)
                    {
                        if (hora >= 0 && hora < 12 && minutos >= 0 && minutos < 60)
                        {
                            Console.WriteLine($"Buenos dias! Son las: {horaCompleta.ToString("F2").Replace('.', ':')} AM.");
                        }
                        else if (hora >= 12 && hora < 18 && minutos >= 0 && minutos < 60)
                        {
                            Console.WriteLine($"Buenas tardes! Son las: {horaCompleta.ToString("F2").Replace('.', ':')} PM.");
                        }
                        else if (hora >= 18 && hora <= 23 && minutos >= 0 && minutos < 60)
                        {
                            Console.WriteLine($"Buenas noches!Son las: {horaCompleta.ToString("F2").Replace('.', ':')} PM.");
                        }
                        else
                        {

                            Console.WriteLine("La hora ingresada no es valida. Por favor, ingresa una hora entre 0 y 23 Y minutos entre 0 59: ");
                            exito = false;

                        }
                    }

                }
                catch
                {
                    Console.Write("La hora ingresada no es valida. Por favor, ingresa una hora entre 0 y 23 Y minutos entre 0 59: ");
                }

            } while (!exito);


        }
    }

}