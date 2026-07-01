using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[6];
            int cantidad = 4;

            notas[0] = 13;
            notas[1] = 15;
            notas[2] = 11;
            notas[3] = 17;

            int posicion = 2;
            int nueva_Nota = 18;

            Console.WriteLine("ANTES DE INSERTAR:");
            MostrarArreglo(notas, cantidad);

            if (posicion >= 0 && posicion <= cantidad && cantidad < notas.Length)
            {
                for (int i = cantidad; i > posicion; i--)
                {
                    notas[i] = notas[i - 1];
                }

                notas[posicion] = nueva_Nota;
                cantidad += 1;

                Console.WriteLine("\nDESPUÉS DE INSERTAR:");
                MostrarArreglo(notas, cantidad);
            }
            else
            {
                Console.WriteLine("No se puede insertar la nota.");
            }
        }
        static void MostrarArreglo(int[] arreglo, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write(arreglo[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
