﻿namespace Arrays;
public class Persona(string nombre, int edad)
{
    public string Nombre { get; set; } = nombre;
    public int Edad { get; set; } = edad;

    public override string ToString()
    {
        return $"{Nombre} ({Edad})";
    }
}