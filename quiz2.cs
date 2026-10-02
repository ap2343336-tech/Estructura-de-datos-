using System;

class Program
{
    static void Main()
    {
        const int CANTIDAD_ESTUDIANTES = 22;

        string[] nombres =
        {
            "Carlos",
            "Maria",
            "Juan",
            "Laura",
            "Andres",
            "Valentina",
            "Sebastian",
            "Camila",
            "Daniel",
            "Natalia",
            "Santiago",
            "Isabella",
            "Mateo",
            "Sofia",
            "Alejandro",
            "Mariana",
            "Felipe",
            "Gabriela",
            "Nicolas",
            "Paula",
            "David",
            "Juliana"
        };

        double[] calificaciones = new double[CANTIDAD_ESTUDIANTES];

        for (int i = 0; i < CANTIDAD_ESTUDIANTES; i++)
        {
            for (; ; )
            {
                Console.Write("Ingrese la calificacion de " + nombres[i] + " (0.0 - 5.0): ");
                string entrada = Console.ReadLine();

                double nota;

                if (double.TryParse(entrada, out nota) && nota >= 0.0 && nota <= 5.0)
                {
                    calificaciones[i] = nota;
                    break;
                }

                Console.WriteLine("Error: ingrese una nota valida entre 0.0 y 5.0.");
            }
        }

        double suma = 0;
        double notaMayor = calificaciones[0];
        double notaMenor = calificaciones[0];
        int aprobados = 0;
        int reprobados = 0;

        for (int i = 0; i < CANTIDAD_ESTUDIANTES; i++)
        {
            suma += calificaciones[i];

            if (calificaciones[i] > notaMayor)
            {
                notaMayor = calificaciones[i];
            }

            if (calificaciones[i] < notaMenor)
            {
                notaMenor = calificaciones[i];
            }

            if (calificaciones[i] >= 3.0)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }

        double promedio = suma / CANTIDAD_ESTUDIANTES;

        Console.WriteLine();
        Console.WriteLine("======================================");
        Console.WriteLine("       REPORTE DE CALIFICACIONES");
        Console.WriteLine("======================================");

        for (int i = 0; i < CANTIDAD_ESTUDIANTES; i++)
        {
            Console.WriteLine((i + 1) + ". " + nombres[i] + " - Nota: " + calificaciones[i].ToString("F2"));
        }

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Promedio: " + promedio.ToString("F2"));
        Console.WriteLine("Nota mayor: " + notaMayor.ToString("F2"));
        Console.WriteLine("Nota menor: " + notaMenor.ToString("F2"));
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
        Console.WriteLine("======================================");

        Console.ReadKey();
    }
}

