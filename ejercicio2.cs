using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = @"C:\\Users\SALA-1.UNICARIBE\\Desktop\\estructura de datos ALVARO PAREJO\\ejercicio2.csv";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Nota");
            sw.WriteLine("1,Carlos,4.2");
            sw.WriteLine("2,Maria,2.5");
            sw.WriteLine("3,Pedro,3.8");
            sw.WriteLine("4,Ana,2.9");
        }

        string[] lineas = File.ReadAllLines(ruta);

        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');

            int id = int.Parse(campos[0]);
            string nombre = campos[1];
            double nota = double.Parse(campos[2]);

            if (nota >= 3.0)
            {
                Console.WriteLine(
                    "ID: " + id +
                    " - Nombre: " + nombre +
                    " - Nota: " + nota
                );
            }
        }
    }
}

