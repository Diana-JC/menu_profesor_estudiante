using System;

    public class Persona
{
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public string? Correo { get; set; }

    public virtual void ImprimirDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}\nDirección: {Direccion}\nCorreo: {Correo}");
    }
}


public class Estudiante : Persona
{
    public string? Carrera { get; set; }

    public override void ImprimirDatos()
    {
        base.ImprimirDatos();
        Console.WriteLine($"Carrera: {Carrera}");
    }
}

public class Profesor : Persona
{
    public string? Asignatura { get; set; }

    public override void ImprimirDatos()
    {
        base.ImprimirDatos();
        Console.WriteLine($"Asignatura: {Asignatura}");
    }
}


class Program
{
    static void Main(string[] args)
    {

        Estudiante estudiante = new Estudiante();
        Profesor profesor = new Profesor();


        Console.WriteLine("Introduce los datos del Estudiante:");
        estudiante.Nombre = Console.ReadLine();
        estudiante.Direccion = Console.ReadLine();
        estudiante.Correo = Console.ReadLine();
        estudiante.Carrera = Console.ReadLine();

        Console.WriteLine("\nDatos del estudiante:");
        estudiante.ImprimirDatos();
        Console.WriteLine("");

        Console.WriteLine("Introduce los datos del Profesor:");
        profesor.Nombre = Console.ReadLine();
        profesor.Direccion = Console.ReadLine();
        profesor.Correo = Console.ReadLine();
        profesor.Asignatura = Console.ReadLine();

        Console.WriteLine("\nDatos del profesor:");
        profesor.ImprimirDatos();
    }
}
