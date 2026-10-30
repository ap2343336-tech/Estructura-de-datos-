
using System;
using System.Collections.Generic;
using System.IO;

//Registro de incidencias de soporte tecnico utilizando archivos (.txt)
//1. Guardar en una lista de incidencias atendidas en un archivo de texto (incidencidencias,txt)
//2. leer el archivo
//3. generar un reporte que cuenta cuantas incidencias hay por prioridad (alta, media, baja)
//la estructura del archivo es: ID, NOMBRE, DESCRIPCION, PRIORIDAD.

// ejemplo: "01";"Lamine yamal";"daño del pc"; "Alta"
namespace RegistrosInciedncia
{
    internal class Program
    {
        static string pathARCHIVO = "incidencias.txt";

        static void GuardarIncidencias(List<string[]> incidencias)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathARCHIVO, false))
                {
                    foreach (string[] incidencia in incidencias)
                    {
                        sw.WriteLine(string.Join(";", incidencia));
                    }
                }

                Console.WriteLine("Incidencias guardadas correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir el archivo: {ex.Message}");
            }
        }

        static List<string[]> LeerIncidencias()
        {
            List<string[]> incidencias = new List<string[]>();

            if (!File.Exists(pathARCHIVO))
            {
                Console.WriteLine("El archivo no existe aún.");
                return incidencias;
            }

            try
            {
                string linea;

                using (StreamReader sr = new StreamReader(pathARCHIVO))
                {
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(linea))
                        {
                            string[] campos = linea.Split(';');

                            if (campos.Length >= 4)
                            {
                                incidencias.Add(campos);
                            }
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error al leer el archivo: {error.Message}");
            }

            return incidencias;
        }

        static void GenerarReporte(List<string[]> incidencias)
        {
            if (incidencias.Count == 0)
            {
                Console.WriteLine("No hay incidencias para reportar.");
                return;
            }

            Dictionary<string, int> conteoPorPrioridad = new Dictionary<string, int>();

            foreach (string[] inc in incidencias)
            {
                if (inc.Length < 4) continue;

                string prioridad = inc[3].Trim().ToLower();

                // inc [ejemplo: "01";"A";"daño del pc"; "alta"]

                if (conteoPorPrioridad.ContainsKey(prioridad))
                {
                    conteoPorPrioridad[prioridad]++;
                }
                else
                {
                    conteoPorPrioridad[prioridad] = 1;
                }
            }

            Console.WriteLine("\nREPORTE DE INCIDENCIAS");
            Console.WriteLine($"Total atendidas: {incidencias.Count}");
            Console.WriteLine("Detalle por prioridad:");

            foreach (var item in conteoPorPrioridad)
            {
                Console.WriteLine($"\nPrioridad {item.Key}: {item.Value}");
            }
        }

        static void Main(string[] args)
        {
            List<string[]> incidenciasToday = new List<string[]>
            {
                new string[] { "1", "ALVARO PEREZ", "no imprime", "alta" },
                new string[] { "2", "JUAN POLO", "olvido la contraseña", "baja" },
                new string[] { "3", "LIONEL MESSI", "wifi lento", "alta" },
                new string[] { "4", "CRISTIANO RONALDO", "pantalla azul", "media" },
                new string[] { "5", "OUSMANE DEMBELE", "pc lenta", "alta" }
            };

            Console.WriteLine("REGISTRO DE INCIDENCIAS UNICARIBE");

            GuardarIncidencias(incidenciasToday);

            Console.WriteLine("\n---- Leyendo incidencias del archivo ----");

            List<string[]> incidenciasLeidas = LeerIncidencias();

            Console.WriteLine("\nLISTADO DE INCIDENCIAS LEIDAS");
            Console.WriteLine($"{"ID",-4}{"Usuario",-20}{"Descripcion",-25}{"Prioridad",-10}");
            Console.WriteLine(new string('-', 60));

            foreach (string[] inc in incidenciasLeidas)
            {
                if (inc.Length < 4)
                    continue;

                Console.WriteLine($"{inc[0],-4}{inc[1],-20}{inc[2],-25}{inc[3],-10}");
            }

            GenerarReporte(incidenciasLeidas);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
