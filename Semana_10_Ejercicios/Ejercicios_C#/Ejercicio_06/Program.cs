using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    internal class Program
    {
        static double Calcular_Venta_Turno(int cantidad, double precio)
        {
            return cantidad * precio;
        }
        static void Main(string[] args)
        {
            double total_Dia = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Turno {i}");
                int cantidad;

                do
                {
                    Console.Write("Cantidad: ");
                    cantidad = int.Parse(Console.ReadLine());
                    if (cantidad <= 0)
                    {
                        Console.WriteLine("Error: la cantidad debe ser mayor que 0");
                    }
                } while (cantidad <= 0);
                double precio;

                do
                {
                    Console.Write("Precio: ");
                    precio = double.Parse(Console.ReadLine());
                    if (precio <= 0)
                    {
                        Console.WriteLine("Error: el precio debe ser mayor que 0");
                    }
                } while (precio <= 0);

                double venta = Calcular_Venta_Turno(cantidad, precio);
                total_Dia = total_Dia + venta;

                Console.WriteLine($"Venta de turno: S/{venta:F2}");
            }
            Console.WriteLine($"Total vendido del día: S/{total_Dia:F2}");
        }
    }
}
