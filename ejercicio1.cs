using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\SALA-1.UNICARIBE\\Desktop\\estructura de datos ALVARO PAREJO\\ejercicio1";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Cantidad,Precio,Categoria");
            sw.WriteLine("1,Laptop,5,1200,Computadores");
            sw.WriteLine("2,Mouse,15,25,Accesorios");
            sw.WriteLine("3,Teclado,8,50,Accesorios");
            sw.WriteLine("4,Monitor,20,300,Pantallas");
        }

        string[] lineas = File.ReadAllLines(ruta);

        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');
            int cantidad = int.Parse(campos[2]);

            if (cantidad < 10)
                Console.WriteLine($"{campos[1]} - Cantidad: {cantidad} - Precio: ${campos[3]} - Categoria: {campos[4]}");
        }
    }
}

