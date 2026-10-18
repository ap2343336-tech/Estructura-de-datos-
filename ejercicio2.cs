using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\SALA-1.UNICARIBE\\Desktop\\estructura de datos ALVARO PAREJO\\inventario.csv";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Cantidad,Precio");
            sw.WriteLine("1,Laptop,5,2500000");
            sw.WriteLine("2,Mouse,15,35000");
            sw.WriteLine("3,Teclado,8,80000");
            sw.WriteLine("4,Monitor,20,750000");
        }

        string[] lineas = File.ReadAllLines(ruta);

        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');

            int cantidad = int.Parse(campos[2]);

            if (cantidad < 10)
            {
                Console.WriteLine("Producto: " + campos[1] +
                                  " - Cantidad: " + cantidad +
                                  " - Precio: $" + campos[3]);
            }
        }
    }
}


