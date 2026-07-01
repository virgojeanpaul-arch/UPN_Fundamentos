using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tiempos = { 18, 12, 25, 10, 14, 20 };
            int cantidad = tiempos.Length;

            Console.WriteLine("ANTES DE ORDENAR:");
            MostrarArreglo(tiempos);

            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = 0; j < cantidad - 1 - i; j++)
                {
                    if (tiempos[j] > tiempos[j + 1])
                    {
                        int auxiliar = tiempos[j];
                        tiempos[j] = tiempos[j + 1];
                        tiempos[j + 1] = auxiliar;
                    }
                }
            }

            Console.WriteLine("\nDESPUÉS DE ORDENAR");
            MostrarArreglo(tiempos);
        }
        static void MostrarArreglo(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
