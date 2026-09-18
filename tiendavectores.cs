using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {


        double[] ventas = { 200.000, 302.300, 400.000, 300.233, 700.410,
                            740.432, 100.233, 99.423, 823.231, 902.211 };

        double total = 0;
        double mayorventa = ventas[0];
        double menorventa = ventas[0];

        int diamayorventa = 0;
        int diamenorventa = 0;

        for (int i = 0; i < ventas.Length; i++)
        {
            total += ventas[i];

            if (ventas[i] > mayorventa)
            {
                mayorventa = ventas[i];
                diamayorventa = i;
            }

            if (ventas[i] < menorventa)
            {
                menorventa = ventas[i];
                diamenorventa = i;
            }
        }

     
        double promedio = total / ventas.Length;

  
        int diassobrepromedio = 0;

        for (int i = 0; i < ventas.Length; i++)
        {
            if (ventas[i] > promedio)
            {
                diassobrepromedio++;
            }
        }
        Console.WriteLine("============== REPORTE DE VENTAS =============");
        Console.WriteLine();

        Console.WriteLine($"Total vendido: ${total:F3}");
        Console.WriteLine($"Promedio diario: ${promedio:F3}");
        Console.WriteLine();

        Console.WriteLine($"Mayor venta: ${mayorventa:F3} - Día {diamayorventa + 1}");
        Console.WriteLine($"Menor venta: ${menorventa:F3} - Día {diamenorventa + 1}");

        Console.WriteLine();
        Console.WriteLine($"Días que superaron el promedio: {diassobrepromedio}");

        Console.WriteLine();
        Console.WriteLine("Ventas por día");

        for (int i = 0; i < ventas.Length; i++)
        {
            Console.WriteLine($"Día {i + 1}: ${ventas[i]:F3}");
        }
    }
}
