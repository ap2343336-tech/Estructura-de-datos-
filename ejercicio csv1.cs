using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudiamtes
class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\SALA-1.UNICARIBE\\Desktop\\estructura de datos ALVARO PAREJO\\EstudiantesInformacion.csv";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Nombre,año que nacio,trabajo");
            sw.WriteLine("alvaro,2007,desempleado");
            sw.WriteLine("mario,2009,Informatica");
        }
        Console.WriteLine("archivo creado exitosamente.");
    }
}