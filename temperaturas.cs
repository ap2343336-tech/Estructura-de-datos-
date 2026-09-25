using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[5]; //declarando e iniciando,

            //lectura/escritura de nuestro vector

            Console.WriteLine("------ ingreso de temperaturas -----");

            for (int i = 0; i < temperaturas.Length; i++)
            {

                Console.Write($"ingrese la temperatura del dia {i + 1}:");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            }

            double suma = 0;
            double MaxT = temperaturas[0];
            double MinT = temperaturas[0];


            foreach (double tem in temperaturas) {

                suma += tem;

                if (tem > MaxT) MaxT = tem;
                if (tem < MinT) MinT = tem;
         
            
            }

            double promedio = suma / temperaturas.Length;

            //salida de informacion

            Console.WriteLine("\n ----Reporte ----");
            Console.WriteLine($"temperaturas registradas: {string.Join(", ", temperaturas)}");
            Console.WriteLine($"temperatura promedio: {promedio:f2}°");
            Console.WriteLine($"temperatura maxima: {MaxT}°");2

                 Console.WriteLine($"temperatura minima: {MinT}°");
            
        }
    }
}
