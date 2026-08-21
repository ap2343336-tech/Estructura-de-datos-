using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
         
            static double CalcularAreaCirculo(double radio)
        {
            const double PI = 3.141592;
            // ahora voy a realizar el calculo con la formula
            double area = PI * Math.Pow(radio, 2);
            return area;


        }

        
        static void Main(string[] args)
        {
            Console.Write("ingrese el radio del circulo: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double result = CalcularAreaCirculo(r);
            Console.WriteLine($"el area es {result:f2}");
        }
       
    }
}
