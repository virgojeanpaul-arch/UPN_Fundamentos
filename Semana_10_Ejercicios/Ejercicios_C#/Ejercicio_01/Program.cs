using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static double Calcular_Salario(double valor_Hora, int horas)
        {
            if (horas <= 192)
            {
                return valor_Hora * horas;
            }

            int horas_Extra = horas - 192;
            double pago_Normal = valor_Hora * 192;
            double pago_Extra = horas_Extra * valor_Hora * 1.50;
            return pago_Normal + pago_Extra;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== PLANILLA INDUSTRIAL ===");

            Console.Write("Cantidad de obreros: ");
            int n = int.Parse(Console.ReadLine());

            // Acumulador del total de salarios.
            double totalPlanilla = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($" \nObrero {i} ");

                Console.Write("Valor por hora: S/");
                double vh = double.Parse(Console.ReadLine());

                Console.Write("Horas trabajadas: ");
                int hmt = int.Parse(Console.ReadLine());

                // Llamamos a la función para calcular el salario.
                double salario = Calcular_Salario(vh, hmt);

                // Acumulamos el salario de cada obrero.
                totalPlanilla = totalPlanilla + salario;

                Console.WriteLine($"Salario: S/ {salario:F2} ");
            }
            Console.WriteLine($"\nTotal de plantilla: S/{totalPlanilla:F2}");
        }
    }
}
