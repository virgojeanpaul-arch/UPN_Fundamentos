using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el consumo: ");
            double consumo = double.Parse(Console.ReadLine());

            double propina = CalcularPropina(consumo);
            double total = CalcularTotal(consumo, propina);

            Console.WriteLine($"Consumo: S/.{consumo}");
            Console.WriteLine($"Propina sugerida: S/.{propina}");
            Console.WriteLine($"Total a pagar: S/.{total}");
        }

        static double CalcularPropina(double consumo)
        {
            return consumo * 0.10;
        }

        static double CalcularTotal(double consumo, double propina)
        {
            return consumo + propina;
        }
    }
}
