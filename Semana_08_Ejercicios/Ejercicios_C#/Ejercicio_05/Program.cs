using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la nota final del estudiante: ");
            double nota_final = double.Parse(Console.ReadLine());

            bool Nota_Valida = Validar_Nota(nota_final);

            if (Nota_Valida)
            {
                string clasificacion = Clasificar_Nota(nota_final);
                Mostrar_Reporte(nota_final, clasificacion);
            }
            else
            {
                Console.WriteLine("Error: la nota debe estar entre 0 y 20");
            }
        }
        static bool Validar_Nota(double nota_final)
        {
            if (nota_final >= 0 && nota_final <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string Clasificar_Nota(double nota_final)
        {
            if (nota_final >= 18)
            {
                return "EXCELENTE";
            }
            else if (nota_final >= 14)
            {
                return "BUENO";
            }
            else if (nota_final >= 11)
            {
                return "REGULAR";
            }
            else
            {
                return "DESAPROBADO";
            }
        }
        static void Mostrar_Reporte(double nota_final, string clasificacion)
        {
            Console.WriteLine("/n === REPORTE FINAL ===");
            Console.WriteLine($"Nota ingresada: {nota_final:F2}");
            Console.WriteLine($"Clasificación: {clasificacion}");
        }
    }
}
