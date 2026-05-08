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
            int stock = 500;
            int Total_vendido = 0;

            Console.Write("Unidades vendidas (0 para salir): ");
            int venta = int.Parse(Console.ReadLine());

            while (venta != 0)
            {
                if (venta < 0)
                {
                    Console.WriteLine("Error: Cantidad no puede ser negativa");
                }
                else if (venta > stock)
                {
                    Console.WriteLine($"Error: Stock insuficiente. Quedan {stock}");
                }
                else
                {
                    stock = stock - venta;
                    Total_vendido = Total_vendido + venta;

                    Console.WriteLine($"Venta registrada. Stock: {stock}");
                }

                Console.Write("Unidades vendidas (0 para salir): ");
                venta = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Stock restante: {stock}");
            Console.WriteLine($"Total vendido: {Total_vendido}");
        }
    }
}
