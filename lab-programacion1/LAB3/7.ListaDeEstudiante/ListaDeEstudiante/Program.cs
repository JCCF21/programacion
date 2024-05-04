/*
 7. Crea una clase llamada Curso que tenga una lista de estudiantes. Implementa métodos
    para agregar estudiantes al curso, eliminar estudiantes y mostrar todos los
    estudiantes inscritos. 
*/

using System;
using System.Collections.Generic;

public class Estudiante
{
    public string Nombre { get; set; }
    public int Matricula { get; set; }
}

public class Curso
{
    private List<Estudiante> estudiantes;
    private int contadorMatricula;

    public Curso()
    {
        estudiantes = new List<Estudiante>();
        contadorMatricula = 1;
    }

    public void CrearEstudiante(string nombre)
    {
        Estudiante estudiante = new Estudiante
        {
            Nombre = nombre,
            Matricula = contadorMatricula++
        };

        estudiantes.Add(estudiante);
        Console.WriteLine($"El estudiante {estudiante.Nombre} con matrícula {estudiante.Matricula} ha sido agregado al curso.");
    }

    public void EliminarEstudiante(int matricula)
    {
        var estudiante = estudiantes.Find(e => e.Matricula == matricula);
        if (estudiante != null)
        {
            estudiantes.Remove(estudiante);
            Console.WriteLine($"El estudiante con matrícula {matricula} ha sido eliminado del curso.");
        }
        else
        {
            Console.WriteLine("El estudiante con esa matrícula no está inscrito en el curso.");
        }
    }

    public void MostrarEstudiantes()
    {
        Console.WriteLine("Estudiantes inscritos:");
        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Matrícula: {estudiante.Matricula}");
        }
    }
}

class Programa
{
    static void Main()
    {
        Curso curso = new Curso();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("LISTADO DE ESTUDIANTES");
            Console.WriteLine("=======================");
            Console.WriteLine("\n1. Agregar estudiante");
            Console.WriteLine("2. Eliminar estudiante");
            Console.WriteLine("3. Mostrar estudiantes");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Por favor, introduce el nombre del estudiante:");
                    string nombre = Console.ReadLine();
                    curso.CrearEstudiante(nombre);
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Por favor, introduce la matrícula del estudiante a eliminar:");
                    int matricula = int.Parse(Console.ReadLine());
                    curso.EliminarEstudiante(matricula);
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    curso.MostrarEstudiantes();
                    Console.ReadKey();
                    break;
                case "4":
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Opción no válida. Por favor, elige una opción del menú.");
                    break;
            }
        }
    }
}
