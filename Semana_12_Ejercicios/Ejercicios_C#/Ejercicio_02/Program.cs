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
            double[] ventas = new double[8];
            int cantidad = 5;

            ventas[0] = 25;
            ventas[1] = 40;
            ventas[2] = 15;
            ventas[3] = 30;
            ventas[4] = 50;

            int posicion = 1;

            Console.WriteLine("ANTES DE ELIMINAR:");
            MostrarVentas(ventas, cantidad);

            if (posicion >= 0 && posicion < cantidad)
            {
                for (int i = posicion; i < cantidad - 1; i++)
                {
                    ventas[i] = ventas[i + 1];
                }

                cantidad = cantidad - 1;

                Console.WriteLine("\nDESPUÉS DE ELIMINAR:");
                MostrarVentas(ventas, cantidad);
            }
            else
            {
                Console.WriteLine("Posición no válida.");
            }
        }
        static void MostrarVentas(double[] arreglo, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"S/{arreglo[i]:F2} ");
            }

            Console.WriteLine();
        }
    }
}
