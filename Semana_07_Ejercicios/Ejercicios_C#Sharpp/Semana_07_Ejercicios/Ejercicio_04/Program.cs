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
            double subtotal = 0;
            int totalArticulos = 0;
            int opcion;

            do
            {
                Console.WriteLine("/n === TIENDA TECH ===");
                Console.WriteLine("1. USB 32GB - S/.25.00");
                Console.WriteLine("2. Mouse inalámbrico - S/.45.00");
                Console.WriteLine("3. Audifonos - S/.60.00");
                Console.WriteLine("0. Finalizar compra");
                Console.Write("Elija una de las opciones: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion >= 1 && opcion <= 3)
                {
                    Console.Write("Cantidad: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    double precio = 0;

                    if (opcion == 1)
                    {
                        precio = precio + 25;
                    }
                    else if (opcion == 2)
                    {
                        precio = precio + 45;
                    }
                    else if (opcion == 3)
                    {
                        precio = precio + 60;
                    }

                    subtotal = subtotal + (precio * cantidad);
                    totalArticulos = totalArticulos + cantidad;

                }
                else if (opcion != 0)
                {
                    Console.WriteLine("Opción no válida.");
                }
            } while (opcion != 0);

            double descuento = 0;

            if (subtotal > 100)
            {
                descuento = subtotal * 0.10;
            }

            double total = subtotal - descuento;

            Console.WriteLine("/n === RESUMEN DE COMPRA ===");
            Console.WriteLine($"Artículos_ {totalArticulos}");
            Console.WriteLine($"Subtotal: {subtotal:F2}");
            Console.WriteLine($"Descuento: {descuento:F2}");
            Console.WriteLine($"TOTAL: {total:F2}");
        }
    }
}
