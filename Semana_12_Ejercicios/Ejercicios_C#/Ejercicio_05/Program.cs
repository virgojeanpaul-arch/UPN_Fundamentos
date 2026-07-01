using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    internal class Program
    {
        static void MostrarCodigos(int[] arreglo, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] codigos = new int[7];
            int cantidad = 5;

            codigos[0] = 105;
            codigos[1] = 103;
            codigos[2] = 109;
            codigos[3] = 101;
            codigos[4] = 108;

            Console.WriteLine("ANTES DE ELIMINAR:");
            MostrarCodigos(codigos, cantidad);

            Console.Write("\nIngrese código a eliminar: ");
            int codigobuscado = int.Parse(Console.ReadLine());

            int posicion = -1;

            for (int i = 0; i < cantidad; i++)
            {
                if (codigos[i] == codigobuscado)
                {
                    posicion = i;
                }
            }

            if (posicion != -1)
            {
                for (int i = posicion; i < cantidad - 1; i++)
                {
                    codigos[i] = codigos[i + 1];
                }

                cantidad--;

                for (int i = 0; i < cantidad - 1; i++)
                {
                    for (int j = 0; j < cantidad - 1 - i; i++)
                    {
                        if (codigos[j] > codigos[j + 1])
                        {
                            int auxiliar = codigos[i];

                            codigos[j] = codigos[j + 1];

                            codigos[j + 1] = auxiliar;
                        }
                    }
                }

                Console.WriteLine("\nDESPUES DE ELIMINAR Y ORDENAR:");
                MostrarCodigos(codigos, cantidad);
            }
            else
            {
                Console.WriteLine("Código no encontrado.");
            }
        }
    }
}
