using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\SALA-1.UNICARIBE\\Desktop\\estructura de datos ALVARO PAREJO\\ventas.txt";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Laptop:5");
            sw.WriteLine("Mouse:15");
            sw.WriteLine("Teclado:8");
            sw.WriteLine("Monitor:20");
        }

        string[] lineas = File.ReadAllLines(ruta);

        int total = 0;
        string productoMayor = "";
        int cantidadMayor = 0;

        foreach (string linea in lineas)
        {
            string[] campos = linea.Split(':');

            string producto = campos[0];
            int cantidad = int.Parse(campos[1]);

            total += cantidad;

            if (cantidad > cantidadMayor)
            {
                cantidadMayor = cantidad;
                productoMayor = producto;
            }
        }

        Console.WriteLine("Total de unidades vendidas: " + total);
        Console.WriteLine("Producto más vendido: " + productoMayor);
        Console.WriteLine("Cantidad vendida: " + cantidadMayor);
    }
}
