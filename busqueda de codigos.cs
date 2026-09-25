using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ejercicio 2. busqueda y modificaciones de informacion en vectores
            // operacione: busqueda lineal, verificacion de exitencia y actualizacion de un elemento en un array.

            int[] codigos = new int[20];

            for (int i = 0; i < codigos.Length; i++)
            {
                Console.Write($"Ingrese el codigo {i + 1}: ");
                codigos[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\ncodigos actuales:");

            for (int i = 0; i < codigos.Length; i++)
            {
                Console.WriteLine(codigos[i]);
            }

            Console.WriteLine("ingrese el codigo que desea actualizar: ");
            int busqueda = Convert.ToInt32(Console.ReadLine());

            int indiceEncontrado = -1;

            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == busqueda)
                {
                    indiceEncontrado = i;
                    break;
                }
            }

            if (indiceEncontrado != -1)
            {
                Console.Write("ingrese el nuevo codigo: ");
                codigos[indiceEncontrado] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nVector Actualizado:");

                for (int i = 0; i < codigos.Length; i++)
                {
                    Console.WriteLine(codigos[i]);
                }
            }
            else
            {
                Console.WriteLine("\nError: El codigo ingresado no existe en la BDD.");
            }

            Console.WriteLine($"\n valor del indice: {indiceEncontrado}");
        }
    }
}