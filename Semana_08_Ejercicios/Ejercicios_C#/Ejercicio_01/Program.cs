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
            Console.Write("Ingrese la cantidad comprada: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio unitario: S/.");
            double precio_Unitario = double.Parse(Console.ReadLine());

            double subtotal = Calcular_Subtotal(cantidad, precio_Unitario);
            double igv = Calcular_IGV(subtotal);
            double total = Calcular_Total(subtotal, igv);

            Console.WriteLine("/n === BOLETA DE VENTA ===");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Precio unitario: {precio_Unitario}");
            Console.WriteLine($"Subtotal: S/.{subtotal:F2}");
            Console.WriteLine($"IGV (18%): S/.{igv:F2}");
            Console.WriteLine($"Total a pagar: S/.{total:F2}");
        }

        static double Calcular_Subtotal(int cantidad, double precio_Unitario)
        {
            double subtotal = cantidad * precio_Unitario;
            return subtotal;
        }
        static double Calcular_IGV(double subtotal)
        {
            double igv = subtotal * 0.18;
            return igv;
        }
        static double Calcular_Total(double subtotal, double igv)
        {
            double total = subtotal + igv;
            return total;
        }
    }
}
