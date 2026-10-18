using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\SALA-1.UNICARIBE\\Desktop\\estructura de datos ALVARO PAREJO\\personas.csv";

        if (File.Exists(ruta))
        {
            string[] lineas = File.ReadAllLines(ruta);
            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(',');
                Console.WriteLine($"Nombre: {campos[0]}, Apellido: {campos[1]}, Edad: {campos[2]}");
            }
        }

        using (StreamWriter sw = new StreamWriter("C:\\Users\\SALA-1.UNICARIBE\\Desktop\\estructura de datos ALVARO PAREJO\\personas.csv", append: true))
        {
            sw.WriteLine("Carlos,Gómez,25");
        }
    }
}
