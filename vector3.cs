using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args){
            // ejercicio 2. busqueda y modificaciones de informacion en vectores
            // operacione: busqueda lineal, verificacion de exitencia y actualizacion de un elemento en un array.


            int[] codigos = { 211, 264, 65, 546, 545, 012, 123, 445,669};
            Console.WriteLine($"codigos actuales: {string.Join(", ", codigos)}");
            Console.WriteLine("ingrese el codigo que desea actualizar: ");
            int busqueda = Convert.ToInt32( Console.ReadLine() );

            int indiceEncontrado = -1;

            for (int i = 0; i < codigos.Length; i++) { 

                if ( codigos[i] == busqueda)
                {

                    indiceEncontrado = i;
                    break; 
                }
            
            
            
            }

            if (indiceEncontrado != -1)
            {
                Console.Write("ingrese el nuevo codigo: ");
                codigos[indiceEncontrado] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nVector Actualizado: {string.Join(", ", codigos)}");
            }
            else
            {
                Console.WriteLine("\nError: El codigo ingresado no existe en la BDD.");
            }

        }
    }
}
