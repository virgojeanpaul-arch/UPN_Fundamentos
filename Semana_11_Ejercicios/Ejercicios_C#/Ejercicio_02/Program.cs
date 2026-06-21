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
            Console.Write("Cantidad de estudiantes: ");
            int n = int.Parse(Console.ReadLine());

            double[] notas = new double[n];
            double suma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nota {1 + i}: ");
                notas[i] = double.Parse(Console.ReadLine());
                suma = suma + notas[i];
            }

            double minima = notas[0];
            double maxima = notas[0];

            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] < minima)
                {
                    minima = notas[i];
                }

                if (notas[i] > maxima)
                {
                    maxima = notas[i];
                }
            }

            Console.WriteLine($"Promedio: {suma / n:F2}");
            Console.WriteLine($"Nota mínima: {minima:F2}");
            Console.WriteLine($"Nota máxima: {maxima:F2}");
        }
    }
}
