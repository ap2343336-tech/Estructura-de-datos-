using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\SALA-1.UNICARIBE\\Desktop\\estructura de datos ALVARO PAREJO\\Informacionpersonas.csv";

        
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Nombre,Apellido,Edad");
            sw.WriteLine("Carlos,Pérez,25");
            sw.WriteLine("María,Gómez,30");
            sw.WriteLine("Andrés,Rodríguez,22");
            sw.WriteLine("Lucía,Martínez,28");
        }

        
        string[] lineas = File.ReadAllLines(ruta);

        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');

            string nombre = campos[0];
            string apellido = campos[1];
            int edad = int.Parse(campos[2]);

            Console.WriteLine("Nombre: " + nombre +
                              " - Apellido: " + apellido +
                              " - Edad: " + edad);
        }
    }
}
