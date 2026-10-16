using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\SALA-1.UNICARIBE\\Desktop\\estructura de datos ALVARO PAREJO\\ejercicio1.csv";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Laptop:5");
            sw.WriteLine("Mouse:12");
            sw.WriteLine("Teclado:8");
            sw.WriteLine("Monitor:3");
        }

        string[] lineas = File.ReadAllLines(ruta);

        int total = 0;
        int mayor = 0;
        string producto = "";

        for (int i = 0; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(':');
            int cantidad = int.Parse(campos[1]);

            total = total + cantidad;

            if (cantidad > mayor)
            {
                mayor = cantidad;
                producto = campos[0];
            }
        }

        Console.WriteLine("Total vendido: " + total);
        Console.WriteLine("Producto más vendido: " + producto);
        Console.WriteLine("Cantidad vendida: " + mayor);
    }
}

