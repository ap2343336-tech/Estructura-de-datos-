using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "estudiantes.csv";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Nombre,año que nacio,trabajo");
            sw.WriteLine("alvaro,2007,desempleado");
            sw.WriteLine("mario,2009,Informatica");
        }
        Console.WriteLine("archivo creado exitosamente.");
    }
}