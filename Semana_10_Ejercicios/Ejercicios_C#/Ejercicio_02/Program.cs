using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static double Calcular_Importe(int cantidad, double precio)
        {
            return cantidad * precio;
        }
        static void Mostrar_Pedido(string plato, int cantidad, double importe)
        {
            Console.WriteLine($"Pedido: {plato} | Cantidad: {cantidad} | Importe: S/{importe:F2}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONTROL DE PEDIDOS AL DÍA ===");

            double total_Dia = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"\nPedido {i}");

                Console.Write("Nombre del plato: ");
                string plato = Console.ReadLine();

                Console.Write("Cantidad: ");
                int cantidad = int.Parse(Console.ReadLine());

                Console.Write("Precio unitario: S/");
                double precio = double.Parse(Console.ReadLine());

                double importe = Calcular_Importe(cantidad, precio);
                total_Dia = total_Dia + importe;
                Mostrar_Pedido(plato, cantidad, importe);
            }
            Console.WriteLine($"\nTotal del día: S/{total_Dia:F2}");
        }
    }
}
