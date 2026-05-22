using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el consumo: ");
            double m3 = double.Parse(Console.ReadLine());

            double costo = Calcular_CostoAgua(m3);
            Mostrar_Recibo(m3, costo);
        }
        static double Calcular_CostoAgua(double m3)
        {
            double costo;

            if (m3 <= 20)
            {
                costo = m3 * 1.80;
            }
            else
            {
                double exceso = m3 - 20;
                costo = (20 * 1.80) + (exceso * 2.50);
            }
            return costo;
        }
        static void Mostrar_Recibo(double m3, double costo)
        {
            Console.WriteLine("n/ === RECIBO DE AGUA ===");
            Console.WriteLine($"Consumo: {m3} m3");
            Console.WriteLine($"Costo total: S/.{costo:F2}");
        }
    }
}
