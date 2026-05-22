using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static double Calcular_Bruto(double horas)
        {
            return horas * 12.50;
        }
        static double Calcular_Descuento(double bruto)
        {
            return bruto * 0.05;
        }
        static double Calcular_Neto(double bruto, double descuento)
        {
            return bruto - descuento;
        }
        static void Main(string[] args)
        {
            Console.Write("Horas trabajadas: ");
            double horas = double.Parse(Console.ReadLine());

            double bruto = Calcular_Bruto(horas);
            double descuento = Calcular_Descuento(bruto);
            double neto = Calcular_Neto(bruto, descuento);

            Console.WriteLine("/n === BOLETA DE SUELDO ===");
            Console.WriteLine($"Sueldo bruto: S/.{bruto:F2}");
            Console.WriteLine($"Descuento (5%): S/.{descuento:F2}");
            Console.WriteLine($"Sueldo neto: S/.{neto}");
        }
    }
}
