using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_02
{
    internal class Program
    {
        static int AforoMax = 30;

        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int estudiantes = int.Parse(Console.ReadLine());
            //Función con return
            bool permitido = ValidarAforo(estudiantes);
            //Metodo void
            mostrarResultados(estudiantes, permitido);

        }

        static bool ValidarAforo(int estudiantes)
        {
            return AforoMax >= estudiantes;
        }

        static void mostrarResultados(int estudiantes, bool permitido)
        {
            Console.WriteLine($"Estudiantes registrados: {estudiantes}");
            Console.WriteLine($"Aforo máximo permitido: {AforoMax}");

            if (permitido)
            {
                Console.WriteLine("Ingreso permitido.");
            }
            else
            {
                Console.WriteLine("Aforo excedido.");
            }
        }
    }
}
