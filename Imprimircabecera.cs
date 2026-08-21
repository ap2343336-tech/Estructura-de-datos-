using System;

namespace proyecto_2
{
    internal class Program
    {
        static void ImprimirCabecera(string nombremateria, int grupo, string full_name, string programa, int semestre, string profesor, string jornada)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("        Universidad del Caribe");
            Console.WriteLine($"     Asignatura: {nombremateria}");
            Console.WriteLine($"     Grupo: {grupo}");
            Console.WriteLine($"     Nombre: {full_name}");
            Console.WriteLine($"     Programa: {programa}");
            Console.WriteLine($"     Semestre: {semestre}");
            Console.WriteLine($"     Profesor: {profesor}");
            Console.WriteLine($"     Jornada: {jornada}");
            Console.WriteLine("============================================");
        }

        static void Main(string[] args)
        {
            ImprimirCabecera("Fundamentos de Programación", 1, "Álvaro Parejo", "Ingeniería Informática", 2, "Neider Hernández", "Tarde");
        }
    }
}
