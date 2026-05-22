using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());

            double promedio = Calcular_Promedio(nota1, nota2, nota3);
            string estado = Clasificar_Estudiante(promedio);
            Mostrar_Reporte(promedio, estado);

        }
        static double Calcular_Promedio(double nota1, double nota2, double nota3)
        {
            double promedio = (nota1 + nota2 + nota3) / 3;
            return promedio;
        }
        static string Clasificar_Estudiante(double promedio)
        {
            if (promedio >= 11)
            {
                return "Aprobado";
            }
            else
            {
                return "Desaprobado";
            }
        }
        static void Mostrar_Reporte(double promedio, string estado)
        {
            Console.WriteLine("/n === REPORTE DE NOTAS ===");
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Estado: {estado}");
        }
    }
}
