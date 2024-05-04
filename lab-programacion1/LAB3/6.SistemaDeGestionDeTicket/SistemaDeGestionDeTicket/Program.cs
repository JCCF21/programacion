/*
6.Implementa un sistema simple de gestión de tickets de soporte. Los usuarios pueden agregar
tickets a una cola y el sistema debe mostrar el ticket más antiguo cuando un agente de soporte está disponible para manejarlo.
*/

using System;
using System.Collections.Generic;

public class Ticket
{
    public int Id { get; set; }
    public string Problema { get; set; }
    
}

public class SistemaSoporte
{
    private Queue<Ticket> tickets;
    private int contadorId;

    public SistemaSoporte()
    {
        tickets = new Queue<Ticket>();
        contadorId = 1;
    }

    public void CrearTicket(string problema)
    {

        Ticket ticket = new Ticket
        {
            Id = contadorId++,
            Problema = problema,
            
        };

        tickets.Enqueue(ticket);
        Console.WriteLine($"Ticket {ticket.Id} con el problema '{problema}' ha sido agregado a la cola.");
    }

    public void ManejarTicket()
    {
       
        if (tickets.Count > 0)
        {
            Ticket ticket = tickets.Dequeue();
            Console.WriteLine($"Manejando el ticket {ticket.Id} con el problema: {ticket.Problema}");
        }
        else
        {
            Console.WriteLine("No hay tickets en la cola.");
        }
    }

    public void MostrarTickets()
    {
       
        if (tickets.Count > 0)
        {
            Console.WriteLine("Tickets sin trabajar:");
            foreach (var ticket in tickets)
            {
                Console.WriteLine($"Ticket {ticket.Id}: {ticket.Problema}");
            }

        }
        else
        {
            Console.WriteLine("No hay tickets en la cola.");
        }
        
    }
}

class Programa
{
    static void Main()
    {
        SistemaSoporte sistemaSoporte = new SistemaSoporte();

        while (true)
        {
            Console.WriteLine("SISTEMA DE GESTION DE TICKETS");
            Console.WriteLine("==============================");
            Console.WriteLine("\n1. Crear ticket");
            Console.WriteLine("2. Trabajar ticket");
            Console.WriteLine("3. Mostrar tickets sin trabajar");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Por favor, introduce tu problema:");
                    string problema = Console.ReadLine();
                    sistemaSoporte.CrearTicket(problema);
                    break;
                case "2":
                    Console.Clear();
                    sistemaSoporte.ManejarTicket();
                    break;
                case "3":
                    Console.Clear();
                    sistemaSoporte.MostrarTickets();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opcion no valida. Por favor, elige una opcion del menu.");
                    break;
            }
        }
    }
}
