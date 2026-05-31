using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    internal class Program
    {
        static double Calcular_Porcentaje(int presentes, int matriculados)
        {
            return (double)presentes * 100 / matriculados;
        }
        static void Main(string[] args)
        {
            double suma_Porcentajes = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Sesión {i}");

                Console.Write("Estudiantes que asistieron: ");
                int presentes = int.Parse(Console.ReadLine());

                Console.Write("Estudiantes matriculados: ");
                int matriculados = int.Parse(Console.ReadLine());

                double porcentaje = Calcular_Porcentaje(presentes, matriculados);
                suma_Porcentajes += porcentaje;
            }
            double promedio = suma_Porcentajes / 4;

            Console.WriteLine($"El promedio es: {promedio:F2}%");

            if (promedio >= 75)
            {
                Console.WriteLine("Participación adecuada.");
            }
            else
            {
                Console.WriteLine("Reforzar asistencia.");
            }
        }
    }
}
