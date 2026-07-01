using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] precios = new double[8];
            int cantidad = 4;

            precios[0] = 35;
            precios[1] = 20;
            precios[2] = 50;
            precios[3] = 18;

            Console.WriteLine("ANTES DE ELIMINAR Y ORDENAR:");
            MostrarPrecios(precios, cantidad);

            if (cantidad < precios.Length)
            {
                Console.Write("\nIngrese el nuevo precio: S/");
                double nuevo_Precio = double.Parse(Console.ReadLine());

                if (nuevo_Precio > 0)
                {
                    precios[cantidad] = nuevo_Precio;
                    cantidad = cantidad + 1;

                    for (int i = 0; i < cantidad - 1; i++)
                    {
                        for (int j = 0; j < cantidad - 1 - i; j++)
                        {
                            if (precios[j] > precios[j + 1])
                            {
                                double auxiliar = precios[j];
                                precios[j] = precios[j + 1];
                                precios[j + 1] = auxiliar;
                            }
                        }
                    }

                    Console.WriteLine("\nDESPUÉS DE INSERTAR Y ORDENAR:");
                    MostrarPrecios(precios, cantidad);
                }
                else
                {
                    Console.WriteLine("El precio debe ser mayor que 0.");
                }
            }
            else
            {
                Console.WriteLine("No hay espacio disponible.");
            }
        }
        static void MostrarPrecios(double[] arreglo, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"S/{arreglo[i]:F2}");
            }

            Console.WriteLine();
        }
    }
}
