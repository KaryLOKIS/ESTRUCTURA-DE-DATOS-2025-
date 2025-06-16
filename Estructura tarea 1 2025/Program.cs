
using System;

class Estudiante
{
    public int Id;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos = new string[3]; // Array de teléfonos

    public void IngresarDatos()
    {
        Console.Write("Ingrese ID: ");
        Id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese nombres: ");
        Nombres = Console.ReadLine();

        Console.Write("Ingrese apellidos: ");
        Apellidos = Console.ReadLine();

        Console.Write("Ingrese dirección: ");
        Direccion = Console.ReadLine();

        Console.WriteLine("Ingrese los 3 números de teléfono:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.Write($"Teléfono {i + 1}: ");
            Telefonos[i] = Console.ReadLine();
        }
    }

    public void MostrarDatos()
    {
        Console.WriteLine("\n--- Datos del Estudiante ---");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($" - {Telefonos[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante();
        estudiante.IngresarDatos();
        estudiante.MostrarDatos();
    }
}
